using FunRunRegistration.Data;
using FunRunRegistration.Models.Entities;
using FunRunRegistration.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FunRunRegistration.Controllers
{
    public class RegistrantController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public RegistrantController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet] 
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddRegistrantViewModel viewModel)
        {
            // Create the address for DB table
            var address = new Address
            {
                AddressStreet = viewModel.AddressStreet,
                AddressCity = viewModel.AddressCity,
                AddressPostal = viewModel.AddressPostal
            };

            await dbContext.Addresses.AddAsync(address);
            await dbContext.SaveChangesAsync();

            // Then the registrant
            var registrant = new Registrant
            {
                UserFirstName = viewModel.UserFirstName,
                UserLastName = viewModel.UserLastName,
                UserTelephone = viewModel.UserTelephone,
                UserBirthday = viewModel.UserBirthday,
                UserGender = viewModel.UserGender,
                UserAddressId = address.AddressId
            };

            await dbContext.Registrants.AddAsync(registrant);
            await dbContext.SaveChangesAsync();

            return View();
        }
    }
}
