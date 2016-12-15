using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;

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
            myLocations.Add(new Location(225, 475));
            myLocations.Add(new Location(315, 560));
            myLocations.Add(new Location(315, 300));
            myLocations.Add(new Location(400, 412));
            myLocations.Add(new Location(635, 450));
            myLocations.Add(new Location(400, 570));

            myStreets = new List<Street>();
            myStreets.Add(new Street(10, myLocations[0], myLocations[1]));
            myStreets.Add(new Street(5, myLocations[2], myLocations[3]));
            myStreets.Add(new Street(4, myLocations[1], myLocations[3]));
            myStreets.Add(new Street(7, myLocations[1], myLocations[2]));

            List<Street> deleteMe = Dijkstra(myLocations[0], myLocations[3]);
            drawLocations(deleteMe);

            Console.WriteLine("Test complete");
        }

        public void drawLocations(List<Street> streets)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\MiddleOut\\Images\\WorldMap-Elwynn.jpg";
            string outputPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\MiddleOut\\Images\\WorldMap-Elwynn1.jpg";
            System.Drawing.Image map = System.Drawing.Image.FromFile(path);
            //@"WorldMap-Elwynn.jpg"
            using (Graphics g = Graphics.FromImage(map))
            {
                g.DrawImage(map, 0, 0);
                System.Drawing.Color locColor = System.Drawing.Color.FromArgb(60, System.Drawing.Color.Red);
                SolidBrush brush = new SolidBrush(locColor);
                foreach (Location loc in myLocations)
                {
                    g.FillEllipse(brush, loc.myX, loc.myY, 50, 50);
                }
                brush = new SolidBrush(System.Drawing.Color.FromArgb(90, System.Drawing.Color.Yellow));
                foreach (Street st in streets)
                {
                    GraphicsPath lineBetweenLocs = new GraphicsPath();
                    lineBetweenLocs.AddLine(st.myA.myX + 25, st.myA.myY + 25, st.myB.myX + 25, st.myB.myY + 25);
                    
                    g.DrawPath(new System.Drawing.Pen(brush, 5), lineBetweenLocs);
                }
                map.Save(outputPath);
                System.Windows.Media.ImageSource outputImage = new BitmapImage(new Uri(outputPath));
                OutputImage.Source = outputImage;
            }
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

        /// <summary>
        /// Finds the minimum value location in the given dictinoary. Otherwise returns the first 
        /// value in the dictionary if it is unvisited. 
        /// </summary>
        /// <param name="theDic">The dictionary with values.</param>
        /// <param name="theUnvisited">The list of univisited locations.</param>
        /// <returns>The location with the lowest distance.</returns>
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

        /// <summary>
        /// Gets the neighbors of the given location. 
        /// </summary>
        /// <param name="theStart">The location to find neighbors of.</param>
        /// <returns>Returns a list of location neighbors not including the location passed in.</returns>
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

        /// <summary>
        /// A location on the map. Business or homeless shelter. 
        /// </summary>
        public class Location
        {
            public int myX { get; }
            public int myY { get; }

            /// <summary>
            /// Initializes the Location with the given coordinates. 
            /// </summary>
            /// <param name="theX">X coordinate</param>
            /// <param name="theY">Y coordinate</param>
            public Location(int theX, int theY)
            {
                myX = theX;
                myY = theY;
            }
        }

        /// <summary>
        /// The street connecting two locations. 
        /// </summary>
        public class Street
        {
            public int myWeight { get; }
            public Location myA { get; }
            public Location myB { get; }

            /// <summary>
            /// Iinitialize a street between two locations with a weight as travel time.
            /// </summary>
            /// <param name="theWeight">The travel time.</param>
            /// <param name="theA">The first location.</param>
            /// <param name="theB">The second location.</param>
            public Street(int theWeight, Location theA, Location theB)
            {
                myWeight = theWeight;
                myA = theA;
                myB = theB;
            }
        }
    }
}


