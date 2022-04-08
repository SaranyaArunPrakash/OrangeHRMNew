using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM
{
    static class Properties
    {
        public static IWebDriver driver;
    }
    public enum Browser
    {
        CHROME, Firefox, Edge
    }
    public enum Locators
    {
        ID,
        NAME,
        XPATH,
        CLASS,
        CSSSELECTOR
    }

}
