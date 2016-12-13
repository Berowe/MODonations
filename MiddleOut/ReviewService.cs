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
        [JsonProperty("_summary")]
        private readonly string _summary;

        /// <summary>
        /// Author: Braxton Rowe
        /// The JsonProperty of the service rating.
        /// 
        /// Author: Ameet Toor
        /// The int that holds the rating of the service.
        /// </summary>
        [JsonProperty("_rating")]
        private readonly int _rating;
        #endregion

        #region methods
        #region public methods

        /// <summary>
        /// Author: Ameet Toor
        /// Constructor that sets the fields.
        /// </summary>
        /// <param name="theRating">The rating of the service, ranges from 0 to 5.</param>
        /// <param name="theSummary">Summary of the service.</param>
        public ReviewService(int theRating, string theSummary)
        {
            _summary = theSummary;

            if (theRating < 0) theRating = 0;
            if (theRating > 5) theRating = 5;
            _rating = theRating;
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
            sb.Append("Rating: " + _rating + "/5\n");
            sb.Append("Summary: " + _summary + "\n");
            return sb.ToString();
        }
        #endregion

        #region private methods



        #endregion
        #endregion
    }
}
