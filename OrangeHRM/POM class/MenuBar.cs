using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrangeHRM
{
    public class MenuBar : BaseClass
    {
        
            IWebElement PIM = Element(Locators.XPATH, "//*[@id='menu_pim_viewPimModule']/b");

        
    }
}
