using KeysProject.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeysProject
{
    public class OwnerTests
    {
        [TestFixture]
        [Category("Your Properties")]
        class Keys : Global.Base
        {
            //TestCase1
            [Test]
            public void SearchProperty()
            {
                //Start the reports
                test = extent.StartTest("Admin page navigation");

                //Create a Class and Method
                YourProperties obj = new YourProperties();
                obj.SearchAProperty();

            }

            [Test, Description(" Test to check the job is displayed correctly in the marketplace")]
            public void AvailablejobsinMarketplace()
            {
                //Start the reports
                test = extent.StartTest("Available jobs in Market place");

                //Create a Class and method
                OwnerAdvertisedJobsQuotes jobsobj = new OwnerAdvertisedJobsQuotes();
                jobsobj.Addnewjob();
                jobsobj.LoginServiceSupplier();


                MarketPlace marketobj = new MarketPlace();
                marketobj.Marketplacelist();
                marketobj.JobVerification();


            }
            

            [Test, Description("Test to check the search functionality in Rental listings & Tenant Applications")]
            public void SearchRentalProperty()
            {
                //Start the reports
                test = extent.StartTest("Search in Rental listings and Tenant Applicaions");

                //Create a Class and Method
                OwnerRentalListingsAndTenantApplications rentalobj = new OwnerRentalListingsAndTenantApplications();
                rentalobj.ClickRentalListingsandTenantApplications();
                rentalobj.SearchRentalProperties();

            }

            [Test, Description("Test to check the Edit in Rental listings & Tenant Applications")]
            public void EditRentallistings()
            {
                //Start the reports
                test = extent.StartTest("Admin page navigation");

                //Create Class and methods
                OwnerRentalListingsAndTenantApplications editobj = new OwnerRentalListingsAndTenantApplications();

                editobj.ClickRentalListingsandTenantApplications();
                editobj.EditRentalProperties();
            }
            //Added by Preety
            [Test, Description("Test to check the Manage Tenant Details by an owner")]
            public void ManageTenantDetails()
            {
                //Boolean to check if previous step is successfull and can be moved to next step
                bool movetonextstep = false;

                //Start the reports
                test = extent.StartTest("Manage Tenant details");

                //Create Class and methods
                YourProperties editobj = new YourProperties();

                //Method to click Manage Tenant menu option
                movetonextstep = editobj.ClickManageTenant();

                if(movetonextstep)
                {
                    movetonextstep = false;
                    //Method to click Edit Tenant if Tenant exists
                    movetonextstep = editobj.VerifyTenant();
                }

                if (movetonextstep)
                {
                    movetonextstep = false;
                    //Method to edit tenant details
                    movetonextstep = editobj.EditTenantDetails();
                }

                if(movetonextstep)
                {
                    editobj.VerifyUpdatedTenant();
                }
            }
            //Added by Preety

        }
    }
}
