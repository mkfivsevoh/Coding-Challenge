using Microsoft.AspNetCore.Mvc;
using ClarkCodingChallenge.DataAccess;
using ClarkCodingChallenge.Models;
using System.Collections.Generic;
using System.Linq;

namespace ClarkCodingChallenge.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscribersController : Controller
    {
        private readonly IContactsDataAccess _contacts;
        public SubscribersController(IContactsDataAccess contacts)
        {
            _contacts = contacts;
        }

        [HttpGet]
        public IEnumerable<Contact> Index(string lastName = null, bool ascendingOrder = true)
        {
            var results = new List<Contact>();

            //filter logic
            if (null == lastName)
            {
                results = _contacts.GetAllContacts();
            }
            else
            {
                results = _contacts.GetContactByLastName(lastName);
            }


            //sort logic
            if (ascendingOrder)
            {
                return results.OrderBy(c => c.lastName).ThenBy(c => c.firstName).ToList();
            }
            else
            {
                return results.OrderByDescending(c => c.lastName).ThenByDescending(c => c.firstName).ToList();
            }

        }
    }
}
