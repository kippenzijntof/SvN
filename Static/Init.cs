using System;
using Contracts;
using DefaultContractImplementation;
using Microsoft.Extensions.DependencyInjection;

namespace Static
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
