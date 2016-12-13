//Author: Braxton Rowe

using Newtonsoft.Json;
using System;
using System.Text;
namespace MiddleOut
{
    /// <summary>
    /// The Service class is an object class for the Service object.
    /// </summary>
    public class Service
    {
        #region private fields
        [JsonProperty("myName")]
        private String myName;
        [JsonProperty("myUserID")]
        private String myUserID;
        [JsonProperty("myServiceID")]
        private String myServiceID;
        [JsonProperty("myServiceDescription")]
        private string myServiceDescription;
        [JsonProperty("myTimeStart")]
        private string myTimeStart;
        [JsonProperty("myTimeStop")]
        private string myTimeStop;
        [JsonProperty("myLocation")]
        private int[] myLocation;
        [JsonProperty("myTaxCredit")]
        private double myTaxCredit;
        [JsonProperty("myCompleted")]
        private Boolean myCompleted;
        [JsonProperty("mySelected")]
        private Boolean mySelected;
        [JsonProperty("myReview")]
        private ReviewService myReview;
        [JsonProperty("myDonationRequest")]
        private EnumTypes myDonationRequest;
        #endregion

        #region constructor
        /// <summary>
        /// The Constructor for the Service Object
        /// </summary>
        /// <param name="theName">The Real Name of the User</param>
        /// <param name="theEmail">The Email Address of the user.</param>
        public Service(String theName, String theEmail)
        {
            myName = theName;
            myUserID = theEmail;
            myLocation = new int[2];
            myTaxCredit = 0.00;
            myCompleted = false;
            mySelected = false;
        }
        #endregion

        #region getters
        /// <summary>
        /// Gets the Real Name of the User who created the Service object.
        /// </summary>
        /// <returns>Returns the User's real name.</returns>
        public String getName()
        {
            return myName;
        }

        /// <summary>
        /// Gets the User ID of the User
        /// </summary>
        /// <returns>Returns the User ID, which is the User's Email Address.</returns>
        public String getUserID()
        {
            return myUserID;
        }

        /// <summary>
        /// Gets the Service ID of the Service Object.
        /// </summary>
        /// <returns>Returns the Service ID.</returns>
        public String getServiceID()
        {
            return myServiceID;
        }

        /// <summary>
        /// Gets the Service Description of the Service object.
        /// </summary>
        /// <returns>Returns the Service Description</returns>
        public String getDescription()
        {
            return myServiceDescription;
        }

        /// <summary>
        /// Gets the Tax Credit associated with the Service object.
        /// </summary>
        /// <returns>Returns the tax credit of the Service object</returns>
        public double getTaxCredit()
        {
            return myTaxCredit;
        }

        /// <summary>
        /// Gets the completion status of the Service object.
        /// </summary>
        /// <returns>Returns true if the Service is completed, false if not.</returns>
        public Boolean getComp()
        {
            return myCompleted;
        }

        /// <summary>
        /// Gets the selected value of the Service object. 
        /// </summary>
        /// <returns>Returns true if the Service is selected, false if not.</returns>
        public Boolean getSelect()
        {
            return mySelected;
        }

        /// <summary>
        /// Gets the location for the Service object.
        /// </summary>
        /// <returns>Returns an int array of two values for the X and Y location of the Service.</returns>
        public int[] getLocation()
        {
            return myLocation;
        }

        /// <summary>
        /// Gets the ReviewService object for the Service object.
        /// </summary>
        /// <returns>Returns a ReviewService object associated with the Service.</returns>
        public ReviewService getReview()
        {
            return myReview;
        }

        /// <summary>
        /// Gets the Donation Request Type for the Service.
        /// </summary>
        /// <returns>Returns an EnumType of the Service object with the type of Donation it is.</returns>
        public EnumTypes getDonationRequest()
        {
            return myDonationRequest;
        }
        #endregion

        #region setters

        /// <summary>
        /// Sets the User ID, which is the User's email address.
        /// </summary>
        /// <param name="theID">The new User ID.</param>
        public void setUserID(String theID)
        {
            myUserID = theID;
        }
        
        /// <summary>
        /// Sets the Service Description of the Service.
        /// </summary>
        /// <param name="theDescription">The Service Description.</param>
        public void setDescription(string theDescription)
        {
            myServiceDescription = theDescription;
        }

        /// <summary>
        /// Sets the starting and stopping time of the Service.
        /// </summary>
        /// <param name="theStart">The Start Time</param>
        /// <param name="theEnd">The Stop Time</param>
        public void setTime(string theStart, string theEnd)
        {
            myTimeStart = theStart;
            myTimeStop = theEnd;
        }

        /// <summary>
        /// Sets the location of the Service object.
        /// </summary>
        /// <param name="theX">The X value of the location.</param>
        /// <param name="theY">The Y value of the location.</param>
        public void setLocation(int theX, int theY)
        {
            myLocation[0] = theX;
            myLocation[1] = theY;
        }

        /// <summary>
        /// Sets the type of Donation of the Service Object.
        /// </summary>
        /// <param name="theType">The type of donation.</param>
        public void setDonationRequest(EnumTypes theType)
        {
            myDonationRequest = theType;
        }

        /// <summary>
        /// Sets the tax credit for the Service Object.
        /// </summary>
        /// <param name="theTaxCredit">The tax credit.</param>
        public void setTax(double theTaxCredit)
        {
            myTaxCredit = theTaxCredit;
        }

        /// <summary>
        /// Sets the completion status of the Service object.
        /// </summary>
        /// <param name="theComp">True/False completion status.</param>
        public void setCompleted(Boolean theComp)
        {
            myCompleted = theComp;
        }

        /// <summary>
        /// Sets the selected status of the Service object.
        /// </summary>
        /// <param name="theSelected">True/False selection status.</param>
        public void setSelected(Boolean theSelected)
        {
            mySelected = theSelected;
        }

        /// <summary>
        /// Sets the review for the Service object.
        /// </summary>
        /// <param name="theReview">The ReviewService object.</param>
        public void setReview(ReviewService theReview)
        {
            myReview = theReview;
        }

        /// <summary>
        /// Sets the Service ID of the Service object.
        /// </summary>
        /// <param name="theID">The Service ID.</param>
        public void setServiceID(String theID)
        {
            myServiceID = theID;
        }
        #endregion

        #region overrides
        override
        public string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(myName + "\n");
            builder.Append(myUserID + "\n");
            if (myServiceID != null)
            {
                builder.Append(myServiceID + "\n");
            }
            if (myServiceDescription != null)
            {
                builder.Append(myServiceDescription + "\n");
            }
            builder.Append("Service is Selected: " + mySelected.ToString() + "\n");
            builder.Append("Service is Completed: " + myCompleted.ToString() + "\n");
            if (myTimeStart != null)
            {
                builder.Append(myTimeStart + " to " + myTimeStop + "\n");
            }
            if (myLocation != null)
            {
                builder.Append("X and Y Coordinates of Service: {0},{1}" + "\n", myLocation[0], myLocation[1]);
            }
            builder.Append(Convert.ToString(myLocation[0]));
            builder.Append(Convert.ToString(myLocation[1]));
            builder.Append(myTaxCredit.ToString() + "\n");
            if (myReview != null)
            {
                builder.Append(myReview.ToString() + "\n");
            }

            return builder.ToString();
        }
        #endregion
    }
}