using Newtonsoft.Json;
using System.Text;

namespace MiddleOut
{
    /// <summary>
    /// Authors: Ameet Toor, Braxton Rowe
    /// The ReviewService class associates a rating and a summary with a 
    /// user and a service.
    /// </summary>
    public class ReviewService
    {
        #region fields

        /// <summary>
        /// Author: Braxton Rowe
        /// The JsonProperty of the service summary.
        /// 
        /// Author: Ameet Toor
        /// The summary of the service review.
        /// </summary>
        [JsonProperty("mySummary")]
        private readonly string mySummary;

        /// <summary>
        /// Author: Braxton Rowe
        /// The JsonProperty of the service rating.
        /// 
        /// Author: Ameet Toor
        /// The int that holds the rating of the service.
        /// </summary>
        [JsonProperty("myRating")]
        private readonly int myRating;
        #endregion

        #region methods
        #region public methods

        /// <summary>
        /// Author: Ameet Toor
        /// Constructor that sets the fields.
        /// </summary>
        /// <param name="theMyRating">The rating of the service, ranges from 0 to 5.</param>
        /// <param name="theMySummary">Summary of the service.</param>
        public ReviewService(int theMyRating, string theMySummary)
        {
            mySummary = theMySummary;

            if (theMyRating < 0) theMyRating = 0;
            if (theMyRating > 5) theMyRating = 5;
            myRating = theMyRating;
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Returns a string that has the rating and the summary of the service, in one string.
        /// </summary>
        /// <returns>String that contains the summary and the rating of the service.</returns>
        override
        public string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Review: \n");
            sb.Append("Rating: " + myRating + "/5\n");
            sb.Append("Summary: " + mySummary + "\n");
            return sb.ToString();
        }
        #endregion

        #region private methods



        #endregion
        #endregion
    }
}
