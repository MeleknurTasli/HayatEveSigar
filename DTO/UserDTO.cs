
namespace HayatEveSigar.DTO
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public HealthStatus HealthStatus { get; set; }

        public Account? Account { get; set; }
        public Address? Address { get; set; }
    }
}