using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OpaRoller.Models
{
    public class D12 : IDice
    {
        public int EdgesCount => Edges;
        private const int Edges = 12;

        public int X { get; set; }
        public int Y { get; set; }
        public Image Texture { get; set; }
        public int Number { get; set; }

        public D12()
        {
            Texture = Resources.Textures.D12;
        }
    }
}
