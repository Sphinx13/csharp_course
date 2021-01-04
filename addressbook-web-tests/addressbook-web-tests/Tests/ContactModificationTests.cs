﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Петр", "Петров");
            app.Contacts.GoToContactEdit();
            app.Contacts.ContactModification(newData);
            app.Exit.Logout();
        }
    }
}