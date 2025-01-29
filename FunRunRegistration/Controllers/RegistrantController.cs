using FunRunRegistration.Data;
using FunRunRegistration.Models.Entities;
using FunRunRegistration.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FunRunRegistration.Controllers
{
    public class RegistrantController : Controller
    {
        private readonly ApplicationDbContext dbContext; // ORM
        private readonly ApplicationAdo adoRepository; // ADO

        public RegistrantController(ApplicationDbContext dbContext, ApplicationAdo adoRepository)
        {
            this.dbContext = dbContext;
            this.adoRepository = adoRepository;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddRegistrantViewModel viewModel, string registerType)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            // Create the address for DB table
            var address = new Address
            {
                AddressStreet = viewModel.AddressStreet,
                AddressCity = viewModel.AddressCity,
                AddressPostal = viewModel.AddressPostal
            };

            // Then the registrant
            var registrant = new Registrant
            {
                UserFirstName = viewModel.UserFirstName,
                UserLastName = viewModel.UserLastName,
                UserTelephone = viewModel.UserTelephone,
                UserBirthday = viewModel.UserBirthday,
                UserGender = viewModel.UserGender
            };

            if (registerType == "ADO")
            {
                // Use ADO.NET to insert data
                var addressId = await adoRepository.InsertAddressAsync(address);
                registrant.UserAddressId = addressId;
                await adoRepository.InsertRegistrantAsync(registrant);
            }
            else if (registerType == "ORM")
            {
                // Use Entity Framework (ORM) to insert data
                await dbContext.Addresses.AddAsync(address);
                await dbContext.SaveChangesAsync();
                registrant.UserAddressId = address.AddressId;
                await dbContext.Registrants.AddAsync(registrant);
                await dbContext.SaveChangesAsync();
            }

            return View();
        }
    }
}
