using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLib.Models
{
    [Flags]
    public enum Direction
    {
        None = 0,
        North = 1,
        East = 2,
        South = 3,
        West = 4
    }

    public class Lane
    {
        /// <summary>
        /// The position the <see cref="Lane"/> starts in the containing <see cref="LaneSubGroup"/>.
        /// </summary>
        public float LaneStart { get; protected set; }

        /// <summary>
        /// The position the <see cref="Lane"/> ends in the containing <see cref="LaneSubGroup"/>.
        /// </summary>
        public float LaneEnd { get; protected set; }

        /// <summary>
        /// Can prevent the <see cref="Lane"/> from being used.
        /// Simulates an accident, roadwork, etc.
        /// </summary>
        public bool IsEnabled { get; internal set; }

        /// <summary>
        /// The directions of other lanes this lane can take at junctions.
        /// Set to opposite direction for a U-Turn.
        /// </summary>
        public Direction JoinDirections { get; protected set; }
    }
}
