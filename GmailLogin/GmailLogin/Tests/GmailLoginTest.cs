using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using GmailLoginPOM.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using GmailLogin.Pages;

namespace GmailLoginPOM
{
    [TestClass]

    public class GmailLoginTest
    {
        IWebDriver webDriver;        


        public void GmailLogintest(IWebDriver webDriver)
        {
            this.webDriver = webDriver;

        }
        [SetUp]
        public void InitializeBrowser()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Cookies.DeleteAllCookies();
            webDriver.Navigate().GoToUrl("https://gmail.com");
        }
        [Test]
        //LoginIntoGmail
        public void TestGmailLogin()  
        {
            Homepage ObjHomePage = new Homepage(webDriver);
            LoginPage ObjLogin = new LoginPage(webDriver);
            string loginpagetitle = ObjLogin.LoginIntoGmail("chellah.btech@gmail.com", "asdf");
            NUnit.Framework.Assert.AreEqual("Gmail", loginpagetitle);
            string hompepageTtl = ObjHomePage.GetHomePageTitle();
            NUnit.Framework.Assert.AreEqual("Inbox", hompepageTtl);
        }
        [TearDown]
        public void Close()
        {
            webDriver.Quit();
        }
    }
}
