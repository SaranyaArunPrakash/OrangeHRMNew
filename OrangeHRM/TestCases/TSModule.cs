using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace OrangeHRM
{
    [TestClass]
    public class TSModule : BaseClass
    {
        [SetUp]
        public void SetUp()
        {

            //Open url
            Setup(Browser.CHROME, "https://" +
                "opensource-demo.orangehrmlive.com/index.php/auth/login");


            //Login
            LoginPageObjects loginPageObjects = new LoginPageObjects();

            loginPageObjects.Login("Akshara", "Welcome@12");

        }
        [Test]
        public void EditTimeSheet()
        {
            MyTimeSheets MyTimeSheets = new MyTimeSheets();
            MyTimeSheets.EditTimeSheet();
        }
    }
}
