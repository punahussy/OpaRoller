using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using OpaRoller.Resources;

namespace OpaRoller.Models
{
    public class D4 : IDice
    {
        public int EdgesCount => Edges;

        public int X { get; set; }
        public int Y { get; set; }

        public Image Texture { get; set; }
        public D4()
        {
            Texture = Textures.D4;
        }
        public int Number { get; set; }

        private const int Edges = 4;

    }
}
