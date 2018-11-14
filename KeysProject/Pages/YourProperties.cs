using KeysProject.Global;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;
using static KeysProject.Global.CommonMethods;

namespace KeysProject
{
    internal class YourProperties
    {
        internal void SearchAProperty()
        {
            //Populate the excel sheet
            ExcelLib.PopulateInCollection(Base.ExcelPath, "YourProperties");

            //Click on the Owners tab
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));

            //Click on the Properties Page
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "LocatorValue"));

            //Enter the property on the Search box
            GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "LocatorValue"),ExcelLib.ReadData(4,"InputValue"));

            //Click on Search
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "LocatorValue"));

            //Verification
            try
            {
                string ExpectedResult = ExcelLib.ReadData(4, "InputValue");
                string ActualResult = GlobalDefinitions.GetTextValue(GlobalDefinitions.driver, ExcelLib.ReadData(6,"Locator"), ExcelLib.ReadData(6,"LocatorValue"));
                if (ExpectedResult == ActualResult)
                {
                    Base.test.Log(LogStatus.Pass, "Test Passed, Property searched successfully");
                    SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "PropertySearchedsuccessfully");

                }
                else
                    Base.test.Log(LogStatus.Fail, "Test Failed, Search Unsuccessful");


            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Test Failed, Search Unsuccessful", e.Message);
            }



        }


        //Added by Preety
        internal bool ClickManageTenant()
        {
            try
            { 
            //Populate the excel sheet
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageTenant");

            //Click on the Owners tab
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));

            //Click on the Properties Page
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "LocatorValue"));

            //Enter the property on the Search box
            GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "LocatorValue"), ExcelLib.ReadData(4, "InputValue"));

            //Click on Search
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "LocatorValue"));

            //Click on menu for searched property
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "LocatorValue"));

            //Introduce wait
            Thread.Sleep(1000);
            //Click on Manage Tenant menu option
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "LocatorValue"));

            return true;
            }   
            catch(Exception)
            {
                Base.test.Log(LogStatus.Pass, "Test Failed, Manage Tenant is not clicked");
                return false;
            }
            
        }

        internal bool VerifyTenant()
        {

            try
            {
                string ExpectedResult = ExcelLib.ReadData(8, "InputValue");
                bool TenantAvailable = GlobalDefinitions.FindElementsUsingForLoop(GlobalDefinitions.driver, ExcelLib.ReadData(8, "Locator"),
                    ExcelLib.ReadData(8, "LocatorValue"), "", ExcelLib.ReadData(8, "InputValue"), "No");

                if (TenantAvailable == true)
                {
                    Base.test.Log(LogStatus.Pass, "Test Passed, Tenant to be edited is present");
                    GlobalDefinitions.FindElementsUsingForLoop(GlobalDefinitions.driver, ExcelLib.ReadData(10, "Locator"),
                    ExcelLib.ReadData(10, "LocatorValue"), "", ExcelLib.ReadData(10, "InputValue"), "Yes");
                }

                if (TenantAvailable == false)
                {
                    //Check if multiple pages are available
                    bool multiplepages = GlobalDefinitions.ElementVisible(GlobalDefinitions.driver, ExcelLib.ReadData(9, "Locator"),
                                        ExcelLib.ReadData(9, "LocatorValue"));
                    do
                    {
                        if (multiplepages == true)
                        {
                            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "LocatorValue"));

                            TenantAvailable = GlobalDefinitions.FindElementsUsingForLoop(GlobalDefinitions.driver, ExcelLib.ReadData(8, "Locator"),
                                              ExcelLib.ReadData(8, "LocatorValue"), "", ExcelLib.ReadData(8, "InputValue"), "No");
                            if (TenantAvailable == true)
                            {
                                Base.test.Log(LogStatus.Pass, "Test Passed, Tenant to be edited is present");
                                GlobalDefinitions.FindElementsUsingForLoop(GlobalDefinitions.driver, ExcelLib.ReadData(10, "Locator"),
                                ExcelLib.ReadData(10, "LocatorValue"), "", ExcelLib.ReadData(10, "InputValue"), "Yes");
                                multiplepages = false;
                                break;
                            }
                            multiplepages = GlobalDefinitions.ElementVisible(GlobalDefinitions.driver, ExcelLib.ReadData(9, "Locator"),
                                        ExcelLib.ReadData(9, "LocatorValue"));
                        }
                    } while (multiplepages == true);

                    if (TenantAvailable == false)
                    {
                        Base.test.Log(LogStatus.Pass, "Test Failed, Tenant is not present for the selected property");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Test Failed, Verify Tenant Unsuccessful", e.Message);
                return false;
            }

        }


        internal bool EditTenantDetails()
        {
            try
            {
                //Enter IsMainTenant 
                GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "LocatorValue"));

                //Enter Rent Start Date
                GlobalDefinitions.SendDateWithOutCalendar(GlobalDefinitions.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "LocatorValue"), ExcelLib.ReadData(12, "InputValue"));

                //Enter Rent End Date
                GlobalDefinitions.SendDateWithOutCalendar(GlobalDefinitions.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "LocatorValue"), ExcelLib.ReadData(13, "InputValue"));

                //Enter Rent Amount
                GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "LocatorValue"), ExcelLib.ReadData(14, "InputValue"));

                //Enter Payment Frequency 
                GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "LocatorValue"));

                //Enter Payment Start Date
                GlobalDefinitions.SendDateWithOutCalendar(GlobalDefinitions.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "LocatorValue"), ExcelLib.ReadData(16, "InputValue"));

                //Enter Payment Due Date
                GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "LocatorValue"), ExcelLib.ReadData(17, "InputValue"));

                //Click on Next button on Tenant Details page
                GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "LocatorValue"));

                #region Edit Liability 
                //variable to check if Liability icon is clicked
                bool ClickedLiabilityIcon = false;

                //Check if Liability is already present
                bool LiaibilityExists = GlobalDefinitions.ElementVisible(GlobalDefinitions.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "LocatorValue"));

                if (LiaibilityExists)
                {
                    //Find the Edit Liability icon, match with given liability name and click
                    ClickedLiabilityIcon = GlobalDefinitions.FindElementsUsingForLoop(GlobalDefinitions.driver, ExcelLib.ReadData(19, "Locator"),
                                        ExcelLib.ReadData(19, "LocatorValue"), ExcelLib.ReadData(20, "LocatorValue"), ExcelLib.ReadData(20, "InputValue"), "Yes");

                    if (ClickedLiabilityIcon)
                    {
                        //Clear the Liaibility Amount
                        GlobalDefinitions.GetClear(GlobalDefinitions.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "LocatorValue"));

                        //Update the Liability Amount
                        GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "LocatorValue"), ExcelLib.ReadData(21, "InputValue"));

                        //Click on Save updated liability amount
                        GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "LocatorValue"));

                        Base.test.Log(LogStatus.Pass, "Liability Amount edited successful");
                    }
                    else
                        Base.test.Log(LogStatus.Pass, "Given Liaibility for editing does not exists");

                }

                #endregion

                #region Delete Liability

                ClickedLiabilityIcon = false;

                //if liability exists then edit
                if (LiaibilityExists)
                {
                    //Find the Edit Liability icon, match with given liability name and click
                    ClickedLiabilityIcon = GlobalDefinitions.FindElementsUsingForLoop(GlobalDefinitions.driver, ExcelLib.ReadData(19, "Locator"),
                                        ExcelLib.ReadData(19, "LocatorValue"), ExcelLib.ReadData(20, "LocatorValue"), ExcelLib.ReadData(23, "InputValue"), "Yes");

                    if (ClickedLiabilityIcon)
                    {
                        //Click on Delete button for selected liability
                        GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(23, "Locator"), ExcelLib.ReadData(23, "LocatorValue"));

                        Base.test.Log(LogStatus.Pass, "Liability Deleted successfully");
                    }
                    else
                        Base.test.Log(LogStatus.Pass, "Given Liaibility for deleting does not exists");
                }
                #endregion

                #region Add Liability
                //Click on Add Liability
                GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "LocatorValue"));

                //Select Liability
                GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(25, "Locator"), ExcelLib.ReadData(25, "LocatorValue"), ExcelLib.ReadData(25, "InputValue"));

                //Enter Liability Amount
                GlobalDefinitions.TextBox(GlobalDefinitions.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "LocatorValue"), ExcelLib.ReadData(26, "InputValue"));

                //Click on Save Button to add liaibility
                GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(27, "Locator"), ExcelLib.ReadData(27, "LocatorValue"));

                //Click on Next button
                GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(28, "Locator"), ExcelLib.ReadData(28, "LocatorValue"));
                #endregion

                //Click on Submit Button
                GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(29, "Locator"), ExcelLib.ReadData(29, "LocatorValue"));
                return true;
            }
            catch(Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Test Failed, Add liability is not successful", e.Message);
                return false;
            }
        }


        internal void VerifyUpdatedTenant()
        {

            try
            {
                bool movetonextstep;

                //Method to click Manage Tenant menu option
                movetonextstep = ClickManageTenant();

                if (movetonextstep)
                {
                    movetonextstep = false;
                    //Method to click Edit Tenant if Tenant exists
                    movetonextstep = VerifyTenant();
                }

                if(movetonextstep)
                {
                    Base.test.Log(LogStatus.Pass, "Manage Tenant Test Case is successful");
                }
                else
                    Base.test.Log(LogStatus.Fail, "Manage Tenant Test Case is not successful");

            }
            catch(Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Manage Tenant Test Case is not successful", e.Message);
            }
        }
        //Added by Preety
    }
}