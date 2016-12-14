using System;
using MiddleOut;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

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
            Service toy = new Service("Tester", "test@uw.edu");
            Service clothes = new Service("Tester", "test@uw.edu");
            Service faid = new Service("Tester", "test@uw.edu");
            Service hygiene = new Service("Tester", "test@uw.edu");
            Service tech = new Service("Tester", "test@uw.edu");
            Service food = new Service("Tester", "test@uw.edu");
            Service other = new Service("Tester", "test@uw.edu");

            Service drive = new Service("Tester", "test@uw.edu");

            Service math = new Service("Tester", "test@uw.edu");
            Service read = new Service("Tester", "test@uw.edu");
            Service write = new Service("Tester", "test@uw.edu");

            Service request = new Service("Tester", "test@uw.edu");

            sBase.createService(ServiceTypes.Donor, DonationTypes.Toys, testUser, toy);
            sBase.createService(ServiceTypes.Donor, DonationTypes.Clothes, testUser, clothes);
            sBase.createService(ServiceTypes.Donor, DonationTypes.Tech, testUser, tech);
            sBase.createService(ServiceTypes.Donor, DonationTypes.FirstAid, testUser, faid);
            sBase.createService(ServiceTypes.Donor, DonationTypes.Food, testUser, food);
            sBase.createService(ServiceTypes.Donor, DonationTypes.Hygene, testUser, hygiene);
            sBase.createService(ServiceTypes.Donor, DonationTypes.Other, testUser, other);

            sBase.createService(ServiceTypes.Driver, DonationTypes.TransportGoods, testUser, drive);

            sBase.createService(ServiceTypes.Educator, DonationTypes.MathEducator, testUser, math);
            sBase.createService(ServiceTypes.Educator, DonationTypes.ReadingEducator, testUser, read);
            sBase.createService(ServiceTypes.Educator, DonationTypes.WritingEducator, testUser, write);

            sBase.createService(ServiceTypes.Requester, DonationTypes.Tools, testUser, request);

            Assert.AreEqual("1110000\n1210000\n1310000\n1410000\n1610000\n1510000\n1810000\n", sBase.printServices(ServiceTypes.Donor));
            Assert.AreEqual("2110000\n", sBase.printServices(ServiceTypes.Driver));
            Assert.AreEqual("3110000\n3210000\n3310000\n", sBase.printServices(ServiceTypes.Educator));
            Assert.AreEqual("4110000\n", sBase.printServices(ServiceTypes.Requester));

            Assert.AreEqual("1110000\n", sBase.printServices(ServiceTypes.Donor, DonationTypes.Toys));
            Assert.AreEqual("1210000\n", sBase.printServices(ServiceTypes.Donor, DonationTypes.Clothes));
            Assert.AreEqual("1310000\n", sBase.printServices(ServiceTypes.Donor, DonationTypes.Tech));
            Assert.AreEqual("1410000\n", sBase.printServices(ServiceTypes.Donor, DonationTypes.FirstAid));
            Assert.AreEqual("1510000\n", sBase.printServices(ServiceTypes.Donor, DonationTypes.Hygene));
            Assert.AreEqual("1610000\n", sBase.printServices(ServiceTypes.Donor, DonationTypes.Food));
            Assert.AreEqual("1810000\n", sBase.printServices(ServiceTypes.Donor, DonationTypes.Other));

            Assert.AreEqual("2110000\n", sBase.printServices(ServiceTypes.Driver, DonationTypes.TransportGoods));

            Assert.AreEqual("3110000\n", sBase.printServices(ServiceTypes.Educator, DonationTypes.MathEducator));
            Assert.AreEqual("3210000\n", sBase.printServices(ServiceTypes.Educator, DonationTypes.ReadingEducator));
            Assert.AreEqual("3310000\n", sBase.printServices(ServiceTypes.Educator, DonationTypes.WritingEducator));

            Assert.AreEqual("4110000\n", sBase.printServices(ServiceTypes.Requester, DonationTypes.DonationRequest));

            Assert.AreEqual(toy, sBase.retrieveService("1110000"));
            Assert.AreEqual(clothes, sBase.retrieveService("1210000"));
            Assert.AreEqual(tech, sBase.retrieveService("1310000"));
            Assert.AreEqual(faid, sBase.retrieveService("1410000"));
            Assert.AreEqual(hygiene, sBase.retrieveService("1510000"));
            Assert.AreEqual(food, sBase.retrieveService("1610000"));
            Assert.AreEqual(other, sBase.retrieveService("1810000"));

            Assert.AreEqual(drive, sBase.retrieveService("2110000"));

            Assert.AreEqual(math, sBase.retrieveService("3110000"));
            Assert.AreEqual(read, sBase.retrieveService("3210000"));
            Assert.AreEqual(write, sBase.retrieveService("3310000"));

            Assert.AreEqual(request, sBase.retrieveService("4110000"));
        }

        [TestMethod]
        public void Existing_Database_Test()
        {
            ServiceDatabase sBase = new ServiceDatabase();
            string path = @"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\CommonExtensions\Microsoft\TestWindow";
            Console.WriteLine(path);
            File.Delete(Path.Combine(path, "Toy_Dictionary.txt"));
            File.Delete(Path.Combine(path, "Clothes_Dictionary.txt"));
            File.Delete(Path.Combine(path, "Tech_Dictionary.txt"));
            File.Delete(Path.Combine(path, "First_Aid_Dictionary.txt"));
            File.Delete(Path.Combine(path, "Hygene_Dictionary.txt"));
            File.Delete(Path.Combine(path, "Food_Dictionary.txt"));
            File.Delete(Path.Combine(path, "Other_Dictionary.txt"));

            File.Delete(Path.Combine(path, "Goods_Dictionary.txt"));

            File.Delete(Path.Combine(path, "Math_Dictionary.txt"));
            File.Delete(Path.Combine(path, "Reading_Dictionary.txt"));
            File.Delete(Path.Combine(path, "Writing_Dictionary.txt"));

            File.Delete(Path.Combine(path, "Request_Dictionary.txt"));

            File.Delete(Path.Combine(path, "serial_list.txt"));
        } 
    }
}
