using System;
using System.Collections.Generic;
using System.Text;

namespace OpaRoller.Models
{
    public class D6: IDice
    {
        public int EdgesCount { get; }

        public D6()
        {
            EdgesCount = 6;
        }
    }
}
