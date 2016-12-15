using System;
using MiddleOut;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MiddleOutTestProject
{
    [TestClass]
    public class DijkstraAlgTest
    {
        [TestMethod]
        public void Dijkstra_Alg_Test()
        {
            
            Console.WriteLine("test started");
            MapPage map = new MapPage();
            DijkstraAlg dAlg = new DijkstraAlg(map.myLocations, map.myStreets);
            /*
            List<Street> testStreet = new List<Street>();
            testStreet.Add(addStreet(map.myLocations[1], map.myLocations[0])); // Westbrook Garrison to Stonefield farm. 
            List<Street> dAlgStreet = dAlg.Dijkstra(map.myLocations[0], map.myLocations[1]);
            Console.WriteLine(dAlgStreet.Count + "    " + testStreet.Count);
            Assert.IsTrue(dAlgStreet.Count == testStreet.Count);
            */
        }

        public Street addStreet(Location loc1, Location loc2)
        {
            Street temp = new Street((int)Math.Sqrt(Math.Pow(loc1.myX - loc2.myX, 2) +
                Math.Pow(loc1.myY - loc2.myY, 2)), loc1, loc2);
            return temp;
        }
    }
}
