using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using mynewtestingapp.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace mynewtestingapp.TestCases
{
    public class App1TestCases
    {
        public string[] TestAction1()
        {
            IWebDriver driver;
            driver = new FirefoxDriver();
            driver.Url = "http://life-test:1364/ContactManagingDirector";
            Thread.Sleep(1000);
            IWebElement course = driver.FindElement(By.XPath("//div[@id='complaint-step-1']/div/div/div/div/span/span/span"));
            course.Click();
            IWebElement courseslect = driver.FindElement(By.XPath("/html/body/span[2]/span/span[1]/input"));
            courseslect.SendKeys("سوال");
            courseslect.SendKeys(Keys.Enter);
            IWebElement descriptionTextBox = driver.FindElement(By.XPath(".//*[@id='Description']"));
            IWebElement submitButton = driver.FindElement(By.XPath(".//*[@id='btn-submit-step-1']"));
            descriptionTextBox.SendKeys("test #" + 0);
            submitButton.Click();
            Thread.Sleep(500);
            driver.Close();
            string[] TstResultArr = { "TR1", "TR2", "TR2" };
            return TstResultArr;
        }
    }
}