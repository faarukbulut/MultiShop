using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.ContactDtos;
using MultiShop.WebUI.Services.CatalogServices.AboutServices;
using MultiShop.WebUI.Services.CatalogServices.ContactServices;

namespace MultiShop.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IContactService _contactService;

        public ContactController(IAboutService aboutService, IContactService contactService)
        {
            _aboutService = aboutService;
            _contactService = contactService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _aboutService.GetAllAbout();

            ViewBag.Adres = values.Select(x => x.Address).FirstOrDefault();
            ViewBag.Mail = values.Select(x => x.Email).FirstOrDefault();
            ViewBag.Telefon = values.Select(x => x.Phone).FirstOrDefault();
            ViewBag.Map = values.Select(x => x.Map).FirstOrDefault();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateContactDto createContactDto)
        {
            createContactDto.isRead = false;
            createContactDto.SendDate = DateTime.Now;

            await _contactService.CreateContact(createContactDto);
            return RedirectToAction("Index");
        }

    }
}
