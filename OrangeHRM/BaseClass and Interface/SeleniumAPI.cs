 using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrangeHRM
{
    
    public interface ISeleniumAPI
    {

        
             
        /**<summary>This will launch chrome browser with the given url</summary> This will launch chrome browser with the given url
         *<param name="url">Provide url to navigate</param>
         *<param name="browsername">Provide browsername</param>
         *<exception cref="NullReferenceException"></exception>
        */

        void Setup(Browser browsername, string url);

        void Close();
        
        void Quits();

        /**
         * <summary>Identying Webelement</summary>
         * <param name="type">Locator type</param>
         * <param name="value">Locator value</param>
         */
        public IWebElement Element(Locators type, string value);
                     
        
       
        void Clicks(IWebElement element);
        void EnterText(IWebElement element, string text);


    }

}
