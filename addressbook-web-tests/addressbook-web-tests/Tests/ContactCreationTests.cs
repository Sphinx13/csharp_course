using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            app.Contacts.GoToNewContactPage();
            ContactData data = new ContactData("Иван", "Иванов");
            app.Contacts.NewContactCreation(data);
            app.Exit.Logout();
        }
    }
}
