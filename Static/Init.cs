using System;
using Contracts;
using DefaultContractImplementation;
using Microsoft.Extensions.DependencyInjection;

namespace Static
{
    public static class ServiceExtension
    {
        public static void AddTransientBinding(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IProductRepository, FakeProductRepository>();
        }
    }
}
