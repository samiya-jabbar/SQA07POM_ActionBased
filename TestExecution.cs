using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SQA07POMActionBased
{
    [TestClass]
    public class TestExecution
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestInitialize]
        public void TestInit()
        {
            BasePage.SeleniumInitialization("Chrome");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            BasePage.SeleniumClose();
        }

        [TestMethod]
        public void LoginTC()
        {    
            try
            {
                LoginPage loginPage = new LoginPage();
                loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
                log.Info("login to hotel");
            }
            catch
            {
                log.Info("not login to hotel");
            }
        }

        [TestMethod]
        public void SearchTC()
        {
            #region Initialization
            LoginPage loginPage = new LoginPage();
            SearchPage searchPage = new SearchPage();
            #endregion

            #region Scenario/Steps

            loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
            searchPage.Search("Sydney");

            #endregion
        }

        [TestMethod]
        public void SelectTC()
        {
            #region Initialization
            LoginPage loginPage = new LoginPage();
            SearchPage searchPage = new SearchPage();
            SelectPage selectPage = new SelectPage();
            #endregion

            #region Scenario/Steps

            loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
            searchPage.Search("Sydney");
            selectPage.Select();

            #endregion
        }
    }

}

