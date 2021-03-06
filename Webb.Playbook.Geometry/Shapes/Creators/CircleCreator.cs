﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Webb.Playbook.Geometry.Shapes.Creators
{
    public class CircleCreator : Behavior
    {
        protected override void MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var coordinates = Coordinates(e);
            CreateCircleAtCurrentPosition(coordinates, true);
        }

        public override string Name
        {
            get { return "Circle"; }
        }
    }
}
