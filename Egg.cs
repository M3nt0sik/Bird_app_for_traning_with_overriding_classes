﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIrd_app_for_traning_with_overriding_classes
{
    internal class Egg
    {
        public double Size { get; private set; }
        public string Color { get; private set; }
        public Egg(double size, string color)
        {
            Size = size;
            Color = color;
        }
        public string Description
        {
            get { return $"{Color} jajo o wielkosci {Size:0.0} cm."; }
        }
    }
}