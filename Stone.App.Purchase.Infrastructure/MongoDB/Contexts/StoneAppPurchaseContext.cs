using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using Stone.App.Purchase.Domain.Models;
using Stone.App.Purchase.Infrastructure.MongoDB.Interfaces;
using System;

namespace Stone.App.Purchase.Infrastructure.MongoDB.Contexts
{
    internal class StoneAppPurchaseContext : IStoneAppPurchaseContext
    {
        private readonly IStoneAppPurchaseDatabase _database;

        public StoneAppPurchaseContext(IStoneAppPurchaseDatabase database)
        {
            var camelCaseElementName = new ConventionPack { new CamelCaseElementNameConvention() };
            var ignoreExtraElements = new ConventionPack { new IgnoreExtraElementsConvention(true) };
            ConventionRegistry.Register("camelCase", camelCaseElementName, t => true);
            ConventionRegistry.Register("ignoreExtraElements", ignoreExtraElements, filter: t => true);

            _database = database;            
        }

        public IMongoCollection<Customer> Customer => _database.Database.GetCollection<Customer>("customer");
    }
}
