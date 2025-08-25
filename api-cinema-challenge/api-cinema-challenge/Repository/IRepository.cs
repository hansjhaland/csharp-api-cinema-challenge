using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        public Task<IEnumerable<Customers>> GetCustomers();
        public Task<Customers> CreateCustomer(CustomersPost customer);
        public Task<Customers> UpdateCustomer(int id, CustomerPut customer);
        public Task<Customers> DeleteCustomer(int id);
    }
}
