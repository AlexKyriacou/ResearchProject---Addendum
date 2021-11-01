﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ResearchProject
{
    public class ECS_CColor : ECS_Component
    {
        public ECS_CColor()
        {
            componentType = ECS_ComponentTypes.Color;
        }
        public Color color;
    }
}
