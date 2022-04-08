using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM
{
    public class MyTimeSheets :BaseClass
    {
        

        public void EditTimeSheet()
        {
            IWebElement TimeMenu = Element(Locators.ID, "menu_time_viewTimeModule"); ////*[@id="menu_time_viewTimeModule"]/b
            IWebElement TimeSheet = Element(Locators.ID, "menu_time_Timesheets");
            IWebElement EditBtn = Element(Locators.ID, "btnEdit");
            IWebElement FirstDay = Element(Locators.XPATH, "//*[@id='initialRows_0_0'']");
            Clicks(TimeMenu);
            Clicks(TimeSheet);
            Clicks(EditBtn);
            EnterText(FirstDay, "5");
        }
        
    }
}
