namespace FunRunRegistration.Models.ViewModels
{
    public class AddRegistrantViewModel
    {
        // Registrant properties
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        public string? UserTelephone { get; set; }
        public DateTime UserBirthday { get; set; }
        public string? UserGender { get; set; }

        // Address properties
        public string? AddressStreet { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressPostal { get; set; }
    }
}
