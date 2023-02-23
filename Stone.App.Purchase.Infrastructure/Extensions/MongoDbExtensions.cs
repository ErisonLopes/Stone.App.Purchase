using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using Stone.App.Purchase.Infrastructure.MongoDB.Collections;
using Stone.App.Purchase.Infrastructure.MongoDB.Contexts;
using Stone.App.Purchase.Infrastructure.MongoDB.Interfaces;

namespace Stone.App.Purchase.Infrastructure.Extensions
{
    public static class MongoDbExtensions
    {

        public static IServiceCollection AddMongoDb(this IServiceCollection services, string connectionString)
        {
            services
                .AddSingleton<IMongoClient>(_ => new MongoClient(MongoUrl.Create(connectionString)))
                .AddSingleton<IStoneAppPurchaseDatabase, StoneAppPurchaseDatabase>()
                .AddSingleton<IStoneAppPurchaseContext, StoneAppPurchaseContext>()
                .AddTransient<ICustomerCollection, CustomerCollection>();

            return services;
        }
    }
}
