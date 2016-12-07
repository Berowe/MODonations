using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

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
        private Dictionary<String, String> mySerialNumbers;
        private String myPath;
        private String myResourcePath;
        private String myFileName;
        private String[] myStrings = new string[] {"toy_serial", "clothes_serial", "tech_serial", "first_aid_serial",
        "hygene_serial", "tools_serial", "food_serial", "other_serial", "person_serial", "goods_serial", "math_serial",
        "reading_serial", "writing_serial", "donation_serial", "driver_serial", "educator_serial", "user_database_serial"};

        public ServiceDatabase()
        {
            initializeDictionaries();
            createFilePath();
            readSerialNumbers();
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

        private void initializeDictionaries()
        {
            if (!File.Exists(myFileName))
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

                for (int i = 0; i < myStrings.Length - 1; i++)
                {
                    mySerialNumbers.Add(myStrings[i], "0000");
                }
                mySerialNumbers.Add(myStrings[myStrings.Length], "1000000");
                createFiles();
            }
            else
            {
                myToys = new JavaScriptSerializer()
                    .Deserialize<Dictionary<int, Service.ToyDonor>>(File.ReadAllText(Path.Combine(myPath, "Toy_Dictionary.txt")));
                myClothes = new JavaScriptSerializer()
                    .Deserialize<Dictionary<int, Service.ClothesDonor>>(File.ReadAllText(Path.Combine(myPath, "Clothes_Dictionary.txt")));
                myTech = new JavaScriptSerializer()
                    .Deserialize<Dictionary<int, Service.TechDonor>>(File.ReadAllText(Path.Combine(myPath, "Tech_Dictionary.txt")));
                myFirstAid = new JavaScriptSerializer()
                    .Deserialize<Dictionary<int, Service.FirstAidDonor>>(File.ReadAllText(Path.Combine(myPath, "FirstAid_Dictionary.txt")));
                myHygene = new JavaScriptSerializer()
                    .Deserialize<Dictionary<int, Service.HygeneDonor>>(File.ReadAllText(Path.Combine(myPath, "Hygene_Dictionary.txt")));
                myTools = new JavaScriptSerializer()
                    .Deserialize<Dictionary<int, Service.ToolsDonor>>(File.ReadAllText(Path.Combine(myPath, "Tools_Dictionary.txt")));
                myFood = new JavaScriptSerializer()
                    .Deserialize<Dictionary<int, Service.FoodDonor>>(File.ReadAllText(Path.Combine(myPath, "Food_Dictionary.txt")));
                myOthers = new JavaScriptSerializer()
                    .Deserialize<Dictionary<int, Service.OtherDonor>>(File.ReadAllText(Path.Combine(myPath, "Other_Dictionary.txt")));
                myPersonDrivers = new JavaScriptSerializer()
                    .Deserialize<Dictionary<int, Service.PersonDriver>>(File.ReadAllText(Path.Combine(myPath, "Person_Dictionary.txt")));
                myGoodsDrivers = new JavaScriptSerializer()
                    .Deserialize<Dictionary<int, Service.GoodsDriver>>(File.ReadAllText(Path.Combine(myPath, "Goods_Dictionary.txt")));
                myMathEducators = new JavaScriptSerializer()
                    .Deserialize<Dictionary<int, Service.MathEducator>>(File.ReadAllText(Path.Combine(myPath, "Math_Dictionary.txt")));
                myReadingEducators = new JavaScriptSerializer()
                    .Deserialize<Dictionary<int, Service.ReadingEducator>>(File.ReadAllText(Path.Combine(myPath, "Reading_Dictionary.txt")));
                myWritingEducators = new JavaScriptSerializer()
                    .Deserialize<Dictionary<int, Service.WritingEducator>>(File.ReadAllText(Path.Combine(myPath, "Writing_Dictionary.txt")));
                myDonationRequests = new JavaScriptSerializer()
                    .Deserialize<Dictionary<int, Service.DonationRequest>>(File.ReadAllText(Path.Combine(myPath, "Donation_Dictionary.txt")));
                myDriverRequests = new JavaScriptSerializer()
                    .Deserialize<Dictionary<int, Service.DriverRequest>>(File.ReadAllText(Path.Combine(myPath, "Driver_Dictionary.txt")));
                myEducatorRequests = new JavaScriptSerializer()
                    .Deserialize<Dictionary<int, Service.EducatorRequest>>(File.ReadAllText(Path.Combine(myPath, "Educator_Dictionary.txt")));
            }
        }

        private void createFilePath()
        {
            myPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            myResourcePath = Path.Combine(myPath, "Resources");
            myFileName = Path.Combine(myPath, "serial_list.txt");
        }

        private void readSerialNumbers()
        {
            mySerialNumbers = new JavaScriptSerializer()
                    .Deserialize<Dictionary<string, string>>(File.ReadAllText(Path.Combine(myFileName)));
        }

        private void createFiles()
        {

        }

    } 
}
