using Prism;
using Prism.Ioc;
using Prism.Unity;
using RemsyApp.Helpers;
using RemsyApp.Services;
using RemsyApp.Services.Apis;
using RemsyApp.ViewModels;
using RemsyApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RemsyApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }
        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync($"{NavigationUri.MenuDetailPage}/{NavigationUri.HomePage}");

        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginPage,LoginPageViewModel>(NavigationUri.LoginPage);
            containerRegistry.RegisterForNavigation<AgentsPage,AgentsPageViewModel>(NavigationUri.AgentsPage);
            containerRegistry.RegisterForNavigation<AppointmentPage, AppointmentPageViewModel>(NavigationUri.AppointmentPage);
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>(NavigationUri.HomePage);
            containerRegistry.RegisterForNavigation<DepartmentPage, DepartmentPageViewModel>(NavigationUri.DepartmentPage);
            containerRegistry.RegisterForNavigation<MenuDetailPage, MenuDetailPageViewModel>(NavigationUri.MenuDetailPage);
            containerRegistry.RegisterForNavigation<OficePage, OficePageViewModel>(NavigationUri.OficePage);
            containerRegistry.RegisterForNavigation<ProfilePage, ProfilePageViewModel>(NavigationUri.ProfilePage);
            containerRegistry.RegisterForNavigation<HousesPage, HousesPageViewModel>(NavigationUri.HousesPage); 
            containerRegistry.RegisterInstance<IPropertyService>(new PropertyService(new ApiClient<IPropertyServiceApi>(ApiKey.ApiUrl)));
            containerRegistry.RegisterInstance<IPersonService>(new PersonService(new ApiClient<IPersonServiceApi>(ApiKey.ApiUrl)));
            containerRegistry.RegisterInstance<IReportService>(new ReportService(new ApiClient<IReportServiceApi>(ApiKey.ApiUrl)));
            containerRegistry.RegisterInstance<ISaleService>(new SaleService(new ApiClient<ISaleServiceApi>(ApiKey.ApiUrl)));
            containerRegistry.RegisterInstance<IAddressService>(new AddressService(new ApiClient<IAddressServiceApi>(ApiKey.ApiUrl)));
            containerRegistry.RegisterInstance<IAppointmentService>(new AppointmentService(new ApiClient<IAppointmentServiceApi>(ApiKey.ApiUrl)));

        }
    }
}
