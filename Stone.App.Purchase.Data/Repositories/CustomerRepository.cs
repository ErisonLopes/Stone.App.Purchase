using Stone.App.Purchase.Domain.Interfaces.Repository;
using Stone.App.Purchase.Domain.Models;
using Stone.App.Purchase.Infrastructure.MongoDB.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Stone.App.Purchase.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ICustomerCollection _collection;

        public CustomerRepository(ICustomerCollection customerCollection)
        {
            _collection = customerCollection;
        }

        public async Task AddCustomerAsync(Customer customer, CancellationToken cancellationToken)
        {
            customer.CustomerId = Guid.NewGuid().ToString();
            await _collection.AddAsync(customer, cancellationToken);
        }

        public Task<Customer> GetCustomerById(string id, CancellationToken cancellationToken)
        {
            return _collection.GetByIdAsync(id, cancellationToken);
        }
    }
}
