using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager)
        {
        }
        public ContactHelper Create(ContactData data)
        {
            manager.Navigator.GoToHomePage();
            GoToNewContactPage();
            FillContactForm(data);
            SubmitContactCreation();
            return this;
        }
        public ContactHelper Modify(ContactData newData)
        {
            manager.Navigator.GoToHomePage();
            GoToContactEdit();
            FillContactForm(newData);
            SubmitContactModification();
            return this;
        }
        public ContactHelper Remove()
        {
            manager.Navigator.GoToHomePage();
            SelectContact();
            SubmitContactRemove();
            AcceptRemoveAlert();
            return this;
        }
        public ContactHelper GoToNewContactPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
        public ContactHelper FillContactForm(ContactData data)
        {
            Type(By.Name("firstname"), data.Firstname);
            Type(By.Name("lastname"), data.Lastname);
            return this;
        }
        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
        public ContactHelper GoToContactEdit()
        {
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }
        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }
        public ContactHelper SelectContact()
        {
            driver.FindElement(By.Name("selected[]")).Click();
            return this;
        }
        public ContactHelper SubmitContactRemove()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }
        public ContactHelper AcceptRemoveAlert()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }
    }
}
