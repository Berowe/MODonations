using System.Collections.Generic;
using MiddleOut;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiddleOutTestProject
{
    /// <summary>
    /// Author: Ameet Toor
    /// This class tests the Reports class.
    /// </summary>
    [TestClass]
    public class ReportsTest
    {
        /// <summary>
        /// Author: Ameet Toor
        /// Tests the Reports constructor.
        /// </summary>
        [TestMethod]
        public void TestReportsConstructor()
        {
            //create a list of services
            Service service = new Service("Ameet", "Ameet@email.com");
            service.setDescription("Ameet's Service");
            service.setServiceType(ServiceTypes.Educate);
            service.setDonationRequest(DonationTypes.Math);
            service.setDescription("Algebra");
            
            List<Service> list = new List<Service> {service};

            string correctResult =
                "Report: \n\nService 1:\nThis Service is to Educate Math\nUser Submitted Description: Algebra\nService is Selected: No\nService is Completed: No\n______________________________________________________\n\n\nNumber of Services: 1\nTotal Tax Credit: $0";

            //create a report
            Reports reports = new Reports(list);

            //check to see that report.toString() is the same as it should be.
            Assert.AreEqual(correctResult, reports.ToString(), true);

            Assert.AreNotEqual(" ", reports.ToString(), true);
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Tests the GetReport method.
        /// </summary>
        [TestMethod]
        public void TestGetReport()
        {
            Service service = new Service("Toor", "Toor@email.com");
            service.setDescription("Service");
            service.setServiceType(ServiceTypes.Educate);
            service.setDonationRequest(DonationTypes.Math);
            service.setDescription("Algebra");

            List<Service> list = new List<Service> { service };

            string correctResult =
                "Report: \n\nService 1:\nThis Service is to Educate Math\nUser Submitted Description: Algebra\nService is Selected: No\nService is Completed: No\n______________________________________________________\n\n\nNumber of Services: 1\nTotal Tax Credit: $0";

            Reports reports = new Reports(list);

            Assert.AreEqual(correctResult, reports.GetReport(), true);

            Assert.AreNotEqual("Service", reports.GetReport(), true);
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Tests the toString method.
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            Service service = new Service("A", "A@email.com");
            service.setDescription("A");
            service.setServiceType(ServiceTypes.Educate);
            service.setDonationRequest(DonationTypes.Math);
            service.setDescription("Algebra");

            List<Service> list = new List<Service> { service };

            string correctResult =
                "Report: \n\nService 1:\nThis Service is to Educate Math\nUser Submitted Description: Algebra\nService is Selected: No\nService is Completed: No\n______________________________________________________\n\n\nNumber of Services: 1\nTotal Tax Credit: $0";

            Reports reports = new Reports(list);

            Assert.AreEqual(correctResult, reports.GetReport(), true);

            Assert.AreNotEqual("A Service by A", reports.GetReport(), true);
        }
    }
}
