using System;
using System.Text;

namespace MiddleOut
{
    class Service
    {

        private int myUserID;
        private int myServiceID;
        private string myServiceDescription;
        private string myTimeStart = null;
        private string myTimeStop = null;
        private string myLocationX = null;
        private string myLocationY = null;

        private double myTaxCredit;
        private Boolean myCompleted = false;
        private Boolean mySelected = false;

        private ReviewService myReview;

        public Service(int theServiceID, int theUserID)
        {
            myUserID = theUserID;
            myServiceID = theServiceID;
        }

        public Service beginService(int theServiceID, int theUserID)
        {
            Service serve = new Service(theServiceID, theUserID);
            string id = Convert.ToString(theServiceID);

            char sType = id[0];
            char dType = id[1];

            switch (sType)
            {
                case '0':
                    switch (dType)
                    {
                        case '0':
                            serve = new ToyDonor(theServiceID, theUserID);
                            break;
                        case '1':
                            serve = new ClothesDonor(theServiceID, theUserID);
                            break;
                        case '2':
                            serve = new TechDonor(theServiceID, theUserID);
                            break;
                        case '3':
                            serve = new FirstAidDonor(theServiceID, theUserID);
                            break;
                        case '4':
                            serve = new FoodDonor(theServiceID, theUserID);
                            break;
                        case '5':
                            serve = new ToolsDonor(theServiceID, theUserID);
                            break;
                        case '6':
                            serve = new HygeneDonor(theServiceID, theUserID);
                            break;
                        case '7':
                            serve = new OtherDonor(theServiceID, theUserID);
                            break;
                    }
                    break;
                case '1':
                    switch (dType)
                    {
                        case '0':
                            serve = new GoodsDriver(theServiceID, theUserID);
                            break;
                        case '1':
                            serve = new PersonDriver(theServiceID, theUserID);
                            break;
                    }
                    break;
                case '2':
                    switch (dType)
                    {
                        case '0':
                            serve = new MathEducator(theServiceID, theUserID);
                            break;
                        case '1':
                            serve = new WritingEducator(theServiceID, theUserID);
                            break;
                        case '2':
                            serve = new ReadingEducator(theServiceID, theUserID);
                            break;
                    }
                    break;
                case '3':
                    switch (dType)
                    {
                        case '0':
                            serve = new DonationRequest(theServiceID, theUserID);
                            break;
                        case '1':
                            serve = new DriverRequest(theServiceID, theUserID);
                            break;
                        case '2':
                            serve = new EducatorRequest(theServiceID, theUserID);
                            break;
                    }
                    break;
            }


            return serve;
        }

        public class ToyDonor : Service
        {
            public ToyDonor(int theServiceID, int theUserID) :
                base(theServiceID, theUserID)
            {
                myUserID = theUserID;
                myServiceID = theServiceID;
            }
        }

        public class ClothesDonor : Service
        {
            public ClothesDonor(int theServiceID, int theUserID) :
                base(theServiceID, theUserID)
            {
                myUserID = theUserID;
                myServiceID = theServiceID;
            }
        }

        public class TechDonor : Service
        {
            public TechDonor(int theServiceID, int theUserID) :
                base(theServiceID, theUserID)
            {
                myUserID = theUserID;
                myServiceID = theServiceID;
            }
        }

        public class FirstAidDonor : Service
        {
            public FirstAidDonor(int theServiceID, int theUserID) :
                base(theServiceID, theUserID)
            {
                myUserID = theUserID;
                myServiceID = theServiceID;
            }
        }

        public class HygeneDonor : Service
        {
            public HygeneDonor(int theServiceID, int theUserID) :
                base(theServiceID, theUserID)
            {
                myUserID = theUserID;
                myServiceID = theServiceID;
            }
        }

        public class ToolsDonor : Service
        {
            public ToolsDonor(int theServiceID, int theUserID) :
                base(theServiceID, theUserID)
            {
                myUserID = theUserID;
                myServiceID = theServiceID;
            }
        }

        public class FoodDonor : Service
        {
            public FoodDonor(int theServiceID, int theUserID) :
                base(theServiceID, theUserID)
            {
                myUserID = theUserID;
                myServiceID = theServiceID;
            }
        }

        public class OtherDonor : Service
        {
            public OtherDonor(int theServiceID, int theUserID) :
                base(theServiceID, theUserID)
            {
                myUserID = theUserID;
                myServiceID = theServiceID;
            }
        }

        public class PersonDriver : Service
        {
            public PersonDriver(int theServiceID, int theUserID) :
                base(theServiceID, theUserID)
            {
                myUserID = theUserID;
                myServiceID = theServiceID;
            }
        }

        public class GoodsDriver : Service
        {
            public GoodsDriver(int theServiceID, int theUserID) :
                base(theServiceID, theUserID)
            {
                myUserID = theUserID;
                myServiceID = theServiceID;
            }
        }

        public class MathEducator : Service
        {
            public MathEducator(int theServiceID, int theUserID) :
                base(theServiceID, theUserID)
            {
                myUserID = theUserID;
                myServiceID = theServiceID;
            }
        }

        public class ReadingEducator : Service
        {
            public ReadingEducator(int theServiceID, int theUserID) :
                base(theServiceID, theUserID)
            {
                myUserID = theUserID;
                myServiceID = theServiceID;
            }
        }

        public class DonationRequest : Service
        {
            public DonationRequest(int theServiceID, int theUserID) :
                base(theServiceID, theUserID)
            {
                myUserID = theUserID;
                myServiceID = theServiceID;
            }
        }

        public class DriverRequest : Service
        {
            public DriverRequest(int theServiceID, int theUserID) :
                base(theServiceID, theUserID)
            {
                myUserID = theUserID;
                myServiceID = theServiceID;
            }
        }

        public class EducatorRequest : Service
        {
            public EducatorRequest(int theServiceID, int theUserID) :
                base(theServiceID, theUserID)
            {
                myUserID = theUserID;
                myServiceID = theServiceID;
            }
        }

        public class WritingEducator : Service
        {
            public WritingEducator(int theServiceID, int theUserID) :
                base(theServiceID, theUserID)
            {
                myUserID = theUserID;
                myServiceID = theServiceID;
            }
        }

        public int getUserID()
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

        public ReviewService getReview()
        {
            return myReview;
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
            myLocationX = Convert.ToString(theX);
            myLocationY = Convert.ToString(theY);
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

        public string ToFile()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(myServiceID.ToString() + "/&/");
            builder.Append(myUserID.ToString() + "/&/");
            builder.Append(myServiceDescription + "/&/");
            builder.Append(myCompleted.ToString() + "/&/");
            builder.Append(mySelected.ToString() + "/&/");
            if (myTimeStart != null)
            {
                builder.Append(myTimeStart + "/&/");
                builder.Append(myTimeStop + "/&/");
                builder.Append(myLocationX + "/&/");
                builder.Append(myLocationY + "/&/");
            }

            return builder.ToString();
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
            if (myLocationX != null)
            {
                builder.Append(myLocationX + ", ");
                builder.Append(myLocationY + "\n");
            }

            if (myReview != null)
            {
                builder.Append(myReview.ToString() + "\n");
            }

            return builder.ToString();
        }
    }
}

