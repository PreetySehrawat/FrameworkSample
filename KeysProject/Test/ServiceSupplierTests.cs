using KeysProject.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeysProject.Test
{  
    [TestFixture]
    public class ServiceSupplierTests:Global.ServiceSupplierBase
    {
        [Test, Description("Test to check the apply button is disabled after submitting the quote")]
        public void Applyforjob()
        {
            //start the reports
            test = extent.StartTest("Job Quote form");

            //Create Class and methods
            MarketPlace marketobj = new MarketPlace();
            marketobj.Marketplacelist();
            marketobj.ApplyforJob();
            

        }
    }
}
