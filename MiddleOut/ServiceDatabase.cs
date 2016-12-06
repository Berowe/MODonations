using System;
using System.Collections.Generic;
using System.IO;

namespace MiddleOut
{
    class ServiceDatabase
    {
        private Dictionary<int, Service.ToyDonor> myToys;
        private Dictionary<int, Service.ClothesDonor> myClothes;
        private Dictionary<int, Service.TechDonor> myTech;
        private Dictionary<int, Service.FirstAidDonor> myFirstAid;
        private Dictionary<int, Service.HygeneDonor> myHygene;
        private Dictionary<int, Service.ToolsDonor> myTools;
        private Dictionary<int, Service.FoodDonor> myFood;
        private Dictionary<int, Service.OtherDonor> myOthers;
        private Dictionary<int, Service.PersonDriver> myPersonDrivers;
        private Dictionary<int, Service.GoodsDriver> myGoodsDrivers;
        private Dictionary<int, Service.MathEducator> myMathEducators;
        private Dictionary<int, Service.ReadingEducator> myReadingEducators;
        private Dictionary<int, Service.WritingEducator> myWritingEducators;
        private Dictionary<int, Service.DonationRequest> myDonationRequests;
        private Dictionary<int, Service.DriverRequest> myDriverRequests;
        private Dictionary<int, Service.EducatorRequest> myEducatorRequests;
        private string myFilePath;
        private string[] split = new string[] { "/&/" };

        public ServiceDatabase()
        {
            myToys = new Dictionary<int, Service.ToyDonor>();
            myClothes = new Dictionary<int, Service.ClothesDonor>();
            myTech = new Dictionary<int, Service.TechDonor>();
            myFirstAid = new Dictionary<int, Service.FirstAidDonor>();
            myHygene = new Dictionary<int, Service.HygeneDonor>();
            myTools = new Dictionary<int, Service.ToolsDonor>();
            myFood = new Dictionary<int, Service.FoodDonor>();
            myOthers = new Dictionary<int, Service.OtherDonor>();
            myPersonDrivers = new Dictionary<int, Service.PersonDriver>();
            myGoodsDrivers = new Dictionary<int, Service.GoodsDriver>();
            myMathEducators = new Dictionary<int, Service.MathEducator>();
            myReadingEducators = new Dictionary<int, Service.ReadingEducator>();
            myWritingEducators = new Dictionary<int, Service.WritingEducator>();
            myDonationRequests = new Dictionary<int, Service.DonationRequest>();
            myDriverRequests = new Dictionary<int, Service.DriverRequest>();
            myEducatorRequests = new Dictionary<int, Service.EducatorRequest>();

            var path = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            myFilePath = Path.Combine(path, "MiddleOut");

            

        }

        public void add(int theID, Service.ToyDonor theService)
        {
            myToys.Add(theID, theService);
        }

        public void add(int theID, Service.ClothesDonor theService)
        {
            myClothes.Add(theID, theService);
        }

        public void add(int theID, Service.TechDonor theService)
        {
            myTech.Add(theID, theService);
        }

        public void add(int theID, Service.FirstAidDonor theService)
        {
            myFirstAid.Add(theID, theService);
        }

        public void add(int theID, Service.HygeneDonor theService)
        {
            myHygene.Add(theID, theService);
        }

        public void add(int theID, Service.ToolsDonor theService)
        {
            myTools.Add(theID, theService);
        }

        public void add(int theID, Service.OtherDonor theService)
        {
            myOthers.Add(theID, theService);
        }

        public void add(int theID, Service.PersonDriver theService)
        {
            myPersonDrivers.Add(theID, theService);
        }

        public void add(int theID, Service.GoodsDriver theService)
        {
            myGoodsDrivers.Add(theID, theService);
        }

        public void add(int theID, Service.MathEducator theService)
        {
            myMathEducators.Add(theID, theService);
        }

        public void add(int theID, Service.ReadingEducator theService)
        {
            myReadingEducators.Add(theID, theService);
        }

        public void add(int theID, Service.WritingEducator theService)
        {
            myWritingEducators.Add(theID, theService);
        }

    } 
}
