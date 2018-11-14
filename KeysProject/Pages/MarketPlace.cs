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
using static NUnit.Core.NUnitFramework;

namespace KeysProject.Pages
{
    class MarketPlace
    {
        internal void Marketplacelist()
        {

                 //Populate the excel sheet
                ExcelLib.PopulateInCollection(Base.ExcelPath, "Advertisedjobs");

                //Thread.Sleep(2000);
                //Click on the market place
                GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "LocatorValue"));

                Thread.Sleep(2000);
                //Search job using searchbox
                GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "LocatorValue"), ExcelLib.ReadData(14, "InputValue"));

                //Search submit
                GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "LocatorValue"));

                        

        }
       internal void JobVerification()
        { 
            //Verification
            try
            {
                string ExpectedResult = ExcelLib.ReadData(14, "InputValue");
                string ActualResult = GlobalDefinitions.GetTextValue(GlobalDefinitions.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "LocatorValue"));

                if (ExpectedResult == ActualResult)
                {
                    Base.test.Log(LogStatus.Pass, "Test Passed,Job Found Successsfully");
                    SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Job searched successfully");

                }
                else
                    Base.test.Log(LogStatus.Fail, "Test Failed, Job search Unsuccessful");


            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Test Failed, Job Search Unsuccessful", e.Message);
            }
          
        }

        internal void ApplyforJob()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Advertisedjobs");

            bool ApplyEnabled = GlobalDefinitions.ElementVisible(GlobalDefinitions.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "LocatorValue"));

            if (ApplyEnabled == true)
            {
                //Click Apply
                GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "LocatorValue"));

                Thread.Sleep(2000);

                //Populate the excel sheet
                ExcelLib.PopulateInCollection(Base.ExcelPath, "JobQuoteForm");

                //Enter Amount
                GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"), ExcelLib.ReadData(2, "InputValue"));

                //Enter Note
                GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "LocatorValue"), ExcelLib.ReadData(3, "InputValue"));

                //Submit the job quote form
                GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "LocatorValue"));


                //verification
                //Populate the excel sheet
                ExcelLib.PopulateInCollection(Base.ExcelPath, "Advertisedjobs");

                //Thread.Sleep(3000);
                IWebElement SearchBox = GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath(ExcelLib.ReadData(14, "LocatorValue")), 5);

                //Clear search box
                SearchBox.Clear();

                //GlobalDefinitions.GetClear(GlobalDefinitions.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "LocatorValue"));

                //Search job using searchbox
                GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "LocatorValue"), ExcelLib.ReadData(14, "InputValue"));

                //Search submit
                GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "LocatorValue"));

                Thread.Sleep(2000);

                //Check Apply
                bool ApplyButton = GlobalDefinitions.driver.FindElement(By.XPath(ExcelLib.ReadData(18, "LocatorValue"))).Enabled;

                if (ApplyButton == false)
                {
                    ServiceSupplierBase.test.Log(LogStatus.Pass, "Test Passed,Apply button is disabled after submitting job quote");
                    SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Apply button is disabled ");

                }
                else if(ApplyButton == true)
                {
                    
                    ServiceSupplierBase.test.Log(LogStatus.Fail, "Test Failed,Service supplier able to able to apply twice for a job");
                   SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Apply is in enabled mode after submitting quote");

                }
            }
            else if(ApplyEnabled==false)
            {
               
                ServiceSupplierBase.test.Log(LogStatus.Fail, "Test Failed,Service supplier already submitted the quote for the job");
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Service supplier already submitted the quote for the job");
            }

                        
        }
    }
}
