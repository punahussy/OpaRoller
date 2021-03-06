﻿using OpaRoller.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OpaRoller.Models
{
    public class D6 : IDice
    {
        public int EdgesCount => Edges;

        public int X { get; set; }
        public int Y { get; set; }

        public Image Texture { get; set; }
        public D6()
        {
            Texture = Textures.D6;
        }
        public int Number { get; set; }

        private const int Edges = 6;
    }
}
