using System;
using System.Text;

namespace MiddleOut
{
    /// <summary>
    /// The ReviewService class associates a rating and a summary with a 
    /// user and a service.
    /// </summary>
    internal class ReviewService
    {
        #region fields
        private string _summary;
        private int _rating;
        private readonly int _userId;
        private readonly ServiceTypes _serviceType;
        private readonly DonationTypes _donationType;
        #endregion

        #region methods
        #region public methods

        /// <summary>
        /// Constructor that sets the fields.
        /// </summary>
        /// <param name="theUserId">The userId of the user associated with this review.</param>
        /// <param name="theDonationType">The type of donation.</param>
        /// <param name="theServiceType">The type of service.</param>
        public ReviewService(int theUserId, DonationTypes theDonationType, ServiceTypes theServiceType)
        {
            if (theUserId < 0) throw new ArgumentOutOfRangeException(nameof(theUserId));

            _summary = string.Empty;
            _rating = 0;
            _userId = theUserId;
            _serviceType = theServiceType;
            _donationType = theDonationType;
        }

        /// <summary>
        /// Sets the summary of this review as the given string.
        /// </summary>
        /// <param name="theSummary">The summary of the review as a string.</param>
        public void SetSummary(string theSummary)
        {
            _summary = theSummary;
        }

        /// <summary>
        /// Sets the rating of this review to the given rating.
        /// </summary>
        /// <param name="theRating">The rating of this review as an int.</param>
        public void SetRating(int theRating)
        {
            _rating = theRating;
        }

        /// <summary>
        /// Returns the userID, as an int, that is associated with this review.
        /// </summary>
        /// <returns>UserID, as an int, of the user that is associated with this review.</returns>
        public int GetUserId()
        {
            return _userId;
        }

        /// <summary>
        /// Returns the ServiceID, as an int, of the service that is associated with this review.
        /// </summary>
        /// <returns>The ServiceID, as an int, of the service that is associated with this review.</returns>
        public ServiceTypes GetServiceId()
        {
            return _serviceType;
        }

        public DonationTypes GetDonationType()
        {
            return _donationType;
        }

        /// <summary>
        /// Returns the summary of this review as a string.
        /// </summary>
        /// <returns>The summary of this review as a string.</returns>
        public string GetSummary()
        {
            return _summary;
        }

        /// <summary>
        /// Returns the rating of this review as an int.
        /// </summary>
        /// <returns>The rating of this review as an int.</returns>
        public int GetRating()
        {
            return _rating;
        }

        override 
        public string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Review: \n");
            sb.Append("User ID: "+_userId + "\n");
            sb.Append("Service Type: " + _serviceType + "\n");
            sb.Append("Donation Type: " + _donationType + "\n");
            sb.Append("Rating: " + _rating + "\n");
            sb.Append("Summary: " + _summary + "\n");
            return sb.ToString();
        }
        #endregion

        #region private methods



        #endregion
        #endregion
    }
}
