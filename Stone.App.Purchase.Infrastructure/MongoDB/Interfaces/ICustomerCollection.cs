using Stone.App.Purchase.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Stone.App.Purchase.Infrastructure.MongoDB.Interfaces
{
    public interface ICustomerCollection
    {
        Task<Customer> GetByIdAsync(string id, CancellationToken cancellationToken);
        Task AddAsync(Customer customer, CancellationToken cancellationToken);
    }
}
