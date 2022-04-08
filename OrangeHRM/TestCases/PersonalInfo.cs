using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Threading;


namespace OrangeHRM
{

    [TestClass]
    public class PersonalInfo : BaseClass
    {

        [SetUp]
        public void SetUp()
        {

            //Open url
            Setup(Browser.CHROME, "https://" +
                "opensource-demo.orangehrmlive.com/index.php/auth/login");


            //Login
            LoginPageObjects loginPageObjects = new LoginPageObjects();

            loginPageObjects.Login("Admin", "admin123");

        }
        [Test]
        //Search Employee
        public void EmployeeSearch()
        {
            ELPageObjects elPageObjects = new ELPageObjects();
            elPageObjects.EmpInfo("Sara");

            
        }

        [Test]
        public void AddEmployee()
        {
            AddEmpPageObj AddEmpPageObj = new AddEmpPageObj();
            AddEmpPageObj.AddEmployee("Jane", "A", "Graham");
            
            
        }
      

        
        }

}



        
            

    
    


