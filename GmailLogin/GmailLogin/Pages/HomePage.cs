using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailLogin.Pages
{
    class Homepage
    {
        IWebDriver  webDriver;
        public Homepage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;

        }

        public void HompePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        #region object
        //just verifying the title
        #endregion  
        #region Methods
        public string GetHomePageTitle()
        {
            string HomePageTitle = webDriver.Title;
            return HomePageTitle;
        }
        #endregion

    }
}