using Concrete;
using Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DISetup
{
    //This class is used by the UI project and its logic depends on the UI project requirements
    public static class ServiceExtension
    {
        //This method sets up the bindings depending on the UI project requirements
        public static void AddTransientBinding(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
