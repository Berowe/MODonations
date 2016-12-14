// Author: Braxton Rowe
using MiddleOut;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace MiddleOutTestProject
{
    [TestClass]
    public class UesrDataBaseTest
    {
        User tester;

        [TestMethod]
        public void User_Database_Tests()
        {
            UserDatabase uBase = new UserDatabase();
            tester = new User("Tester", "Password", "test@uw.edu", "123 Test St.", null, "Tacoma", "WA", "98422");

            uBase.addUser(tester);
            Assert.IsTrue(uBase.verifyUser("test@uw.edu", "Password"));
            Assert.IsFalse(uBase.verifyUser("test@uw.edu", "IncorrectPassword"));
            Assert.AreSame(uBase.getUser("test@uw.edu"), tester);
            Assert.IsTrue(uBase.checkUser("test@uw.edu"));
        }

        [TestMethod]
        public void Existing_User_Database_Test()
        {
            UserDatabase uBase = new UserDatabase();

            Assert.IsTrue(uBase.verifyUser("test@uw.edu", "Password"));
            Assert.IsFalse(uBase.verifyUser("test@uw.edu", "IncorrectPassword"));
            tester = uBase.getUser("test@uw.edu");
            Assert.AreSame(uBase.getUser("test@uw.edu"), tester);
            Assert.IsTrue(uBase.checkUser("test@uw.edu"));

            uBase.deleteUser("test@uw.edu");
            Assert.IsFalse(uBase.checkUser("test@uw.edu"));
            Assert.IsFalse(uBase.verifyUser("test@uw.edu", "Password"));

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
