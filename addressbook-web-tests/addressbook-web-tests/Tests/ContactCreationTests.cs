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
            ContactNameData fullname = new ContactNameData("Иван", "Иванов");
            app.Contacts.NewContactCreation(fullname);
            app.Exit.Logout();
        }
    }
}
