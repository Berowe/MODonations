using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiddleOut
{
    /// <summary>
    /// Interaction logic for MapPage.xaml
    /// @Author Karanbir
    /// </summary>
    public partial class MapPage : UserControl
    {
        private List<Location> myLocations;
        private List<Street> myStreets;

        /// <summary>
        /// Initialize the MapPage with dummy locations and streets. 
        /// @Author Karanbir 
        /// </summary>
        public MapPage()
        {
            InitializeComponent();
            myLocations = new List<Location>();
            myLocations.Add(new Location(10, 10));
            myLocations.Add(new Location(100, 50));
            myLocations.Add(new Location(87, 45));
            myLocations.Add(new Location(92, 143));
            myLocations.Add(new Location(300, 98));
            myLocations.Add(new Location(156, 186));

            myStreets = new List<Street>();
            myStreets.Add(new Street(10, myLocations[0], myLocations[1]));
            myStreets.Add(new Street(5, myLocations[2], myLocations[3]));
            myStreets.Add(new Street(4, myLocations[1], myLocations[3]));
            myStreets.Add(new Street(7, myLocations[1], myLocations[2]));

            List<Street> deleteMe = Dijkstra(myLocations[0], myLocations[3]);
            Console.WriteLine("Test complete");
        }

        /// <summary>
        /// Finds the shortest path between two locations! AWESOME!
        /// @Author Karanbir 
        /// </summary>
        /// <param name="theStart">The beginning location.</param>
        /// <param name="theEnd">The ending location.</param>
        /// <returns>A list of streets to draw for the shortest path.</returns>
        public List<Street> Dijkstra(Location theStart, Location theEnd)
        {
            List<Street> shortestPath = new List<Street>();
            Dictionary<Location, int> buildPaths = new Dictionary<Location, int>();
            Dictionary<Location, Location> previousSave = new Dictionary<Location, Location>();
            List<Location> unvisited = new List<Location>();

            buildPaths.Add(theStart, 0); // 0 for start point 

            // Initialize 
            foreach (Location loc in myLocations)
            {
                if (!loc.Equals(theStart))
                {
                    buildPaths.Add(loc, -1); // -1 means infinity
                    
                }
                unvisited.Add(loc);

            }

            while (unvisited.Count != 0)
            {
                Location currentLoc = findMin(buildPaths, unvisited);
                unvisited.Remove(currentLoc);
                if (currentLoc.Equals(theEnd))
                {
                    break; 
                }

                List<Location> neighbors = getNeighbors(currentLoc);
                foreach (Location loc in neighbors)
                {
                    int currentLocInt;
                    int neighborInt;
                    if (findStreet(currentLoc, loc) != null)
                    {
                        int alternativeInt = findStreet(currentLoc, loc).myWeight;
                        buildPaths.TryGetValue(currentLoc, out currentLocInt);
                        buildPaths.TryGetValue(loc, out neighborInt);
                        if ((neighborInt < 0) || ((alternativeInt + currentLocInt) < neighborInt))
                        {
                            if (buildPaths.ContainsKey(loc))
                            {
                                buildPaths.Remove(loc);
                            }
                            if (previousSave.ContainsKey(loc))
                            {
                                previousSave.Remove(loc);
                            }
                            buildPaths.Add(loc, (alternativeInt + currentLocInt));
                            previousSave.Add(loc, currentLoc);
                        }
                    }
                }
            }
            Location retrackLoc;
            Location firstLoc = theEnd;
            while (previousSave.TryGetValue(firstLoc, out retrackLoc))
            {
                shortestPath.Add(findStreet(retrackLoc, firstLoc));
                firstLoc = retrackLoc;
            }
            return shortestPath;
        }

        /// <summary>
        /// Finds the street based on two locations. 
        /// </summary>
        /// <param name="theA">The first location.</param>
        /// <param name="theB">The second location.</param>
        /// <returns>The street that links these two locations, otherwise null.</returns>
        public Street findStreet(Location theA, Location theB)
        {
            foreach (Street st in myStreets)
            {
                if ((st.myA.Equals(theA) || st.myB.Equals(theA)) && 
                    (st.myA.Equals(theB) || st.myB.Equals(theB))) {
                    return st;
                }
            }
            return null;
        }

        public Location findMin (Dictionary<Location, int> theDic, List<Location> theUnvisited)
        {
            Location toReturn = null;
            foreach (Location loc in theDic.Keys)
            {
                if (toReturn == null && theUnvisited.Contains(loc))
                {
                    toReturn = loc;
                } else if (theUnvisited.Contains(loc))
                {
                    int newLocInt;
                    int toReturnInt;
                    theDic.TryGetValue(loc, out newLocInt);
                    theDic.TryGetValue(toReturn, out toReturnInt);
                    if (newLocInt < toReturnInt && newLocInt >= 0 && theUnvisited.Contains(loc))
                    {
                        toReturn = loc;
                    }
                }
            }

            theUnvisited.Remove(toReturn);
            return toReturn;
        }

        public List<Location> getNeighbors(Location theStart)
        {
            List<Location> neighbors = new List<Location>();
            for (int i = 0; i < myStreets.Count; i ++)
            {
                Street temp = myStreets[i];
                if (temp.myA.Equals(theStart))
                {
                    neighbors.Add(temp.myB);
                }
                else if (temp.myB.Equals(theStart))
                {
                    neighbors.Add(temp.myA);
                }
            }
            return neighbors;
        }

        public class Location
        {
            private int myX { get; }
            private int myY { get; }

            public Location(int theX, int theY)
            {
                myX = theX;
                myY = theY;
            }
        }

        public class Street
        {
            public int myWeight { get; }
            public Location myA { get; }
            public Location myB { get; }

            public Street(int theWeight, Location theA, Location theB)
            {
                myWeight = theWeight;
                myA = theA;
                myB = theB;
            }

        }
    }
}


