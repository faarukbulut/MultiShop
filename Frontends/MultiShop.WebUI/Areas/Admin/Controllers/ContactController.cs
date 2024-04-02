using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CatalogServices.ContactServices;

namespace MultiShop.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _contactService.GetAllContact();
            return View(values);
        }

        public async Task<IActionResult> DeleteContact(string id)
        {
            await _contactService.DeleteContact(id);
            return RedirectToAction("Index");
        }
    }
}
