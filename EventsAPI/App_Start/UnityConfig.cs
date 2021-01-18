using System.Web.Http;
using Unity;
using Unity.WebApi;
using EventsAPI.Services;
using EventsAPI.Core.Repository;


namespace EventsAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            RegisterDependacies();
        }

        public static void RegisterDependacies()
        {

            var container = new UnityContainer();
            container.RegisterType<ICustomerTransactionService, CustomerTransactionService>();
            container.RegisterType<ICustomerTransactionRepository, EventsAPI.Data.CustomerTransactionRepository>();

             // register all your components with the container here
            // it is NOT necessary to register your controllers

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

        }
    }   
}