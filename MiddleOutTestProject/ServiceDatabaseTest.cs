using System;
using MiddleOut;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiddleOutTestProject
{
    [TestClass]
    public class ServiceDatabaseTest
    {
        [TestMethod]
        public void createServicesTest()
        {
            ServiceDatabase sBase = new ServiceDatabase();
            UserDatabase uBase = new UserDatabase();;
            User testUser = new User("Tester", "Password", "test@uw.edu", "123 Test St.", null, "Tacoma", "WA", "98422");
            uBase.addUser(testUser);
            uBase.deleteUser(testUser.getEmail());
            Service test = new Service("Tester", "test@uw.edu");


            sBase.createService(ServiceTypes.Donor, DonationTypes.Toys, testUser, test);
            sBase.createService(ServiceTypes.Donor, DonationTypes.Clothes, testUser, test);
            sBase.createService(ServiceTypes.Donor, DonationTypes.Tech, testUser, test);
            sBase.createService(ServiceTypes.Donor, DonationTypes.FirstAid, testUser, test);
            sBase.createService(ServiceTypes.Donor, DonationTypes.Food, testUser, test);
            sBase.createService(ServiceTypes.Donor, DonationTypes.Hygene, testUser, test);
            sBase.createService(ServiceTypes.Donor, DonationTypes.Other, testUser, test);

            sBase.createService(ServiceTypes.Driver, DonationTypes.TransportGoods, testUser, test);

            sBase.createService(ServiceTypes.Educator, DonationTypes.MathEducator, testUser, test);
            sBase.createService(ServiceTypes.Educator, DonationTypes.ReadingEducator, testUser, test);
            sBase.createService(ServiceTypes.Educator, DonationTypes.WritingEducator, testUser, test);

            sBase.createService(ServiceTypes.Requester, DonationTypes.Tools, testUser, test);

            Console.WriteLine(sBase.printServices(ServiceTypes.Requester));
        }

        [TestMethod]
        public void TestMethod1()
        {
            //Console.WriteLine(sBase.printServices(ServiceTypes.Donor));
        }
    }
}
