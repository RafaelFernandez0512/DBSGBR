using Prism.Commands;
using Prism.Navigation;
using RemsyApp.Helpers;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.ViewModels
{
    public class MenuDetailPageViewModel:BaseViewModel,IInitialize
    {
        public ObservableCollection<MenuItem> MenuItems  { get; set; }
        private MenuItem selectItem;

        public MenuItem SelectItem
        {
            get { return selectItem; }
            set { selectItem = value;
                if (selectItem!= null)
                {
                    GoToNavigation.Execute(selectItem.Url);
                }
            
            }
        }

        public DelegateCommand<string>GoToNavigation { get=>new DelegateCommand<string>(async(param)=>await NavigationService.NavigateAsync(new Uri(param,UriKind.Relative))); }
        public MenuDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public void Initialize(INavigationParameters parameters)
        {
        
            MenuItems = new ObservableCollection<MenuItem> {
                 new MenuItem()
                 {
                     Title="Home",
                     Image="",
                     Url=$"/{NavigationUri.HomePage}"
                     
                 },
                  new MenuItem()
                 {
                      Title="Houses",
                      Image="",
                     Url=$"/{NavigationUri.HousesPage}"
                 },
                 new MenuItem()
                 {
                     Title="Departament",
                     Image="",
                     Url=$"/{NavigationUri.DepartmentPage}"
                 },
                 new MenuItem()
                 {
                     Title="WorkSpace",
                     Image="",
                     Url=$"/{NavigationUri.OficePage}"

                 },
                 new MenuItem()
                 {
                     Title="Agents",
                     Image="",
                     Url=$"/{NavigationUri.AgentsPage}"

                 },
                 new MenuItem()
                 {
                     Title="Calendar",
                     Image="",
                     Url=$"/{NavigationUri.AppointmentPage}"

                 },
            };
            if (parameters.ContainsKey(nameof(EstateAgentDto)))
            {
                var userTytpe = (int)parameters[nameof(EstateAgentDto)];
                if (userTytpe == 2)
                {
                    MenuItems.Add(new MenuItem
                    {
                        Image = "",
                        Title = "Profile",
                        Url = $"/{NavigationUri.ProfilePage}"
                    });
                }
            }

        }
    }
}
