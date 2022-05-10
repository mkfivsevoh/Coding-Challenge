using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ClarkCodingChallenge.Models;
using ClarkCodingChallenge.DataAccess;

namespace ClarkCodingChallenge.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactsDataAccess _contacts;

        public ContactsController(IContactsDataAccess contacts)
        {
            _contacts = contacts;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SubmitContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contacts.AddContact(contact);
                return View(contact);
            }
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
