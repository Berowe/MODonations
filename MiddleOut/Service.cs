using Newtonsoft.Json;
using System;
using System.Text;

namespace MiddleOut
{

    class Service
    {
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


        public Service(String theName, String theEmail)
        {
            myName = theName;
            myUserID = theEmail;
            myServiceID = "";
            myServiceDescription = "";
            myTimeStart = "";
            myTimeStop = "";
            myLocation = new int[2];
            myLocation[0] = 0;
            myLocation[1] = 0;
            myTaxCredit = 0.00;
            myCompleted = false;
            mySelected = false;
        }

        public String getUserID()
        {
            return myUserID;
        }

        public double getTaxCredit()
        {
            return myTaxCredit;
        }

        public Boolean getComp()
        {
            return myCompleted;
        }

        public Boolean getSelect()
        {
            return mySelected;
        }

        public int[] getLocation()
        {
            return myLocation;
        }

        public ReviewService getReview()
        {
            return myReview;
        }

        public EnumTypes getDonationRequest()
        {
            return myDonationRequest;
        }

        public void setUserID(String theID)
        {
            myUserID = theID;
        }

        public void setDescription(string theDescription)
        {
            myServiceDescription = theDescription;
        }

        public void setTime(string theStart, string theEnd)
        {
            myTimeStart = theStart;
            myTimeStop = theEnd;
        }

        public void setLocation(int theX, int theY)
        {
            myLocation[0] = theX;
            myLocation[1] = theY;
        }

        public void setDonationRequest(EnumTypes theType)
        {
            myDonationRequest = theType;
        }

        public void setTax(double theTaxCredit)
        {
            myTaxCredit = theTaxCredit;
        }

        public void setCompleted(Boolean theComp)
        {
            myCompleted = theComp;
        }

        public void setSelected(Boolean theSelected)
        {
            mySelected = theSelected;
        }

        public void setReview(ReviewService theReview)
        {
            myReview = theReview;
        }

        public void setServiceID(String theID)
        {
            myServiceID = theID;
        }

        public String getServiceID()
        {
            return myServiceID;
        }

        override
        public string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(myServiceID.ToString() + "\n");
            builder.Append(myUserID.ToString() + "\n");
            builder.Append(myServiceDescription + "\n");
            builder.Append(myCompleted.ToString() + "\n");
            builder.Append(mySelected.ToString() + "\n");
            if (myTimeStart != null)
            {
                builder.Append(myTimeStart + " to ");
                builder.Append(myTimeStop + "\n");
            }
            builder.Append(Convert.ToString(myLocation[0]));
            builder.Append(Convert.ToString(myLocation[1]));

            if (myReview != null)
            {
                builder.Append(myReview.ToString() + "\n");
            }

            return builder.ToString();
        }
    }
}

