using OpaRoller.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpaRoller.View
{
    public class Scene
    {
        public Dictionary<string, List<IDice>> Dices = new Dictionary<string, List<IDice>>()
        {
            {"D4", new List<IDice>()},
            {"D6", new List<IDice>()},
            {"D8", new List<IDice>()},
            {"D10", new List<IDice>()},
            {"D100", new List<IDice>()},
            {"D12", new List<IDice>()},
            {"D20", new List<IDice>()}
        };
        
        public void Reset()
        {
            foreach (var key in Dices.Keys)
            {
                Dices[key].Clear();
            }
        }
    }
}
