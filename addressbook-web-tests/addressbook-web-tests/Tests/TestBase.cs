using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressbookTests
{
    public class TestBase
    {
        protected ApplicationManager app;
        
        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();

            app.Navigator.GoToHomePage();
            app.Auth.LoginFields(new AccountData("admin", "secret"));
            app.Auth.LoginSubmit();
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
    }
}
