using OpenDialogWindowHandler;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM
{
    class AddEmpPageObj : BaseClass
    {
        IWebElement PIMMenu = Element(Locators.ID, "menu_pim_viewPimModule");
        

        public void AddEmployee(string FirstName, string MiddleName, string LastName)
        {
            Clicks(PIMMenu);
            IWebElement AddEmpMenu = Element(Locators.ID, "menu_pim_addEmployee");
            Clicks(AddEmpMenu);
            IWebElement EFirstName = Element(Locators.ID, "firstName");
            IWebElement EMiddleName = Element(Locators.ID, "middleName");
            IWebElement ELastName = Element(Locators.ID, "lastName");
            IWebElement ChooseFile = Element(Locators.ID, "photofile");
            IWebElement Save = Element(Locators.XPATH, "//*[@id='btnSave']");
            EnterText(EFirstName, FirstName);
            EnterText(EMiddleName, MiddleName);
            EnterText(ELastName, LastName);                                
            ChooseFile.SendKeys("C:\\Users\\saran\\Downloads\\Hakuna.jpg");
            Clicks(Save);


        }





    }
}
