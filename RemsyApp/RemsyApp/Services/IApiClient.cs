
namespace RemsyApp.Services
{
    public interface IApiClient<T>
    {
        T Client { get; }
    }

}
