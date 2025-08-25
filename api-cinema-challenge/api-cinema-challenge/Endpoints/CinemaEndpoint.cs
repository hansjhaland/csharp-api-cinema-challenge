using api_cinema_challenge.DTOs;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.DataProtection.Repositories;
using System.Runtime.CompilerServices;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            app.MapGet("/customers", GetCustomers);
            app.MapPost("/customers", CreateCustomer);
            app.MapPut("/customers/{id}", UpdateCustomer);
            app.MapDelete("/customers/{id}", DeleteCustomer);

            //app.MapGet("/movies");
            //app.MapPost("/movies");
            //app.MapPut("/movies");
            //app.MapDelete("/movies");

            //app.MapGet("/movies/{id}/screenings");
            //app.MapPost("/movies/{id}/screenings");
            //app.MapPut("/movies/{id}/screenings");
            //app.MapDelete("/movies/{id}/screenings");

        }

        private static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            var entity = await repository.DeleteCustomer(id);
            return TypedResults.Ok(entity);
        }

        private static async Task<IResult> UpdateCustomer(IRepository repository, int id, CustomerPut customer)
        {
            var entity = await repository.UpdateCustomer(id, customer);
            return TypedResults.Created($"/customers/{id}", entity);
        }

        private static async Task<IResult> CreateCustomer(IRepository repository, CustomersPost customer)
        {
            var entity = await repository.CreateCustomer(customer);
            if (entity == null) return TypedResults.BadRequest();
            CustomersGet result = new CustomersGet()
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Phone = entity.Phone,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
            };
            return TypedResults.Created($"/customers/{entity.Id}", result);
        }

        private static async Task<IResult> GetCustomers(IRepository repository)
        {
            var response = await repository.GetCustomers();
            //List<CustomersGet> results = new List<CustomersGet>();
            //foreach (var item in response)
            //{
            //    CustomersGet customer = new CustomersGet();
            //    customer.Id = item.Id;
            //    customer.Name = item.Name;
            //    customer.Email = item.Email;
            //    customer.Phone = item.Phone;
            //    customer.CreatedAt = item.CreatedAt;
            //    customer.UpdatedAt = item.UpdatedAt;
            //    results.Add(customer);
            //    //results.Add(new CustomersGet() { Id = item.Id, Name = item.Name, Email = item.Email, Phone = item.Phone, CreatedAt = item.CreatedAt, UpdatedAt = item.UpdatedAt });
            //}
            //return TypedResults.Ok(results);
            return TypedResults.Ok(response);
        }
    }
}
