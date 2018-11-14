using KeysProject.Config;
using KeysProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KeysProject.Global.CommonMethods;

namespace KeysProject.Global
{
    class Base
    {

        #region To access Path from resource file

        public static int Browser = Int32.Parse(KeysResource.Browser);
        public static string ExcelPath = KeysResource.ExcelPath;
        public static string ScreenshotPath = KeysResource.ScreenShotPath;
        public static string ReportPath = KeysResource.ReportPath;
                
        #endregion

        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;
        #endregion

        #region setup and tear down
        [SetUp]
        public void Inititalize()
        {

            // advisasble to read this documentation before proceeding http://extentreports.relevantcodes.com/net/
            switch (Browser)
            {
                case 1:
                    GlobalDefinitions.driver = new FirefoxDriver();
                    break;

                case 2:
                    var options = new ChromeOptions();
                    options.AddArguments("--disable-extensions --disable-extensions-file-access-check --disable-extensions-http-throttling --disable-infobars --enable-automation --start-maximized");
                    options.AddUserProfilePreference("credentials_enable_service", false);
                    options.AddUserProfilePreference("profile.password_manager_enabled", false);
                    GlobalDefinitions.driver = new ChromeDriver(options);                                        
                    break;

            }

            extent = new ExtentReports(ReportPath, false, DisplayOrder.OldestFirst);
            extent.LoadConfig(KeysResource.ReportXMLPath);


            if (KeysResource.IsLogin == "true")
            {
                LoginPage loginobj = new LoginPage();
                loginobj.LoginSteps();
            }
            else
            {
                Register obj = new Register();
                obj.RegisterwithValidData();
            }
            
        }


        [TearDown]
        public void TearDown()
        {
            // Screenshot
            String img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Report");
            test.Log(LogStatus.Info, "Image example: " + img);
            // end test. (Reports)
            extent.EndTest(test);
            // calling Flush writes everything to the log file (Reports)
            extent.Flush();
            // Close the driver            
            GlobalDefinitions.driver.Close();
        }
        #endregion


    }
}
