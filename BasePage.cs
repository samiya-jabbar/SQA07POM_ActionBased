using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SQA07POMActionBased
{
    public class BasePage
    {
        public static IWebDriver driver;

        public static void SeleniumInitialization(string browser)
        {
            driver = new ChromeDriver();
        }

        public static void SeleniumClose()
        {
            driver.Close();
        }
        public static void Write(By by, string text)
        {
            driver.FindElement(by).SendKeys(text);
        }

        public static void Click(By by)
        {
            driver.FindElement(by).Click();
        }

        public void Clear(By by)
        {
            driver.FindElement(by).Clear();
        }
    }
}
