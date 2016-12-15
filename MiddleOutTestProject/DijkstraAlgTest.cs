using System;
using MiddleOut;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
            myLocations.Add(new Location(225, 475)); // Westbrook Garrison
            myLocations.Add(new Location(315, 560)); // Stonefield Farm
            myLocations.Add(new Location(315, 300)); // Stormwind Gates
            myLocations.Add(new Location(400, 412)); // Goldshire
            myLocations.Add(new Location(635, 450)); // Tower of Azora
            myLocations.Add(new Location(400, 570)); // Maclure Vineyards

            addStreet(myLocations[4], myLocations[3]);
            addStreet(myLocations[1], myLocations[3]);
            addStreet(myLocations[1], myLocations[5]);
            addStreet(myLocations[1], myLocations[0]);
            addStreet(myLocations[0], myLocations[3]);
            addStreet(myLocations[2], myLocations[3]);

            Console.WriteLine("test started");
            DijkstraAlg dAlg = new DijkstraAlg(myLocations, myStreets);
            
            List<Street> testStreet = new List<Street>();
            testStreet.Add(myStreets[3]); // Westbrook Garrison to Stonefield farm. 
            List<Street> dAlgStreet = dAlg.Dijkstra(myLocations[1], myLocations[0]);
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
