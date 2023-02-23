using MongoDB.Driver;
using Stone.App.Purchase.Domain.Models;
using Stone.App.Purchase.Infrastructure.MongoDB.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Stone.App.Purchase.Infrastructure.MongoDB.Collections
{
    internal class CustomerCollection : ICustomerCollection
    {

        private readonly IStoneAppPurchaseContext _context;

        public CustomerCollection(IStoneAppPurchaseContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Customer customer, CancellationToken cancellationToken)
        {
            await _context.Customer.InsertOneAsync(document: customer, cancellationToken: cancellationToken);
        }

        public async Task<Customer> GetByIdAsync(string id, CancellationToken cancellationToken)
        {
            return await _context.Customer
                .Find(x => x.CustomerId == id)
                .Limit(1)
                .SingleOrDefaultAsync(cancellationToken)
                .ConfigureAwait(false);
        }
    }
}
