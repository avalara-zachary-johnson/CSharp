﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampSchedulesLib_v2.Models.Info
{
    [Flags]
    public enum ActivityFlags
    {
        None = 0,
        Manual = 1,
        Repeatable = 2,
        Exclusive = 4,
        Excess = 8,
        SingleDorm = 16,
        MultiDorm = 32,
        Concurrent = 64,
        LongerDuration = 128,
        PriorityExclusive = 256,
        Exhausting = 512
    }

    public class ActivityInfo : Thing
    {
        static ActivityInfo()
        {
            ActivityIDs = new SortedSet<int>();
            ExclusiveActivityIDs = new SortedSet<int>();
            MultiDormActivities = new SortedSet<int>();
            HighFatigueActivities = new SortedSet<int>();
        }

        public ActivityFlags Flags { get; private set; }
        public int Duration { get; private set; }
        //public int ExhaustionLevel { get; private set; }
        public int MaxDorms { get; private set; }
        public int MinDorms { get; private set; }
        public string Name { get; private set; }
        //public int Count { get; private set; }
        public int Priority { get; private set; }
        //public int Zone { get; private set; }
        private static int ID_COUNTER = 0;
        public static SortedSet<int> ActivityIDs { get; private set; }
        public static SortedSet<int> ExclusiveActivityIDs { get; private set; }
        public static SortedSet<int> MultiDormActivities { get; private set; }
        public static SortedSet<int> HighFatigueActivities { get; private set; }
        public SortedSet<int> IncompatibleActivities { get; private set; }

        public ActivityInfo(string name, string abbrv, int basePriority, /*int exhaustionLevel,*/ ActivityFlags flags = ActivityFlags.None, int maxD = 1, int minD = 1, int duration = 1) : base(ID_COUNTER, abbrv)
        {
            MinDorms = minD;
            MaxDorms = maxD;
            Name = name;
            //Zone = zone;
            Duration = duration;
            Priority = basePriority;
            //ExhaustionLevel = exhaustionLevel;
            Flags = flags;
            ++ID_COUNTER;

            if (!Flags.HasFlag(ActivityFlags.Manual))
            {
                if (Flags.HasFlag(ActivityFlags.Exclusive))
                    ExclusiveActivityIDs.Add(ID);
                else
                    ActivityIDs.Add(ID);

                if (Flags.HasFlag(ActivityFlags.MultiDorm))
                {
                    MultiDormActivities.Add(ID);
                    if (abbrv == "GB")
                    {
                        Flags |= ActivityFlags.PriorityExclusive;
                        Flags |= ActivityFlags.Concurrent;
                    }
                    else if (abbrv == "CL")
                        Flags |= ActivityFlags.Concurrent;
                }
            }

            if (new string[] { "CT, CV, CW, HR, RC" }.Contains(abbrv))
            {
                HighFatigueActivities.Add(ID);
                Flags |= ActivityFlags.Exhausting;
            }
        }
    }
}
