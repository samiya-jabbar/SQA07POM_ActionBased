using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Web;

namespace SQA07POMActionBased
{    
    public class SelectPage : BasePage
    {
        public void Select()
        {
            driver.FindElement(By.Id("radiobutton_2")).Click();
            driver.FindElement(By.Id("continue")).Click();         
        }
    }
}
