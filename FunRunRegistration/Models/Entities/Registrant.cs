using System.ComponentModel.DataAnnotations;

namespace FunRunRegistration.Models.Entities
{
    public class Registrant
    {
        [Key]
        public int UserId { get; set; }
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        public int? UserAddressId { get; set; }
        public string? UserTelephone { get; set; }
        public DateTime UserBirthday { get; set; }
        public string? UserGender { get; set; }

        public Address? Address { get; set; }
    }
}
