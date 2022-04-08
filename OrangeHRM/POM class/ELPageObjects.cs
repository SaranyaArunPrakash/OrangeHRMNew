using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace OrangeHRM
{
    public class ELPageObjects : BaseClass
    {
       	        
		
        IWebElement PIMMenu = Element(Locators.ID, "menu_pim_viewPimModule");  
	    
        public void EmpInfo(string empname)
        {
            
            Clicks(PIMMenu);
                        
            IWebElement EmpName = Element(Locators.ID, "empsearch_employee_name_empName");
            EnterText(EmpName,empname);
            IList<IWebElement> OptionsList = Elements(Locators.XPATH, "/html/body/div[4]/ul/li");
            foreach (IWebElement options in OptionsList)
            {
                if (options.Text == "Sara Tencrady")

                    Clicks(options);
                else
                    Console.WriteLine("Employee doesn't exist");

            }
            IWebElement Searchbtn = Element(Locators.ID, "searchBtn");
            Clicks(Searchbtn);
        }

        
    }
}
