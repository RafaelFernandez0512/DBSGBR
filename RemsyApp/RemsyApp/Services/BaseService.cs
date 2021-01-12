using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Polly;
using Refit;
using Xamarin.Essentials;

namespace RemsyApp.Services
{
    public abstract class BaseService
    {
        protected Dictionary<int, CancellationTokenSource> runningTasks = new Dictionary<int, CancellationTokenSource>();

        public BaseService()
        {
            Connectivity.ConnectivityChanged += OnConnectivityChanged;
        }


        void OnConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            if (e.NetworkAccess != NetworkAccess.Internet)
            {
                var items = runningTasks.ToList();
                foreach (var item in items)
                {
                    item.Value.Cancel();
                    runningTasks.Remove(item.Key);
                }
            }
        }

        protected async Task<Response<TData>> RemoteRequestAsync<TData>(Task<HttpResponseMessage> task)
        {
            HttpResponseMessage responseMessage = await Policy
            .Handle<WebException>()
            .Or<ApiException>()
            .Or<TaskCanceledException>()
            .WaitAndRetryAsync
            (
                retryCount: 3,
                sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt))
            )
            .ExecuteAsync(async () =>
            {
                var cts = new CancellationTokenSource();
                runningTasks.Add(task.Id, cts);
                var result = await task;
                runningTasks.Remove(task.Id);

                return result;
            });

            if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
            {
                return Response<TData>.Void();
            }
                
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonResult = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
                var result = await Task.Run(() => JsonConvert.DeserializeObject<TData>(jsonResult));
                return Response<TData>.Ok(result);
            }
            else
            {
                Debug.Write(responseMessage.Content);
                return null;
            }
        }
    }
}
