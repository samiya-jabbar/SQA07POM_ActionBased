using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Web;

namespace SQA07POMActionBased
{    
    public class SearchPage : BasePage
    {
        public void Search(string location)
        {
            driver.FindElement(By.Id("location")).SendKeys(location);
            driver.FindElement(By.Id("Submit")).Click();         
        }
    }
}
