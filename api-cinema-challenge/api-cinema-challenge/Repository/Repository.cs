using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Data;
using api_cinema_challenge.DTOs;
using System.Threading.Tasks;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class Repository: IRepository
    {
        private CinemaContext _databaseContext;

        public Repository(CinemaContext db)
        {
            _databaseContext = db;
        }

        public async Task<Customers> CreateCustomer(CustomersPost customer)
        {
            var newCustomer = new Customers() { Name = customer.Name, Email = customer.Email, Phone = customer.Phone, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow };
            await _databaseContext.Customers.AddAsync(newCustomer);
            await _databaseContext.SaveChangesAsync();
            return newCustomer;
        }

        public async Task<Customers> DeleteCustomer(int id)
        {
            var customer = await _databaseContext.Customers.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (customer == null) return null;
            _databaseContext.Customers.Remove(customer);
            await _databaseContext.SaveChangesAsync();
            return customer;
        }

        public async Task<IEnumerable<Customers>> GetCustomers()
        {
            return await _databaseContext.Customers.ToListAsync();
        }

        public async Task<Customers> UpdateCustomer(int id, CustomerPut customerPut)
        {
            var customer = await _databaseContext.Customers.Where(c => c.Id == id).FirstOrDefaultAsync();
            if (customer == null) return null;
            if (customerPut.Name is not null) customer.Name = customerPut.Name;
            if (customerPut.Email is not null) customer.Email = customerPut.Email;
            if (customerPut.Phone is not null) customer.Phone = customerPut.Phone;
            customer.UpdatedAt = DateTime.UtcNow;
            await _databaseContext.SaveChangesAsync();
            return customer;
            
        }
    }
}
