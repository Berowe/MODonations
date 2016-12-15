// Author: Braxton Rowe
using MiddleOut;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace MiddleOutTestProject
{
    [TestClass]
    public class UserTest
    {
        string name = "Tester";
        string password = "Password";
        string email = "test@uw.edu";
        string street = "123 Test St";
        string apartment = "#102";
        string city = "Tacoma";
        string state = "WA";
        string zipcode = "98422";
        string vehichle = "SUV";
        string capacity = "20";
        string start = "1000";
        string stop = "1500";
        string license = "photo.jpg";
        List<Service> myServices;

        [TestMethod]
        public void User_Setter_Getter_Test()
        {
            User test = new User(name, password, email, street, apartment, city, state, zipcode);
            UserDatabase uBase = new UserDatabase();
            ServiceDatabase sBase = new ServiceDatabase();
            uBase.addUser(test);

            test.setName("tester");
            Assert.AreEqual("tester", test.getName());
            test.setPassword("pass");
            Assert.IsTrue(uBase.verifyUser("test@uw.edu", "pass"));
            test.setEmail("tester@uw.edu");
            Assert.AreEqual("tester@uw.edu", test.getEmail());
            test.setAddress("321 Test St", "#201", "Portland", "OR", "97501");
            Assert.AreEqual("321 Test St, #201, Portland, OR, 97501", test.getAddress());
            test.setVehicleType("Sedan");
            Assert.AreEqual("Sedan", test.getVehicleType());
            test.setCapacity("30");
            Assert.AreEqual("30", test.getCapacity());
            test.setTimeStart("1400");
            Assert.AreEqual("1400", test.getTimeStart());
            test.setTimeStop("2000");
            Assert.AreEqual("2000", test.getTimeStop());
            test.setLicenseFilePath("testing.jpeg");
            Assert.AreEqual("testing.jpeg", test.getLicenseFilePath());
            test.setAdmin(true);
            Assert.IsTrue(test.isAdmin());

            Service toy = new Service("tester", "tester@uw.edu");
            sBase.createService(ServiceTypes.Donate, DonationTypes.Toys, test, toy);
            myServices = new List<Service>();
            myServices.Add(toy);
            test.addService(toy);
            Assert.AreEqual(myServices[0], test.getServices()[0]);

            Assert.IsTrue(test.checkPassword("pass"));
            Assert.IsFalse(test.checkPassword("Password"));

            test.addDrive(vehichle, capacity, start, stop, license);
            Assert.AreEqual(vehichle, test.getVehicleType());
            Assert.AreEqual(capacity, test.getCapacity());
            Assert.AreEqual(start, test.getTimeStart());
            Assert.AreEqual(stop, test.getTimeStop());
            Assert.AreEqual(license, test.getLicenseFilePath());

            string path = @"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\CommonExtensions\Microsoft\TestWindow";
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
            File.Delete(Path.Combine(path, "userlist.txt"));
        }
    }
}