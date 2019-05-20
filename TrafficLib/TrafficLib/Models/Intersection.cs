using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLib.Models
{
    public class Intersection
    {
        public LaneGroup NorthLanes { get; protected set; }
        public LaneGroup EastLanes { get; protected set; }
        public LaneGroup SouthLanes { get; protected set; }
        public LaneGroup WestLanes { get; protected set; }
        public Direction LanesAvailable { get; protected set; }


    }
}
