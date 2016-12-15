using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleOut
{
    /// <summary>
    /// The street connecting two locations. 
    /// @Author Karanbir 
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