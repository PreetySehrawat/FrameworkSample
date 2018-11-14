using KeysProject.Global;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static KeysProject.Global.CommonMethods;

namespace KeysProject.Pages
{
   public class TenantMyRequests
    {

        public void SearchMyRequest()
        {
            //Populate the excel sheet
            ExcelLib.PopulateInCollection(Base.ExcelPath, "TenantMyRequests");

            //Click on the Tenants tab
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));
            Thread.Sleep(1000);

            //Click on the My Requests tab
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "LocatorValue"));

            //Enter the requests you want to search on the Search box
            GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "LocatorValue"), ExcelLib.ReadData(4, "InputValue"));

            //Click on Search
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "LocatorValue"));

            //Verification
            try
            {
                //Read the expected result from excel file for searching
                string ExpectedResult = ExcelLib.ReadData(4, "InputValue");

                //Search for the actual result which is the same as the expected result
                IWebElement ltest = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/table/tbody"));
                var listActual = ltest.FindElements(By.TagName("td"));
                foreach (var actualResult in listActual)
                {
                    if (actualResult.Text.Contains(ExpectedResult))
                    {
                        
                        TenantBase.test.Log(LogStatus.Pass, "Test Passed, " + actualResult.Text + " is searched successfully");
                        SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Request found successfully");
                        break;
                    }

                }
            }
            catch (Exception e)
            {               
                TenantBase.test.Log(LogStatus.Fail, "Test Failed, Search Unsuccessful", e.Message);
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Request search unsuccessfull");
            }
        }
    }
}
