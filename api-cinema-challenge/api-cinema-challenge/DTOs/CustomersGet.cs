using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs
{
    public class CustomersGet
    {
        public int Id;
        public string Name;
        public string Email;
        public string Phone;
        public DateTime CreatedAt;
        public DateTime UpdatedAt;
    }
}
