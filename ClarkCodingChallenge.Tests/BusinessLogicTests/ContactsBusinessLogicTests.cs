using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ClarkCodingChallenge.Models;
using ClarkCodingChallenge.DataAccess;
using ClarkCodingChallenge.Controllers;


namespace ClarkCodingChallenge.Tests.BusinessLogicTests
{
    [TestClass]
    public class ContactsBusinessLogicTests
    {
        IContactsDataAccess dal = new ContactsDataAccess();

        [TestMethod]
        public void GetSubscriberByNameTest()
        {
            var controller = new SubscribersController(dal);

            var results = controller.Index("Stark");

            Assert.IsTrue(((List<Contact>)results).Count > 0);

            foreach (var contact in results)
            {
                Assert.AreEqual("Stark", contact.lastName);
            }
        }
    }
}
