using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OpaRoller.Models
{
    public interface IDice
    {
        public int EdgesCount { get; }

        //Drawable
        public int X { get; set; }
        public int Y { get; set; }
        public Image Texture { get; }
        public int Number { get; set; }
        
    }
}
