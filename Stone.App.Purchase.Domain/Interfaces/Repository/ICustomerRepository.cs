using Stone.App.Purchase.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Stone.App.Purchase.Domain.Interfaces.Repository
{
    public interface ICustomerRepository
    {
        Task AddCustomerAsync(Customer customer, CancellationToken cancellationToken);
        Task<Customer> GetCustomerById(string id, CancellationToken cancellationToken);
    }
}
