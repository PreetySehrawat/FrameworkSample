using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KeysProject.Global.CommonMethods;

namespace KeysProject.Pages
{
    class Register
    {
        internal void RegisterwithValidData()
        {
            //Populate the Excel file
            Global.CommonMethods.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "Registration");
      
            //Navigate to the Registration URL
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(ExcelLib.ReadData(2,"InputValue"));

            //Enter FirstName
            Global.GlobalDefinitions.TextBox(Global.GlobalDefinitions.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(2, "LocatorValue"), ExcelLib.ReadData(2,"FirstName"));

            //Enter LastName           
            Global.GlobalDefinitions.TextBox(Global.GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"), ExcelLib.ReadData(2, "LastName"));

            //Enter Email          
            Global.GlobalDefinitions.TextBox(Global.GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"), ExcelLib.ReadData(2, "Email"));

            //Enter Password
            Global.GlobalDefinitions.TextBox(Global.GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"), ExcelLib.ReadData(2, "Password"));

            //Choose the User
            Global.GlobalDefinitions.ActionButton(Global.GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));
            Global.GlobalDefinitions.ActionButton(Global.GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));

            //Tick the check box
            Global.GlobalDefinitions.ActionButton(Global.GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));

            //Click on Sign Up Button
            Global.GlobalDefinitions.ActionButton(Global.GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));

            
        }
    }
}
