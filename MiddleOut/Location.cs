using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleOut
{
    /// <summary>
    /// A location on the map. Business or homeless shelter. 
    /// @Author Karanbir 
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
}
