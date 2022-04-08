using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;


namespace OrangeHRM
{
    public class LoginPageObjects : BaseClass
    {
        IWebElement Username = Element(Locators.ID, "txtUsername");
        IWebElement Password = Element(Locators.ID, "txtPassword");
        IWebElement SubmitButton = Element(Locators.NAME, "Submit");
               
        public void Login(string username, string password)
        {
            EnterText(Username, username);
            EnterText(Password, password);
                       
            SubmitButton.Click();     
                
            
           
            
            

        }
    }
}
