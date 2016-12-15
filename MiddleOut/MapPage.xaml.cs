using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
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
        // public for unit testing 
        public List<Location> myLocations;
        public List<Street> myStreets;
        private Dictionary<string, Location> myLocNames;
        private Location myStart;
        private Location myEnd;
        private int switchImage;
        public DijkstraAlg myDijkstra;

        /// <summary>
        /// Initialize the MapPage with dummy locations and streets. 
        /// @Author Karanbir 
        /// </summary>
        public MapPage()
        {
            InitializeComponent();

            switchImage = 0; 

            myLocations = new List<Location>();
            myLocations.Add(new Location(225, 475)); // Westbrook Garrison
            myLocations.Add(new Location(315, 560)); // Stonefield Farm
            myLocations.Add(new Location(315, 300)); // Stormwind Gates
            myLocations.Add(new Location(400, 412)); // Goldshire
            myLocations.Add(new Location(635, 450)); // Tower of Azora
            myLocations.Add(new Location(400, 570)); // Maclure Vineyards

            myLocNames = new Dictionary<string, Location>();
            myLocNames.Add("Westbrook Garrison", myLocations[0]);
            myLocNames.Add("Stonefield Farm", myLocations[1]);
            myLocNames.Add("Stormwind Gates", myLocations[2]);
            myLocNames.Add("Goldshire", myLocations[3]);
            myLocNames.Add("Tower of Azora", myLocations[4]);
            myLocNames.Add("Maclure Vineyards", myLocations[5]);
            
            myStreets = new List<Street>(); // Streets connecting the areas. 
            addStreet(myLocations[4], myLocations[3]);
            addStreet(myLocations[1], myLocations[3]);
            addStreet(myLocations[1], myLocations[5]);
            addStreet(myLocations[1], myLocations[0]);
            addStreet(myLocations[0], myLocations[3]);
            addStreet(myLocations[2], myLocations[3]);

            myDijkstra = new DijkstraAlg(myLocations, myStreets);

            StartXY.SelectedIndex = 0;
            myStart = myLocations[0];
            EndXY.SelectedIndex = 0;
            myEnd = myLocations[0];

            foreach (string name in myLocNames.Keys)
            {
                StartXY.Items.Add(name);
                EndXY.Items.Add(name);
            }

            Console.WriteLine("Dijkstra complete");
        }

        /// <summary>
        /// Adds the street with a weight as the hypoteneus of the two locations. 
        /// </summary>
        /// <param name="loc1">First location.</param>
        /// <param name="loc2">Second locatoin.</param>
        public void addStreet(Location loc1, Location loc2)
        {
            myStreets.Add(new Street((int)Math.Sqrt(Math.Pow(loc1.myX - loc2.myX, 2) + 
                Math.Pow(loc1.myY - loc2.myY, 2)), loc1, loc2));
        }

        /// <summary>
        /// Highlights the locations on the map in red along with the paths to take as yellow lines
        /// </summary>
        /// <param name="streets">The path to take between locations</param>
        public void drawLocations(List<Street> streets)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\MiddleOut\\Images\\WorldMap-Elwynn.jpg";
            string outputPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\MiddleOut\\Images\\WorldMap-Elwynn " + switchImage + ".jpg";
            switchImage++;
            System.Drawing.Image map = System.Drawing.Image.FromFile(path);
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
                foreach (Street st in myStreets)
                {
                    
                    GraphicsPath lineBetweenLocs = new GraphicsPath();
                    lineBetweenLocs.AddLine(st.myA.myX + 25, st.myA.myY + 25, st.myB.myX + 25, st.myB.myY + 25);

                    g.DrawPath(new System.Drawing.Pen(brush, 5), lineBetweenLocs);
                }
                brush = new SolidBrush(System.Drawing.Color.FromArgb(100, System.Drawing.Color.Red));
                if (streets != null && streets.Count != 0)
                {
                    foreach (Street st in streets)
                    {
                        GraphicsPath lineBetweenLocs = new GraphicsPath();
                        lineBetweenLocs.AddLine(st.myA.myX + 25, st.myA.myY + 25, st.myB.myX + 25, st.myB.myY + 25);

                        g.DrawPath(new System.Drawing.Pen(brush, 5), lineBetweenLocs);
                    }
                }
                map.Save(outputPath);
                System.Windows.Media.ImageSource outputImage = new BitmapImage(new Uri(outputPath));
                OutputImage.Source = outputImage;
                
            }
        }


        




        

        /// <summary>
        /// Checks if the start combobox has been changed and updates the class variable. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartXY_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine(StartXY.SelectedItem.ToString());
            myLocNames.TryGetValue(StartXY.SelectedItem.ToString(), out myStart);
            List <Street> deleteMe = myDijkstra.Dijkstra(myStart, myEnd); 
            drawLocations(deleteMe);
        }

        /// <summary>
        /// Checks if the end combobox has been changed and updates the class varaible. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndXY_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine(EndXY.SelectedItem.ToString());
            myLocNames.TryGetValue(EndXY.SelectedItem.ToString(), out myEnd);
            List<Street> deleteMe = myDijkstra.Dijkstra(myStart, myEnd);
            drawLocations(deleteMe);
        }
    }
}


