using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Stone.App.Purchase.Infrastructure.MongoDB.Interfaces;

namespace Stone.App.Purchase.Infrastructure.MongoDB.Contexts
{
    internal class StoneAppPurchaseDatabase : IStoneAppPurchaseDatabase
    {
        public IMongoDatabase Database { get; }

        public StoneAppPurchaseDatabase(IMongoClient client, IConfiguration configuration)
        {
            var mongoUrl = MongoUrl.Create(configuration.GetConnectionString("MongoDb"));
            Database = client.GetDatabase(mongoUrl.DatabaseName);
        }
    }
}
