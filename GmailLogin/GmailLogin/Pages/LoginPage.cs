using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailLoginPOM.Pages
{
    class LoginPage
    {
        IWebDriver webDriver;
        public LoginPage(IWebDriver webDriver)
        {
            
            this.webDriver = webDriver;
            
        }
        #region Objects
        private IWebElement EmailTextBox
        {
            get
            {
                return webDriver.FindElement(By.Id("identifierId"));
            }
        }

        private IWebElement NextBtn
        {
            get
            {
                return webDriver.FindElement(By.Id("next"));
            }
        }

        private IWebElement PasswordBox
        {
            get
            {
                return webDriver.FindElement(By.Id("Passwd"));
            }
        }
        private IWebElement LoginBtn
        {
            get
            {
                return webDriver.FindElement(By.Id("signIn"));
            }
        }
        #endregion

        #region Methods
        public string LoginIntoGmail(string username, string password)
        {
            EmailTextBox.SendKeys(username);
            NextBtn.Click();
            PasswordBox.SendKeys(password);
            string LoginPagetitle = webDriver.Title;
            LoginBtn.Click();
            return LoginPagetitle;
        }
        #endregion 

    }
}
