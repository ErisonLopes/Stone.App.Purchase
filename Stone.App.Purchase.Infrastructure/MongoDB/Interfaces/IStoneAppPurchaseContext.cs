using MongoDB.Driver;
using Stone.App.Purchase.Domain.Models;

namespace Stone.App.Purchase.Infrastructure.MongoDB.Interfaces
{
    public interface IStoneAppPurchaseContext
    {
        IMongoCollection<Customer> Customer { get; }
    }
}
