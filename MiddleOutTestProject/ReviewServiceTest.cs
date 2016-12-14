using MiddleOut;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiddleOutTestProject
{
    /// <summary>
    /// Author: Ameet Toor
    /// This class tests the ReviewService class.
    /// </summary>
    [TestClass]
    public class ReviewServiceTest
    {
        /// <summary>
        /// Author: Ameet Toor
        /// Tests to make sure rating is not above 5
        /// </summary>
        [TestMethod]
        public void TestRatingNotAbove5()
        {
            string correctResult = "Review: \nRating: 5/5\nSummary: summary\n";

            //Test to see if rating is set to greater than 5, that the rating is set to 5.
            ReviewService reviewService = new ReviewService(6, "summary");
            Assert.AreEqual(correctResult, reviewService.ToString(), true);


            reviewService = new ReviewService(100, "summary");
            Assert.AreEqual(correctResult, reviewService.ToString(), true);

            reviewService = new ReviewService(3, "summary");
            Assert.AreNotEqual(correctResult, reviewService.ToString(), true);

        }

        /// <summary>
        /// Author: Ameet Toor
        /// Tests to make sure rating is not below 0.
        /// </summary>
        [TestMethod]
        public void TestRatingNotBelow0()
        {
            string correctResult = "Review: \nRating: 0/5\nSummary: summary\n";

            //Test to see if rating is set to greater than 5, that the rating is set to 5.
            ReviewService reviewService = new ReviewService(-1, "summary");
            Assert.AreEqual(correctResult, reviewService.ToString(), true);


            reviewService = new ReviewService(-50, "summary");
            Assert.AreEqual(correctResult, reviewService.ToString(), true);


            reviewService = new ReviewService(5, "summary");
            Assert.AreNotEqual(correctResult, reviewService.ToString(), true);
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Tests to make sure rating is between 5 and 0;
        /// </summary>
        [TestMethod]
        public void TestRatingBetween5And0()
        {
            string correctResult = "Review: \nRating: 0/5\nSummary: summary\n";

            //Test to see if rating is set to greater than 5, that the rating is set to 5.
            ReviewService reviewService = new ReviewService(0, "summary");
            Assert.AreEqual(correctResult, reviewService.ToString(), true);

            correctResult = "Review: \nRating: 1/5\nSummary: summary\n";
            reviewService = new ReviewService(1, "summary");
            Assert.AreEqual(correctResult, reviewService.ToString(), true);

            correctResult = "Review: \nRating: 2/5\nSummary: summary\n";
            reviewService = new ReviewService(2, "summary");
            Assert.AreEqual(correctResult, reviewService.ToString(), true);

            correctResult = "Review: \nRating: 3/5\nSummary: summary\n";
            reviewService = new ReviewService(3, "summary");
            Assert.AreEqual(correctResult, reviewService.ToString(), true);

            correctResult = "Review: \nRating: 4/5\nSummary: summary\n";
            reviewService = new ReviewService(4, "summary");
            Assert.AreEqual(correctResult, reviewService.ToString(), true);

            correctResult = "Review: \nRating: 5/5\nSummary: summary\n";
            reviewService = new ReviewService(5, "summary");
            Assert.AreEqual(correctResult, reviewService.ToString(), true);


            reviewService = new ReviewService(4, "summary");
            Assert.AreNotEqual(correctResult, reviewService.ToString(), true);
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Tests to make sure the toString is printing out correctly.
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            string correctResult = "Review: \nRating: 4/5\nSummary: summary\n";

            //Test to see if rating is set to greater than 5, that the rating is set to 5.
            ReviewService reviewService = new ReviewService(4, "summary");
            Assert.AreEqual(correctResult, reviewService.ToString(), true);


            correctResult = "";
            Assert.AreNotEqual(correctResult, reviewService.ToString(), true);
        }
    }
}
