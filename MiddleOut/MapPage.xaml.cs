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
        }

        public List<Street> Dijkstra(Location theStart, Location theEnd)
        {
            List<Street> shortestPath = new List<Street>();
            Dictionary<Location, int> buildPaths = new Dictionary<Location, int>();
            buildPaths.Add(theStart, 0);
            
            bool foundEnd = false;
            int count = 0;
            while (!foundEnd) {
                List<Street> neighbors = getNeighbors(buildPaths[count]);
            }
            return shortestPath;
        }

        public List<Street> getNeighbors(Location theStart)
        {
            List<Street> neighbors = new List<Street>();
            for (int i = 0; i < myStreets.Count; i ++)
            {
                Street temp = myStreets[i];
                if (temp.myA.Equals(theStart))
                {
                    neighbors.Add(temp);
                }
                else if (temp.myB.Equals(theStart))
                {
                    neighbors.Add(temp);
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


