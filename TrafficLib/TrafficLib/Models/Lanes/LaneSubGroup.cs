using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLib.Models
{
    public class LaneSubGroup
    {
        /// <summary>
        /// The direction of traffic flow on this <see cref="LaneGroup"/>.
        /// </summary>
        /// <example>
        /// <code>
        /// LaneDirection = Direction.West;
        /// </code>
        /// Sets the <see cref="LaneGroup"/> to flow horizontally to the "left".
        /// </example>
        public Direction LaneDirection { get; protected set; }

        public float Length { get; protected set; }
    }
}
