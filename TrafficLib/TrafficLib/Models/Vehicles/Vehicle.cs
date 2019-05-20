using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLib.Models
{
    public abstract class Vehicle
    {
        public float Speed { get; protected set; }
        public float Acceleration { get; protected set; }

        /// <summary>
        /// Braking power.
        /// </summary>
        public float Decceleration { get; protected set; }

        /// <summary>
        /// The distance that the <see cref="Vehicle"/> has traveled within the lane.
        /// </summary>
        public float Position { get; protected set; }
    }
}
