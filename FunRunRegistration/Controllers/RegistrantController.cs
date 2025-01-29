using FunRunRegistration.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FunRunRegistration.Controllers
{
    public class RegistrantController : Controller
    {
        public IActionResult Add(AddRegistrantViewModel viewModel)
        {
            return View();
        }
    }
}
