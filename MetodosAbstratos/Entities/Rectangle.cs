﻿using MetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosAbstratos.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double widht,  double height, Color color) : base(color)
        {
            Width = widht;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
