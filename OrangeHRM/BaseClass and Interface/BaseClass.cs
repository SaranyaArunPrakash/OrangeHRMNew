using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace OrangeHRM
{
    public class BaseClass : ISeleniumAPI  
    {
        public static void Clicks(IWebElement element)
        {
           element.Click();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public  static IWebElement Element(Locators type, string value)
        {
            
            switch (type)
            {
                case Locators.ID:
                    return Properties.driver.FindElement(By.Id(value));      
                   
                case Locators.NAME:
                    return Properties.driver.FindElement(By.Name(value));
                    
                case Locators.XPATH:
                    return Properties.driver.FindElement(By.XPath(value));
                   
                default: throw new NotImplementedException();
            } 

        }
        public static IList<IWebElement> Elements(Locators type, string value)
        {

            switch (type)
            {
                case Locators.ID:
                    return Properties.driver.FindElements(By.Id(value));

                case Locators.NAME:
                    return Properties.driver.FindElements(By.Name(value));

                case Locators.XPATH:
                    return Properties.driver.FindElements(By.XPath(value));

                default: throw new NotImplementedException();
            }

        }

        public void Quits()
        {
            Properties.driver.Quit();
        }

        public static void EnterText(IWebElement element, string text)
        {
            element.SendKeys(text);
            
        }

                  
        
        public void Setup(Browser browsername, string url)
        {
                        
            switch (browsername)
            {
                case Browser.CHROME:
                    Properties.driver = new ChromeDriver();
                    break;
                default: 
                    throw new NotImplementedException();

            }
            Properties.driver.Manage().Window.Maximize();
            Properties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Properties.driver.Navigate().GoToUrl(url);
            
        }

        void ISeleniumAPI.Quits()
        {
            throw new NotImplementedException();
        }

        IWebElement ISeleniumAPI.Element(Locators type, string value)
        {
            throw new NotImplementedException();
        }

        void ISeleniumAPI.Clicks(IWebElement element)
        {
            throw new NotImplementedException();
        }

        void ISeleniumAPI.EnterText(IWebElement element, string text)
        {
            throw new NotImplementedException();
        }
    }
}
