using KeysProject.Global;
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
    class OwnerRentalListingsAndTenantApplications
    {
        public void ClickRentalListingsandTenantApplications()
        {
            try
            {
                //Populate the excel sheet
                ExcelLib.PopulateInCollection(Base.ExcelPath, "RentalForm");

                //Click on the Owners tab
                GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));

                //Click on the Rental Listings and application page
                GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "LocatorValue"));
            }
            
            catch(Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Test Failed, Not able to click Rental Listings and Tenant Applications", e.Message);
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, " Clicking Rental Listings and Tenant Applications failed , thrown exception");
            }
            
      }

        public void SearchRentalProperties()
        {
           

            //Enter the property on the Search box
            GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "LocatorValue"), ExcelLib.ReadData(5, "InputValue"));

            //Click on Search
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "LocatorValue"));

            //Verification
            try
            {
                string ExpectedResult = ExcelLib.ReadData(5, "InputValue");
                string ActualResult = GlobalDefinitions.GetTextValue(GlobalDefinitions.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "LocatorValue"));
                if (ExpectedResult == ActualResult)
                {
                    Base.test.Log(LogStatus.Pass, "Test Passed,  Property found successfully");
                    SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Rental Propery Search");

                }
                else
                    Base.test.Log(LogStatus.Fail, "Test Failed, Rental property Search Unsuccessful");
                    SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Rental Propery Search unsuccessful");

            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Test Failed, Rental property Search Unsuccessful", e.Message);
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Rental Propery Search unsuccessful, thrown exception");


            }
        }
        public void EditRentalProperties()
        {
           
            //Click on Edit button
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "LocatorValue"));

            //Enter the new Title
            GlobalDefinitions.GetClear(GlobalDefinitions.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "LocatorValue"));
            GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "LocatorValue"), ExcelLib.ReadData(8, "InputValue"));

            //Enter the new Description
            GlobalDefinitions.GetClear(GlobalDefinitions.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "LocatorValue"));
            GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "LocatorValue"), ExcelLib.ReadData(9, "InputValue"));

            //Enter the new Moving cost
            GlobalDefinitions.GetClear(GlobalDefinitions.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "LocatorValue"));
            GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "LocatorValue"), ExcelLib.ReadData(10, "InputValue"));

            //Enter the new Target Rent
            GlobalDefinitions.GetClear(GlobalDefinitions.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "LocatorValue"));
            GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "LocatorValue"), ExcelLib.ReadData(11, "InputValue"));

            //Enter the new Furninshing
            GlobalDefinitions.GetClear(GlobalDefinitions.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "LocatorValue"));
            GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "LocatorValue"), ExcelLib.ReadData(12, "InputValue"));

            //Enter the new Available Date
            GlobalDefinitions.GetClear(GlobalDefinitions.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "LocatorValue"));
            Thread.Sleep(2000);
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "LocatorValue"));

            //Enter the new Ideal Tenant
            GlobalDefinitions.GetClear(GlobalDefinitions.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "LocatorValue"));
            GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "LocatorValue"), ExcelLib.ReadData(14, "InputValue"));

            //Enter the new number of Occupants
            GlobalDefinitions.GetClear(GlobalDefinitions.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "LocatorValue"));
            GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "LocatorValue"), ExcelLib.ReadData(15, "InputValue"));

            //Enter the new Pets Allowed
            // GlobalDefinitions.GetClear(GlobalDefinitions.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "LocatorValue"));
            GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "LocatorValue"), ExcelLib.ReadData(16, "InputValue"));

            //Click on Save Button
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "LocatorValue"));

            //Verification

            //Click on Details Button
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "LocatorValue"));

            try
            {
                //Verification of Title
                string ExpectedResult_Title = ExcelLib.ReadData(8, "InputValue");
                string ActualResult_Title = GlobalDefinitions.GetTextValue(GlobalDefinitions.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "LocatorValue"));

                //Verification of Occupants count
                string ExpectedResult_occupants = ExcelLib.ReadData(15, "InputValue");
                string ActualResult_occupants = GlobalDefinitions.GetTextValue(GlobalDefinitions.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "LocatorValue"));

                //Verification of Moving Cost
                string ExpectedResult_MovingCost = ExcelLib.ReadData(10, "InputValue");
                string ActualResult_MovingCost = GlobalDefinitions.GetTextValue(GlobalDefinitions.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "LocatorValue"));

                //Verification of Ideal Tenant
                string ExpectedResult_IdealTenant = ExcelLib.ReadData(14, "InputValue");
                string ActualResult_IdealTenant = GlobalDefinitions.GetTextValue(GlobalDefinitions.driver, ExcelLib.ReadData(23, "Locator"), ExcelLib.ReadData(23, "LocatorValue"));

                //Verification of Pets Allowed
                string ExpectedResult_PetsAllowed = ExcelLib.ReadData(16, "InputValue");
                string ActualResult_PetsAllowed = GlobalDefinitions.GetTextValue(GlobalDefinitions.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "LocatorValue"));

                //Verification of Target Rent
                string ExpectedResult_Rent = ExcelLib.ReadData(11, "InputValue");
                string ActualResult_Rent = GlobalDefinitions.GetTextValue(GlobalDefinitions.driver, ExcelLib.ReadData(25, "Locator"), ExcelLib.ReadData(25, "LocatorValue"));

                //Verification of Available Date
                string ExpectedResult_AvailableDate = ExcelLib.ReadData(18, "InputValue");
                string ActualResult_AvailableDate = GlobalDefinitions.GetTextValue(GlobalDefinitions.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "LocatorValue"));

                //Verification of Title
                if (ExpectedResult_Title == ActualResult_Title)
                {
                    Base.test.Log(LogStatus.Pass, "Test Passed, Property Edited successfully");
                    SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Property Edited successfully");

                }

                //Verification of Occupants count
                else if (ExpectedResult_occupants == ActualResult_occupants)
                {
                    Base.test.Log(LogStatus.Pass, "Test Passed, Property Edited successfully");
                    SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Propert Edited successfully");
                }

                //Verification of Moving Cost
                else if (ExpectedResult_MovingCost == ActualResult_MovingCost)
                {
                    Base.test.Log(LogStatus.Pass, "Test Passed, Property Edited successfully");
                    SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Propert Edited successfully");
                }

                //Verification of Ideal Tenant
                else if (ExpectedResult_IdealTenant == ActualResult_IdealTenant)
                {
                    Base.test.Log(LogStatus.Pass, "Test Passed, Property Edited successfully");
                    SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Propert Edited successfully");
                }

                //Verification of Pets Allowed
                else if (ExpectedResult_PetsAllowed == ActualResult_PetsAllowed)
                {
                    Base.test.Log(LogStatus.Pass, "Test Passed, Property Edited successfully");
                    SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Propert Edited successfully");
                }

                //Verification of Target Rent
                else if (ExpectedResult_Rent == ActualResult_Rent)
                {
                    Base.test.Log(LogStatus.Pass, "Test Passed, Property Edited successfully");
                    SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Propert Edited successfully");
                }

                //Verification of Available Date
                else if (ExpectedResult_AvailableDate == ActualResult_AvailableDate)
                {
                    Base.test.Log(LogStatus.Pass, "Test Passed, Property Edited successfully");
                    SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Propert Edited successfully");
                }

                else
                    Base.test.Log(LogStatus.Fail, "Test Failed, Search Unsuccessful");


            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Test Failed, Search Unsuccessful", e.Message);
            }



        }
    }
}
