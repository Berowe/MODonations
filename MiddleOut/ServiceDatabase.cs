using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Web.Script.Serialization;

namespace MiddleOut
{
    class ServiceDatabase
    {

        private Dictionary<String, Service> myToys;
        private Dictionary<String, Service> myClothes;
        [JsonExtensionData]
        private Dictionary<String, Service> myTech;
        private Dictionary<String, Service> myFirstAid;
        private Dictionary<String, Service> myHygene;
        private Dictionary<String, Service> myTools;
        private Dictionary<String, Service> myFood;
        private Dictionary<String, Service> myOthers;
        private Dictionary<String, Service> myPersonDrivers;
        private Dictionary<String, Service> myGoodsDrivers;
        private Dictionary<String, Service> myMathEducators;
        private Dictionary<String, Service> myReadingEducators;
        private Dictionary<String, Service> myWritingEducators;
        private Dictionary<String, Service> myDonationRequests;
        private Dictionary<String, Service> myDriverRequests;
        private Dictionary<String, Service> myEducatorRequests;
        private Dictionary<String, String> mySerialNumbers;
        private String myPath;
        private String myResourcePath;
        private String myFileName;
        private String[] myStrings = new string[] {"toy_serial", "clothes_serial", "tech_serial", "first_aid_serial",
        "hygene_serial", "tools_serial", "food_serial", "other_serial", "person_serial", "goods_serial", "math_serial",
        "reading_serial", "writing_serial", "donation_serial", "driver_serial", "educator_serial"};
        private String[] myDictionaryFileStrings = new string[] {
                    "Toy_Dictionary.txt", "Clothes_Dictionary.txt", "Tech_Dictionary.txt", "FirstAid_Dictionary.txt", "Hygene_Dictionary.txt",
                    "Tools_Dictionary.txt", "Food_Dictionary.txt", "Other_Dictionary.txt", "Person_Dictionary.txt", "Goods_Dictionary.txt",
                    "Math_Dictionary.txt", "Reading_Dictionary.txt", "Writing_Dictionary.txt", "Donation_Dictionary.txt",
                    "Driver_Dictionary.txt", "Educator_Dictionary.txt"};

        public ServiceDatabase()
        {
            createFilePath();
            initializeDictionaries();
            readSerialNumbers();
        }

        public void createService(ServiceTypes sType, DonationTypes dType, User theUser, Service theService)
        {
            String serial;
            switch (sType)
            {
                case ServiceTypes.Donor:
                    switch (dType)
                    {
                        case DonationTypes.Toys:
                            theService.setServiceID(createServiceID(dType));
                            myToys.Add(theService.getServiceID(), theService);
                            serial = serializeDictionary(myToys);
                            writeFile(myDictionaryFileStrings[0], serial);
                            break;
                        case DonationTypes.Clothes:
                            theService.setServiceID(createServiceID(dType));
                            myClothes.Add(theService.getServiceID(), theService);
                            serial = serializeDictionary(myClothes);
                            writeFile(myDictionaryFileStrings[1], serial);
                            break;
                        case DonationTypes.Tech:
                            Console.WriteLine(myTech.Count + "++++++++++++");
                            theService.setServiceID(createServiceID(dType));
                            myTech.Add(theService.getServiceID(), theService);
                            serial = serializeDictionary(myTech);
                            writeFile(myDictionaryFileStrings[2], serial);
                            break;
                        case DonationTypes.FirstAid:
                            theService.setServiceID(createServiceID(dType));
                            myFirstAid.Add(theService.getServiceID(), theService);
                            serial = serializeDictionary(myFirstAid);
                            writeFile(myDictionaryFileStrings[3], serial);
                            break;
                        case DonationTypes.Food:
                            theService.setServiceID(createServiceID(dType));
                            myFood.Add(theService.getServiceID(), theService);
                            serial = serializeDictionary(myFood);
                            writeFile(myDictionaryFileStrings[4], serial);
                            break;
                        case DonationTypes.Hygene:
                            theService.setServiceID(createServiceID(dType));
                            myHygene.Add(theService.getServiceID(), theService);
                            serial = serializeDictionary(myHygene);
                            writeFile(myDictionaryFileStrings[5], serial);
                            break;
                        case DonationTypes.Tools:
                            theService.setServiceID(createServiceID(dType));
                            myTools.Add(theService.getServiceID(), theService);
                            serial = serializeDictionary(myTools);
                            writeFile(myDictionaryFileStrings[6], serial);
                            break;
                        case DonationTypes.Other:
                            theService.setServiceID(createServiceID(dType));
                            myOthers.Add(theService.getServiceID(), theService);
                            serial = serializeDictionary(myOthers);
                            writeFile(myDictionaryFileStrings[7], serial);
                            break;
                    }
                    break;
                case ServiceTypes.Driver:
                    switch (dType)
                    {
                        case DonationTypes.TransportGoods:
                            theService.setServiceID(createServiceID(dType));
                            myGoodsDrivers.Add(theService.getServiceID(), theService);
                            serial = serializeDictionary(myGoodsDrivers);
                            writeFile(myDictionaryFileStrings[9], serial);
                            break;
                        case DonationTypes.TransportPerson:
                            theService.setServiceID(createServiceID(dType));
                            myPersonDrivers.Add(theService.getServiceID(), theService);
                            serial = serializeDictionary(myPersonDrivers);
                            writeFile(myDictionaryFileStrings[8], serial);
                            break;
                    }
                    break;
                case ServiceTypes.Educator:
                    switch (dType)
                    {
                        case DonationTypes.MathEducator:
                            theService.setServiceID(createServiceID(dType));
                            myMathEducators.Add(theService.getServiceID(), theService);
                            serial = serializeDictionary(myMathEducators);
                            writeFile(myDictionaryFileStrings[10], serial);
                            break;
                        case DonationTypes.WritingEducator:
                            theService.setServiceID(createServiceID(dType));
                            myWritingEducators.Add(theService.getServiceID(), theService);
                            serial = serializeDictionary(myWritingEducators);
                            writeFile(myDictionaryFileStrings[12], serial);
                            break;
                        case DonationTypes.ReadingEducator:
                            theService.setServiceID(createServiceID(dType));
                            myReadingEducators.Add(theService.getServiceID(), theService);
                            serial = serializeDictionary(myReadingEducators);
                            writeFile(myDictionaryFileStrings[11], serial);
                            break;
                    }
                    break;
                case ServiceTypes.Requester:
                    switch (dType)
                    {
                        case DonationTypes.DonationRequest:
                            theService.setServiceID(createServiceID(dType));
                            myDonationRequests.Add(theService.getServiceID(), theService);
                            serial = serializeDictionary(myDonationRequests);
                            writeFile(myDictionaryFileStrings[13], serial);
                            break;
                        case DonationTypes.DriverRequest:
                            theService.setServiceID(createServiceID(dType));
                            myDriverRequests.Add(theService.getServiceID(), theService);
                            serial = serializeDictionary(myDriverRequests);
                            writeFile(myDictionaryFileStrings[14], serial);
                            break;
                        case DonationTypes.EducatorRequest:
                            theService.setServiceID(createServiceID(dType));
                            myEducatorRequests.Add(theService.getServiceID(), theService);
                            serial = serializeDictionary(myEducatorRequests);
                            writeFile(myDictionaryFileStrings[15], serial);
                            break;
                    }
                    break;
            }
        }

        private string serializeDictionary(Dictionary<String, Service> theDictionary)
        {

            string serial = JsonConvert.SerializeObject(theDictionary, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple
            });

            return serial;
        }

        private void writeFile(String fileName, String serialization)
        {
            File.WriteAllText(fileName, serialization);
        }

        private void initializeDictionaries()
        {
            myToys = new Dictionary<String, Service>();
            myClothes = new Dictionary<String, Service>();
            myTech = new Dictionary<String, Service>();
            myFirstAid = new Dictionary<String, Service>();
            myHygene = new Dictionary<String, Service>();
            myTools = new Dictionary<String, Service>();
            myFood = new Dictionary<String, Service>();
            myOthers = new Dictionary<String, Service>();
            myPersonDrivers = new Dictionary<String, Service>();
            myGoodsDrivers = new Dictionary<String, Service>();
            myMathEducators = new Dictionary<String, Service>();
            myReadingEducators = new Dictionary<String, Service>();
            myWritingEducators = new Dictionary<String, Service>();
            myDonationRequests = new Dictionary<String, Service>();
            myDriverRequests = new Dictionary<String, Service>();
            myEducatorRequests = new Dictionary<String, Service>();
            mySerialNumbers = new Dictionary<string, string>();

            if (!File.Exists(myFileName))
            {

                for (int i = 0; i < myStrings.Length; i++)
                {
                    mySerialNumbers.Add(myStrings[i], "10000");
                }

                createFiles();
            }
            else
            {
                pullDictionary(myDictionaryFileStrings[0], 1);
                pullDictionary(myDictionaryFileStrings[1], 2);
                pullDictionary(myDictionaryFileStrings[2], 3);
                pullDictionary(myDictionaryFileStrings[3], 4);
                pullDictionary(myDictionaryFileStrings[4], 5);
                pullDictionary(myDictionaryFileStrings[5], 6);
                pullDictionary(myDictionaryFileStrings[6], 7);
                pullDictionary(myDictionaryFileStrings[7], 8);
                pullDictionary(myDictionaryFileStrings[8], 9);
                pullDictionary(myDictionaryFileStrings[9], 10);
                pullDictionary(myDictionaryFileStrings[10], 11);
                pullDictionary(myDictionaryFileStrings[11], 12);
                pullDictionary(myDictionaryFileStrings[12], 13);
                pullDictionary(myDictionaryFileStrings[13], 14);
                pullDictionary(myDictionaryFileStrings[14], 15);
                pullDictionary(myDictionaryFileStrings[15], 16);
            }
        }

        private void pullDictionary(String filePath, int theDictionary)
        {
            if (File.Exists(filePath))
            {
                String deSerial = File.ReadAllText(filePath);
                deSerializeDictionary(deSerial, theDictionary);
            }
        }

        private void deSerializeDictionary(String theSerial, int theDictionary)
        {
            object dictionary = JsonConvert.DeserializeObject(theSerial, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple
            });
            switch (theDictionary)
            {
                case 1:
                    myToys = (Dictionary<String, Service>)dictionary;
                    break;
                case 2:
                    myClothes = (Dictionary<String, Service>)dictionary;
                    break;
                case 3:
                    myTech = (Dictionary<String, Service>)dictionary;
                    break;
                case 4:
                    myFirstAid = (Dictionary<String, Service>)dictionary;
                    break;
                case 5:
                    myHygene = (Dictionary<String, Service>)dictionary;
                    break;
                case 6:
                    myTools = (Dictionary<String, Service>)dictionary;
                    break;
                case 7:
                    myFood = (Dictionary<String, Service>)dictionary;
                    break;
                case 8:
                    myOthers = (Dictionary<String, Service>)dictionary;
                    break;
                case 9:
                    myPersonDrivers = (Dictionary<String, Service>)dictionary;
                    break;
                case 10:
                    myGoodsDrivers = (Dictionary<String, Service>)dictionary;
                    break;
                case 11:
                    myMathEducators = (Dictionary<String, Service>)dictionary;
                    break;
                case 12:
                    myReadingEducators = (Dictionary<String, Service>)dictionary;
                    break;
                case 13:
                    myWritingEducators = (Dictionary<String, Service>)dictionary;
                    break;
                case 14:
                    myDonationRequests = (Dictionary<String, Service>)dictionary;
                    break;
                case 15:
                    myDriverRequests = (Dictionary<String, Service>)dictionary;
                    break;
                case 16:
                    myEducatorRequests = (Dictionary<String, Service>)dictionary;
                    break;
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
                    .Deserialize<Dictionary<string, string>>(File.ReadAllText(myFileName));
        }

        private void saveSerialNumbers()
        {
            File.Delete(myFileName);
            File.WriteAllText(myFileName, new JavaScriptSerializer().Serialize(mySerialNumbers));
        }

        private void createFiles()
        {

            File.WriteAllText(myFileName, new JavaScriptSerializer().Serialize(mySerialNumbers));
        }

        private String createServiceID(DonationTypes theType)
        {
            StringBuilder builder = new StringBuilder();
            switch (theType)
            {
                case DonationTypes.Toys:
                    builder.Append("11");
                    builder.Append(mySerialNumbers[myStrings[0]]);
                    updateSerial(myStrings[0]);
                    break;
                case DonationTypes.Clothes:
                    builder.Append("12");
                    builder.Append(mySerialNumbers[myStrings[1]]);
                    updateSerial(myStrings[1]);
                    break;
                case DonationTypes.Tech:
                    builder.Append("13");
                    builder.Append(mySerialNumbers[myStrings[2]]);
                    updateSerial(myStrings[2]);
                    break;
                case DonationTypes.FirstAid:
                    builder.Append("14");
                    builder.Append(mySerialNumbers[myStrings[3]]);
                    updateSerial(myStrings[3]);
                    break;
                case DonationTypes.Hygene:
                    builder.Append("15");
                    builder.Append(mySerialNumbers[myStrings[4]]);
                    updateSerial(myStrings[4]);
                    break;
                case DonationTypes.Food:
                    builder.Append("16");
                    builder.Append(mySerialNumbers[myStrings[5]]);
                    updateSerial(myStrings[5]);
                    break;
                case DonationTypes.Tools:
                    builder.Append("17");
                    builder.Append(mySerialNumbers[myStrings[6]]);
                    updateSerial(myStrings[6]);
                    break;
                case DonationTypes.Other:
                    builder.Append("18");
                    builder.Append(mySerialNumbers[myStrings[7]]);
                    updateSerial(myStrings[7]);
                    break;
                case DonationTypes.TransportPerson:
                    builder.Append("21");
                    builder.Append(mySerialNumbers[myStrings[8]]);
                    updateSerial(myStrings[8]);
                    break;
                case DonationTypes.TransportGoods:
                    builder.Append("22");
                    builder.Append(mySerialNumbers[myStrings[9]]);
                    updateSerial(myStrings[9]);
                    break;
                case DonationTypes.MathEducator:
                    builder.Append("31");
                    builder.Append(mySerialNumbers[myStrings[10]]);
                    updateSerial(myStrings[10]);
                    break;
                case DonationTypes.ReadingEducator:
                    builder.Append("32");
                    builder.Append(mySerialNumbers[myStrings[11]]);
                    updateSerial(myStrings[11]);
                    break;
                case DonationTypes.WritingEducator:
                    builder.Append("33");
                    builder.Append(mySerialNumbers[myStrings[12]]);
                    updateSerial(myStrings[12]);
                    break;
                case DonationTypes.DonationRequest:
                    builder.Append("41");
                    builder.Append(mySerialNumbers[myStrings[13]]);
                    updateSerial(myStrings[13]);
                    break;
                case DonationTypes.DriverRequest:
                    builder.Append("42");
                    builder.Append(mySerialNumbers[myStrings[14]]);
                    updateSerial(myStrings[14]);
                    break;
                case DonationTypes.EducatorRequest:
                    builder.Append("43");
                    builder.Append(mySerialNumbers[myStrings[15]]);
                    updateSerial(myStrings[15]);
                    break;
            }
            return builder.ToString();
        }

        private void updateSerial(String theType)
        {
            int serial = Convert.ToInt32(mySerialNumbers[theType]);
            serial -= 10000;
            serial += 1;
            serial += 10000;

            mySerialNumbers[theType] = Convert.ToString(serial);
            File.WriteAllText(myFileName, new JavaScriptSerializer().Serialize(mySerialNumbers));
        }

        public String printServices(ServiceTypes sType)
        {
            String print = "";
            switch (sType)
            {
                case ServiceTypes.Donor:

                    break;

            }
            return print;
        }

        public String printServices(ServiceTypes sType, DonationTypes dType)
        {
            String print = "";
            switch (sType)
            {
                case ServiceTypes.Donor:
                    switch (dType)
                    {
                        case DonationTypes.Toys:
                            print = getServices(myToys);
                            break;
                        case DonationTypes.Clothes:
                            print = getServices(myClothes);
                            break;
                        case DonationTypes.Tech:
                            print = getServices(myTech);
                            break;
                        case DonationTypes.FirstAid:
                            print = getServices(myFirstAid);
                            break;
                        case DonationTypes.Food:
                            print = getServices(myFood);
                            break;
                        case DonationTypes.Hygene:
                            print = getServices(myHygene);
                            break;
                        case DonationTypes.Tools:
                            print = getServices(myTools);
                            break;
                        case DonationTypes.Other:
                            print = getServices(myOthers);
                            break;
                    }
                    break;
                case ServiceTypes.Driver:
                    switch (dType)
                    {
                        case DonationTypes.TransportGoods:
                            print = getServices(myGoodsDrivers);
                            break;
                        case DonationTypes.TransportPerson:
                            print = getServices(myPersonDrivers);
                            break;
                    }
                    break;
                case ServiceTypes.Educator:
                    switch (dType)
                    {
                        case DonationTypes.MathEducator:
                            print = getServices(myMathEducators);
                            break;
                        case DonationTypes.WritingEducator:
                            print = getServices(myWritingEducators);
                            break;
                        case DonationTypes.ReadingEducator:
                            print = getServices(myReadingEducators);
                            break;
                    }
                    break;
                case ServiceTypes.Requester:
                    switch (dType)
                    {
                        case DonationTypes.DonationRequest:
                            print = getServices(myDonationRequests);
                            break;
                        case DonationTypes.DriverRequest:
                            print = getServices(myDriverRequests);
                            break;
                        case DonationTypes.EducatorRequest:
                            print = getServices(myEducatorRequests);
                            break;
                    }
                    break;
            }
            return print;
        }

        private String getServices(Dictionary<String, Service> theDictionary)
        {
            StringBuilder builder = new StringBuilder();
            foreach (KeyValuePair<String, Service> entry in myTech)
            {
                builder.Append(entry.Value.getServiceID() + "\n");
            }
            return builder.ToString();
        }
    }

}