﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using RimWorld;

namespace AmbrosiaLongevity
{
    public class HediffCompProperties_Longevity_Old : HediffCompProperties
    {
        public int defaultAgeFloor = 20, defaultAgeCeiling = 27, minHours = 3, maxHours = 9;
        public HediffCompProperties_Longevity_Old()
        {
            base.compClass = typeof(HediffComp_Longevity_Old);
        }        
    }
}