using System;
using MiddleOut;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

/// <summary>
/// Test class for Dijkstra's Algorithm class. 
/// @Author Charlton Smith and Karanbir 
/// </summary>
namespace MiddleOutTestProject
{
    [TestClass]
    public class DijkstraAlgTest
    {
        List<Location> myLocations = new List<Location>();
        List<Street> myStreets = new List<Street>();

        [TestMethod]
        public void Dijkstra_Alg_Test()
        {
            myLocations.Add(new Location(225, 475)); // Westbrook Garrison 0
            myLocations.Add(new Location(315, 560)); // Stonefield Farm    1
            myLocations.Add(new Location(315, 300)); // Stormwind Gates    2
            myLocations.Add(new Location(400, 412)); // Goldshire          3
            myLocations.Add(new Location(635, 450)); // Tower of Azora     4
            myLocations.Add(new Location(400, 570)); // Maclure Vineyards  5

            addStreet(myLocations[4], myLocations[3]); // 0
            addStreet(myLocations[1], myLocations[3]); // 1
            addStreet(myLocations[1], myLocations[5]); // 2
            addStreet(myLocations[1], myLocations[0]); // 3
            addStreet(myLocations[0], myLocations[3]); // 4
            addStreet(myLocations[2], myLocations[3]); // 5
            
            DijkstraAlg dAlg = new DijkstraAlg(myLocations, myStreets);

            //@Author Karanbir 
            // Westbrook Garrison to Stonefield farm. 
            List<Street> testStreet = new List<Street>();
            testStreet.Add(myStreets[3]); 
            List<Street> dAlgStreet = dAlg.Dijkstra(myLocations[1], myLocations[0]);
            Console.WriteLine(dAlg.output.Count + "    " + testStreet.Count);
            Assert.IsTrue(dAlgStreet.Count == testStreet.Count);
            for (int i = 0; i < testStreet.Count; i++)
            {
                Assert.AreEqual(testStreet[i], dAlgStreet[i]);
            }

            //@Author Karanbir 
            // Maclure Vineyards to Westbrook Garrison
            testStreet = new List<Street>();
            testStreet.Add(myStreets[3]);
            testStreet.Add(myStreets[2]);
            dAlgStreet = dAlg.Dijkstra(myLocations[5], myLocations[0]);
            Console.WriteLine(dAlg.output.Count + "    " + testStreet.Count);
            Assert.IsTrue(dAlgStreet.Count == testStreet.Count);
            for (int i = 0; i < testStreet.Count; i++)
            {
                Assert.AreEqual(testStreet[i], dAlgStreet[i]);
            }

            //@Author Karanbir 
            // Stormwind Gates to Maclure Vineyards
            testStreet = new List<Street>();
            testStreet.Add(myStreets[2]);
            testStreet.Add(myStreets[1]);
            testStreet.Add(myStreets[5]);
            dAlgStreet = dAlg.Dijkstra(myLocations[2], myLocations[5]);
            Console.WriteLine(dAlg.output.Count + "    " + testStreet.Count);
            Assert.IsTrue(dAlgStreet.Count == testStreet.Count);
            for (int i = 0; i < testStreet.Count; i++)
            {
                Assert.AreEqual(testStreet[i], dAlgStreet[i]);
            }

            //@Author Karanbir 
            // Westbrook Garrison to Goldshire
            testStreet = new List<Street>();
            testStreet.Add(myStreets[4]);
            dAlgStreet = dAlg.Dijkstra(myLocations[0], myLocations[3]);
            Console.WriteLine(dAlg.output.Count + "    " + testStreet.Count);
            Assert.IsTrue(dAlgStreet.Count == testStreet.Count);
            for (int i = 0; i < testStreet.Count; i++)
            {
                Assert.AreEqual(testStreet[i], dAlgStreet[i]);
            }

            //@Author Karanbir 
            // Goldshire to Maclure Vineyards
            testStreet = new List<Street>();
            testStreet.Add(myStreets[2]);
            testStreet.Add(myStreets[1]);
            dAlgStreet = dAlg.Dijkstra(myLocations[3], myLocations[5]);
            Console.WriteLine(dAlg.output.Count + "    " + testStreet.Count);
            Assert.IsTrue(dAlgStreet.Count == testStreet.Count);
            for (int i = 0; i < testStreet.Count; i++)
            {
                Assert.AreEqual(testStreet[i], dAlgStreet[i]);
            }

            //@Author Charlton Smith 
            // Stonefield Farm to Tower of Azora
            testStreet = new List<Street>();
            testStreet.Add(myStreets[0]);
            testStreet.Add(myStreets[1]);
            dAlgStreet = dAlg.Dijkstra(myLocations[1], myLocations[4]);
            Console.WriteLine(dAlg.output.Count + "    " + testStreet.Count);
            Assert.IsTrue(dAlgStreet.Count == testStreet.Count);
            for (int i = 0; i < testStreet.Count; i++)
            {
                Assert.AreEqual(testStreet[i], dAlgStreet[i]);
            }

            //@Author Charlton Smith 
            // Maclure Vineyards to Tower of Azora
            testStreet = new List<Street>();
            testStreet.Add(myStreets[0]);
            testStreet.Add(myStreets[1]);
            testStreet.Add(myStreets[2]);
            dAlgStreet = dAlg.Dijkstra(myLocations[5], myLocations[4]);
            Console.WriteLine(dAlg.output.Count + "    " + testStreet.Count);
            Assert.IsTrue(dAlgStreet.Count == testStreet.Count);
            for (int i = 0; i < testStreet.Count; i++)
            {
                Assert.AreEqual(testStreet[i], dAlgStreet[i]);
            }

            //@Author Charlton Smith 
            // Westbrook Garrison to Tower of Azora
            testStreet = new List<Street>();
            testStreet.Add(myStreets[0]);
            testStreet.Add(myStreets[4]);
            dAlgStreet = dAlg.Dijkstra(myLocations[0], myLocations[4]);
            Console.WriteLine(dAlg.output.Count + "    " + testStreet.Count);
            Assert.IsTrue(dAlgStreet.Count == testStreet.Count);
            for (int i = 0; i < testStreet.Count; i++)
            {
                Assert.AreEqual(testStreet[i], dAlgStreet[i]);
            }

            //@Author Charlton Smith 
            // StormWind Gates to Tower of Azora 2 to 4
            testStreet = new List<Street>();
            testStreet.Add(myStreets[0]);
            testStreet.Add(myStreets[5]);
            dAlgStreet = dAlg.Dijkstra(myLocations[2], myLocations[4]);
            Console.WriteLine(dAlg.output.Count + "    " + testStreet.Count);
            Assert.IsTrue(dAlgStreet.Count == testStreet.Count);
            for (int i = 0; i < testStreet.Count; i++)
            {
                Assert.AreEqual(testStreet[i], dAlgStreet[i]);
            }

            //@Author Charlton Smith 
            // GoldShire to Tower of Azora 3 to 4
            testStreet = new List<Street>();
            testStreet.Add(myStreets[0]);
            dAlgStreet = dAlg.Dijkstra(myLocations[3], myLocations[4]);
            Console.WriteLine(dAlg.output.Count + "    " + testStreet.Count);
            Assert.IsTrue(dAlgStreet.Count == testStreet.Count);
            for (int i = 0; i < testStreet.Count; i++)
            {
                Assert.AreEqual(testStreet[i], dAlgStreet[i]);
            }

        }

        public void addStreet(Location loc1, Location loc2)
        {
            myStreets.Add(new Street((int)Math.Sqrt(Math.Pow(loc1.myX - loc2.myX, 2) +
                Math.Pow(loc1.myY - loc2.myY, 2)), loc1, loc2));
        }
    }
}
