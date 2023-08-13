using ECom.ShoppingCart.Application.Contracts.Persistence;
using ECom.ShoppingCart.Persistence.Repositories.DummyStaticRepo;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.ShoppingCart.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<ICartPersist,CartDummyRepository>();
            return services;
        }
    }
}
