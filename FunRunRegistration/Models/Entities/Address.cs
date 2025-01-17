using System.ComponentModel.DataAnnotations;

namespace FunRunRegistration.Models.Entities
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string? AddressStreet { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressPostal { get; set; }
    }
}
