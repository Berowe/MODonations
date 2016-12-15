// Author: Braxton Rowe
using System;
using MiddleOut;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiddleOutTestProject
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void Service_Tests()
        {
            Service toy = new Service("Tester", "test@uw.edu");
            toy.setUserID("testing@uw.edu");
            Assert.AreEqual("testing@uw.edu", toy.getUserID());
            toy.setDescription("This is a description");
            Assert.AreEqual("This is a description", toy.getDescription());
            toy.setTime("1000", "1200");
            Assert.AreEqual("1000", toy.getTime()[0]);
            Assert.AreEqual("1200", toy.getTime()[1]);
            toy.setLocation(100, 200);
            Assert.AreEqual(100, toy.getLocation()[0]);
            Assert.AreEqual(200, toy.getLocation()[1]);
            toy.setDonationRequest(DonationTypes.Food);
            Assert.AreEqual(DonationTypes.Food, toy.getDonationRequest());
            toy.setServiceType(ServiceTypes.Drive);
            Assert.AreEqual(ServiceTypes.Drive, toy.getDonationType());
            ReviewService review = new ReviewService(5, "This is the best test!");
            toy.setReview(review);
            Assert.AreEqual(review, toy.getReview());
            toy.setServiceID("1110000");
            Assert.AreEqual("1110000", toy.getServiceID());
        }
    }
}
