using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLib.Models
{
    public class LaneGroup
    {
        public byte SpeedLimit { get; protected set; }

        public LaneSubGroup Lanes { get; protected set; }
        public LaneSubGroup ReverseLanes { get; protected set; }
    }
}
