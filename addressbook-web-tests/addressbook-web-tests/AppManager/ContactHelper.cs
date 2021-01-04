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
            GoToNewContactPage();
            FillContactForm(data);
            SubmitContactCreation();
            return this;
        }
        public ContactHelper Modify(ContactData newData)
        {
            GoToContactEdit();
            FillContactForm(newData);
            SubmitContactModification();
            return this;
        }
        internal ContactHelper Remove()
        {
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
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(data.Firstname);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(data.Lastname);
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
        private ContactHelper SelectContact()
        {
            driver.FindElement(By.Name("selected[]")).Click();
            return this;
        }
        private ContactHelper SubmitContactRemove()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }
        private ContactHelper AcceptRemoveAlert()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }
    }
}
