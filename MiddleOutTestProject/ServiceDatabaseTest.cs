// Author: Braxton Rowe
using MiddleOut;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace MiddleOutTestProject
{
    [TestClass]
    public class ServiceDatabaseTest
    {
        [TestMethod]
        public void Service_Database_Test()
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

            sBase.createService(ServiceTypes.Donate, DonationTypes.Toys, testUser, toy);
            sBase.createService(ServiceTypes.Donate, DonationTypes.Clothes, testUser, clothes);
            sBase.createService(ServiceTypes.Donate, DonationTypes.Tech, testUser, tech);
            sBase.createService(ServiceTypes.Donate, DonationTypes.FirstAid, testUser, faid);
            sBase.createService(ServiceTypes.Donate, DonationTypes.Food, testUser, food);
            sBase.createService(ServiceTypes.Donate, DonationTypes.Hygene, testUser, hygiene);
            sBase.createService(ServiceTypes.Donate, DonationTypes.Other, testUser, other);

            sBase.createService(ServiceTypes.Drive, DonationTypes.Goods, testUser, drive);

            sBase.createService(ServiceTypes.Educate, DonationTypes.Math, testUser, math);
            sBase.createService(ServiceTypes.Educate, DonationTypes.Reading, testUser, read);
            sBase.createService(ServiceTypes.Educate, DonationTypes.Writing, testUser, write);

            sBase.createService(ServiceTypes.Request, DonationTypes.Tools, testUser, request);

            Assert.AreEqual("1110000\n1210000\n1310000\n1410000\n1610000\n1510000\n1810000\n", sBase.printServices(ServiceTypes.Donate));
            Assert.AreEqual("2110000\n", sBase.printServices(ServiceTypes.Drive));
            System.Console.WriteLine(sBase.retrieveService("3210000"));
            Assert.AreEqual("3110000\n3210000\n3310000\n", sBase.printServices(ServiceTypes.Educate));
            Assert.AreEqual("4110000\n", sBase.printServices(ServiceTypes.Request));

            Assert.AreEqual("1110000\n", sBase.printServices(ServiceTypes.Donate, DonationTypes.Toys));
            Assert.AreEqual("1210000\n", sBase.printServices(ServiceTypes.Donate, DonationTypes.Clothes));
            Assert.AreEqual("1310000\n", sBase.printServices(ServiceTypes.Donate, DonationTypes.Tech));
            Assert.AreEqual("1410000\n", sBase.printServices(ServiceTypes.Donate, DonationTypes.FirstAid));
            Assert.AreEqual("1510000\n", sBase.printServices(ServiceTypes.Donate, DonationTypes.Hygene));
            Assert.AreEqual("1610000\n", sBase.printServices(ServiceTypes.Donate, DonationTypes.Food));
            Assert.AreEqual("1810000\n", sBase.printServices(ServiceTypes.Donate, DonationTypes.Other));

            Assert.AreEqual("2110000\n", sBase.printServices(ServiceTypes.Drive, DonationTypes.Goods));

            Assert.AreEqual("3110000\n", sBase.printServices(ServiceTypes.Educate, DonationTypes.Math));
            Assert.AreEqual("3210000\n", sBase.printServices(ServiceTypes.Educate, DonationTypes.Reading));
            Assert.AreEqual("3310000\n", sBase.printServices(ServiceTypes.Educate, DonationTypes.Writing));

            Assert.AreEqual("4110000\n", sBase.printServices(ServiceTypes.Request, DonationTypes.Donation));

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

            Assert.AreEqual("1110000\n1210000\n1310000\n1410000\n1610000\n1510000\n1810000\n", sBase.printServices(ServiceTypes.Donate));
            Assert.AreEqual("2110000\n", sBase.printServices(ServiceTypes.Drive));
            Assert.AreEqual("3110000\n3210000\n3310000\n", sBase.printServices(ServiceTypes.Educate));
            Assert.AreEqual("4110000\n", sBase.printServices(ServiceTypes.Request));

            Assert.AreEqual("1110000\n", sBase.printServices(ServiceTypes.Donate, DonationTypes.Toys));
            Assert.AreEqual("1210000\n", sBase.printServices(ServiceTypes.Donate, DonationTypes.Clothes));
            Assert.AreEqual("1310000\n", sBase.printServices(ServiceTypes.Donate, DonationTypes.Tech));
            Assert.AreEqual("1410000\n", sBase.printServices(ServiceTypes.Donate, DonationTypes.FirstAid));
            Assert.AreEqual("1510000\n", sBase.printServices(ServiceTypes.Donate, DonationTypes.Hygene));
            Assert.AreEqual("1610000\n", sBase.printServices(ServiceTypes.Donate, DonationTypes.Food));
            Assert.AreEqual("1810000\n", sBase.printServices(ServiceTypes.Donate, DonationTypes.Other));

            Assert.AreEqual("2110000\n", sBase.printServices(ServiceTypes.Drive, DonationTypes.Goods));

            Assert.AreEqual("3110000\n", sBase.printServices(ServiceTypes.Educate, DonationTypes.Math));
            Assert.AreEqual("3210000\n", sBase.printServices(ServiceTypes.Educate, DonationTypes.Reading));
            Assert.AreEqual("3310000\n", sBase.printServices(ServiceTypes.Educate, DonationTypes.Writing));

            Assert.AreEqual("4110000\n", sBase.printServices(ServiceTypes.Request, DonationTypes.Donation));

            Service toy = sBase.retrieveService("1110000");
            Assert.AreEqual(toy, sBase.retrieveService("1110000"));
            Service clothes = sBase.retrieveService("1210000");
            Assert.AreEqual(clothes, sBase.retrieveService("1210000"));
            Service tech = sBase.retrieveService("1310000");
            Assert.AreEqual(tech, sBase.retrieveService("1310000"));
            Service faid = sBase.retrieveService("1410000");
            Assert.AreEqual(faid, sBase.retrieveService("1410000"));
            Service hygiene = sBase.retrieveService("1510000");
            Assert.AreEqual(hygiene, sBase.retrieveService("1510000"));
            Service food = sBase.retrieveService("1610000");
            Assert.AreEqual(food, sBase.retrieveService("1610000"));
            Service other = sBase.retrieveService("1810000");
            Assert.AreEqual(other, sBase.retrieveService("1810000"));

            Service drive = sBase.retrieveService("2110000");
            Assert.AreEqual(drive, sBase.retrieveService("2110000"));

            Service math = sBase.retrieveService("3110000");
            Assert.AreEqual(math, sBase.retrieveService("3110000"));
            Service read = sBase.retrieveService("3210000");
            Assert.AreEqual(read, sBase.retrieveService("3210000"));
            Service write = sBase.retrieveService("3310000");
            Assert.AreEqual(write, sBase.retrieveService("3310000"));

            Service request = sBase.retrieveService("4110000");
            Assert.AreEqual(request, sBase.retrieveService("4110000"));

            string path = @"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\CommonExtensions\Microsoft\TestWindow";
            File.Delete(Path.Combine(path, "Toy_Dictionary.txt"));
            File.Delete(Path.Combine(path, "Clothes_Dictionary.txt"));
            File.Delete(Path.Combine(path, "Tech_Dictionary.txt"));
            File.Delete(Path.Combine(path, "FirstAid_Dictionary.txt"));
            File.Delete(Path.Combine(path, "Hygene_Dictionary.txt"));
            File.Delete(Path.Combine(path, "Food_Dictionary.txt"));
            File.Delete(Path.Combine(path, "Other_Dictionary.txt"));

            File.Delete(Path.Combine(path, "Goods_Dictionary.txt"));

            File.Delete(Path.Combine(path, "Math_Dictionary.txt"));
            File.Delete(Path.Combine(path, "Reading_Dictionary.txt"));
            File.Delete(Path.Combine(path, "Writing_Dictionary.txt"));

            File.Delete(Path.Combine(path, "Donation_Dictionary.txt"));

            File.Delete(Path.Combine(path, "serial_list.txt"));
            File.Delete(Path.Combine(path, "userlist.txt"));
        }
    }
}
