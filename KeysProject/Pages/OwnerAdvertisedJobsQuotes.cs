using KeysProject.Global;
using KeysProject.Pages;
using OpenQA.Selenium;
using System.Threading;
using static KeysProject.Global.CommonMethods;

namespace KeysProject
{
    internal class OwnerAdvertisedJobsQuotes
    {

        internal void Addnewjob()
        {
            //Populate the excel sheet
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Advertisedjobs");

            //Click on the Owners tab
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));
            Thread.Sleep(2000);
            //Click on the advertised job and quotes
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "LocatorValue"));

            //Click on Add new job
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "LocatorValue"));

            Thread.Sleep(2000);

            //Select Property
          GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "LocatorValue"));
          Thread.Sleep(1000);
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "LocatorValue"));


            
            //GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "LocatorValue"),ExcelLib.ReadData(5, "InputValue"));

          //  GlobalDefinitions.driver.FindElement(By.XPath(ExcelLib.ReadData(5, "LocatorValue"))).SendKeys(Keys.Enter);

            // Enter Job title
            GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "LocatorValue"), ExcelLib.ReadData(7, "InputValue"));

            //Enter Budget
            GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "LocatorValue"), ExcelLib.ReadData(8, "InputValue"));

            //Enter Description
            GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "LocatorValue"), ExcelLib.ReadData(9, "InputValue"));

            //Click Submit
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "LocatorValue"));

        }

        internal void LoginServiceSupplier()
        {
            Thread.Sleep(2000);

            //Populate the excel sheet
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Advertisedjobs");

            // Profile
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "LocatorValue"));

            Thread.Sleep(2000);
            // Logout 
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "LocatorValue"));

            LoginPage loginobj = new LoginPage();
            loginobj.ServiceSupplierLogin();

            ////Populate the excel sheet
            //ExcelLib.PopulateInCollection(Base.ExcelPath, "Login");

            ////Enter Username
            //Global.GlobalDefinitions.TextBox(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(6, "Locator"), Global.CommonMethods.ExcelLib.ReadData(6, "LocatorValue"), Global.CommonMethods.ExcelLib.ReadData(6, "InputValue"));

            ////Enter Password
            //Global.GlobalDefinitions.TextBox(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(7, "Locator"), Global.CommonMethods.ExcelLib.ReadData(7, "LocatorValue"), Global.CommonMethods.ExcelLib.ReadData(7, "InputValue"));

            ////Click on Login Button
            //Global.GlobalDefinitions.ActionButton(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(5, "Locator"), Global.CommonMethods.ExcelLib.ReadData(5, "LocatorValue"));

            //Click Skip 
           // Global.GlobalDefinitions.ActionButton(Global.GlobalDefinitions.driver, Global.CommonMethods.ExcelLib.ReadData(8, "Locator"), Global.CommonMethods.ExcelLib.ReadData(8, "LocatorValue"));
            

        }
    }
}