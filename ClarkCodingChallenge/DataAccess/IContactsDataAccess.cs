using ClarkCodingChallenge.Models;
using System.Collections.Generic;

namespace ClarkCodingChallenge.DataAccess
{
    public interface IContactsDataAccess
    {
        void AddContact(Contact contact);
        List<Contact> GetAllContacts();
        List<Contact> GetContactByLastName(string lastName);
    }
}