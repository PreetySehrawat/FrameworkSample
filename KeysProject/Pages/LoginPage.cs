using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeysProject.Pages
{
    class LoginPage
    {
        public void LoginSteps()
        {

            //Populate the Excel Sheet
            Global.CommonMethods.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "Login");

            //Navigate to the URL
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(Global.CommonMethods.ExcelLib.ReadData(2,"InputValue"));

            //Delete cookies
           // Global.GlobalDefinitions.driver.Manage().Cookies.DeleteAllCookies();

            //Enter Username
            Global.GlobalDefinitions.TextBox(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(3, "Locator"), Global.CommonMethods.ExcelLib.ReadData(3, "LocatorValue"), Global.CommonMethods.ExcelLib.ReadData(3, "InputValue"));

            //Enter Password
            Global.GlobalDefinitions.TextBox(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(4, "Locator"), Global.CommonMethods.ExcelLib.ReadData(4, "LocatorValue"), Global.CommonMethods.ExcelLib.ReadData(4, "InputValue"));

            //Click on Login Button
            Global.GlobalDefinitions.ActionButton(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(5, "Locator"), Global.CommonMethods.ExcelLib.ReadData(5, "LocatorValue"));


        }
        public void  TenantLogin()
        {
            //Populate the Excel Sheet
            Global.CommonMethods.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "Login");

            //Navigate to the URL
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(Global.CommonMethods.ExcelLib.ReadData(2, "InputValue"));

            //Delete cookies
            // Global.GlobalDefinitions.driver.Manage().Cookies.DeleteAllCookies();

            //Enter Username
            Global.GlobalDefinitions.TextBox(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(9, "Locator"), Global.CommonMethods.ExcelLib.ReadData(9, "LocatorValue"), Global.CommonMethods.ExcelLib.ReadData(9, "InputValue"));

            //Enter Password
            Global.GlobalDefinitions.TextBox(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(10, "Locator"), Global.CommonMethods.ExcelLib.ReadData(10, "LocatorValue"), Global.CommonMethods.ExcelLib.ReadData(10, "InputValue"));

            //Click on Login Button
            Global.GlobalDefinitions.ActionButton(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(5, "Locator"), Global.CommonMethods.ExcelLib.ReadData(5, "LocatorValue"));
        }

        public void ServiceSupplierLogin()
        {
            //Populate the Excel Sheet
            Global.CommonMethods.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "Login");

            //Navigate to the URL
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(Global.CommonMethods.ExcelLib.ReadData(2, "InputValue"));

            //Delete cookies
            // Global.GlobalDefinitions.driver.Manage().Cookies.DeleteAllCookies();

            //Enter Username
            Global.GlobalDefinitions.TextBox(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(6, "Locator"), Global.CommonMethods.ExcelLib.ReadData(6, "LocatorValue"), Global.CommonMethods.ExcelLib.ReadData(6, "InputValue"));

            //Enter Password
            Global.GlobalDefinitions.TextBox(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(7, "Locator"), Global.CommonMethods.ExcelLib.ReadData(7, "LocatorValue"), Global.CommonMethods.ExcelLib.ReadData(7, "InputValue"));
            
            //Click on Login Button
            Global.GlobalDefinitions.ActionButton(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(5, "Locator"), Global.CommonMethods.ExcelLib.ReadData(5, "LocatorValue"));
        }
    }
}
