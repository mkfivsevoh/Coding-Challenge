using ClarkCodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClarkCodingChallenge.DataAccess
{
    public class ContactsDataAccess : IContactsDataAccess
    {        
        List<Contact> contacts = new List<Contact>() {
            new Contact("Tony", "Stark", "tony@aventower.org"),
            new Contact("Wanda", "Maximoff", "wanda@aventower.org"),
            new Contact("Stephen", "Strange", "drsteve@aventower.org")};

        public List<Contact> GetAllContacts()
        {
            return contacts;
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public List<Contact> GetContactByLastName(string lastName)
        {
            return contacts.Where(c => String.Equals(c.lastName, lastName, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}
