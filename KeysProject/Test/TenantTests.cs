using KeysProject.Pages;
using NUnit.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeysProject.Test
{
   [TestFixture]
   public  class TenantTests:Global.TenantBase
    {

        [Test]
        public void SearchMyRequest()
        {
            //Start the reports
            test = extent.StartTest("Search for Requests");

            //Create a Class and Method
            TenantMyRequests requestsobj = new TenantMyRequests();
            requestsobj.SearchMyRequest();

        }
    }
}
