using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            myFilePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            myFilePath = Directory.GetParent(Directory.GetParent(myFilePath).FullName).FullName;
            myFilePath += @"\service.txt";

            foreach (string line in File.ReadLines(myFilePath))
            {
                string[] elements = line.Split(split, StringSplitOptions.None);
                addToDictionary(elements);
            }
        }

        public void add(int theID, Service.ToyDonor theService)
        {
            myToys.Add(theID, theService);
            writeFile(theService);
        }

        public void add(int theID, Service.ClothesDonor theService)
        {
            myClothes.Add(theID, theService);
            writeFile(theService);
        }

        public void add(int theID, Service.TechDonor theService)
        {
            myTech.Add(theID, theService);
            writeFile(theService);
        }

        public void add(int theID, Service.FirstAidDonor theService)
        {
            myFirstAid.Add(theID, theService);
            writeFile(theService);
        }

        public void add(int theID, Service.HygeneDonor theService)
        {
            myHygene.Add(theID, theService);
            writeFile(theService);
        }

        public void add(int theID, Service.ToolsDonor theService)
        {
            myTools.Add(theID, theService);
            writeFile(theService);
        }

        public void add(int theID, Service.OtherDonor theService)
        {
            myOthers.Add(theID, theService);
            writeFile(theService);
        }

        public void add(int theID, Service.PersonDriver theService)
        {
            myPersonDrivers.Add(theID, theService);
            writeFile(theService);
        }

        public void add(int theID, Service.GoodsDriver theService)
        {
            myGoodsDrivers.Add(theID, theService);
            writeFile(theService);
        }

        public void add(int theID, Service.MathEducator theService)
        {
            myMathEducators.Add(theID, theService);
            writeFile(theService);
        }

        public void add(int theID, Service.ReadingEducator theService)
        {
            myReadingEducators.Add(theID, theService);
            writeFile(theService);
        }

        public void add(int theID, Service.WritingEducator theService)
        {
            myWritingEducators.Add(theID, theService);
            writeFile(theService);
        }

        public void addToDictionary(string[] theElements)
        {
            char[] serviceID = theElements[0].ToCharArray();
            int sID = Int32.Parse(theElements[0]);
            int uID = Int32.Parse(theElements[1]);
            string desc = theElements[2];
            Boolean comp = Convert.ToBoolean(theElements[3]);
            Boolean select = Convert.ToBoolean(theElements[4]);
            switch (serviceID[0])
            {
                case '0':
                    switch (serviceID[1])
                    {
                        case '0':
                            Service.ToyDonor toyDonor = new Service.ToyDonor(sID, uID);
                            myToys.Add(sID, toyDonor);
                            break;
                        case '1':
                            Service.ClothesDonor clothesDonor = new Service.ClothesDonor(sID, uID);
                            myClothes.Add(sID, clothesDonor);
                            break;
                        case '2':
                            Service.TechDonor techDonor = new Service.TechDonor(sID, uID);
                            myTech.Add(sID, techDonor);
                            break;
                        case '3':
                            Service.FirstAidDonor faDonor = new Service.FirstAidDonor(sID, uID);
                            myFirstAid.Add(sID, faDonor);
                            break;
                        case '4':
                            Service.HygeneDonor hygeneDonor = new Service.HygeneDonor(sID, uID);
                            myHygene.Add(sID, hygeneDonor);
                            break;
                        case '5':
                            Service.FoodDonor foodDonor = new Service.FoodDonor(sID, uID);
                            myFood.Add(sID, foodDonor);
                            break;
                        case '6':
                            Service.ToolsDonor toolDonor = new Service.ToolsDonor(sID, uID);
                            myTools.Add(sID, toolDonor);
                            break;
                        case '7':
                            Service.OtherDonor otherDonor = new Service.OtherDonor(sID, uID);
                            myOthers.Add(sID, otherDonor);
                            break;
                    }
                    break;
                case '1':
                    string start = theElements[5];
                    string stop = theElements[6];
                    string locX = theElements[7];
                    string locY = theElements[8];
                    switch (serviceID[1])
                    {
                        case '0':
                            Service.PersonDriver pDriver = new Service.PersonDriver(sID, uID);
                            myPersonDrivers.Add(sID, pDriver);
                            break;
                        case '1':
                            Service.GoodsDriver gDriver = new Service.GoodsDriver(sID, uID);
                            myGoodsDrivers.Add(sID, gDriver);
                            break;
                    }
                    break;
                case '2':
                    string start2 = theElements[5];
                    string stop2 = theElements[6];
                    string locX2 = theElements[7];
                    string locY2 = theElements[8];
                    switch (serviceID[1])
                    {
                        case '0':
                            Service.MathEducator mEducator = new Service.MathEducator(sID, uID);
                            myMathEducators.Add(sID, mEducator);
                            break;
                        case '1':
                            Service.ReadingEducator rEducator = new Service.ReadingEducator(sID, uID);
                            myReadingEducators.Add(sID, rEducator);
                            break;
                        case '2':
                            Service.WritingEducator wEducator = new Service.WritingEducator(sID, uID);
                            myWritingEducators.Add(sID, wEducator);
                            break;
                    }
                    break;
                case '3':
                    switch (serviceID[1])
                    {
                        case '1':
                            Service.DonationRequest doRequest = new Service.DonationRequest(sID, uID);
                            myDonationRequests.Add(sID, doRequest);
                            break;
                        case '2':
                            Service.DriverRequest drRequest = new Service.DriverRequest(sID, uID);
                            myDriverRequests.Add(sID, drRequest);
                            break;
                        case '3':
                            Service.EducatorRequest eRequest = new Service.EducatorRequest(sID, uID);
                            myEducatorRequests.Add(sID, eRequest);
                            break;
                    }
                    break;
            }
        }

        public void writeFile(Service theService)
        {
            File.AppendAllText(myFilePath, theService.ToString() + Environment.NewLine);
        }
    }
}
