using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Collections;

namespace ClarkCodingChallenge.Models
{
    public class Contact
    {

        public Contact() { }

        public Contact(string firstName, string lastName, string emailAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
        }

        [Required(ErrorMessage = "First name is required")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string lastName { get; set; }


        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string emailAddress { get; set; }


    }
}
