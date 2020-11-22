using OpaRoller.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpaRoller.View
{
    public class Scene
    {
        public Dictionary<string, Stack<IDice>> Dices = new Dictionary<string, Stack<IDice>>()
        {
            {"D4", new Stack<IDice>()},
            {"D6", new Stack<IDice>()},
            {"D8", new Stack<IDice>()},
            {"D10", new Stack<IDice>()},
            {"D100", new Stack<IDice>()},
            {"D12", new Stack<IDice>()},
            {"D20", new Stack<IDice>()}
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
