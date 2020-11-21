using OpaRoller.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpaRoller.Controllers
{
    public static class Roller
    {
        public static int Roll(Dice dice)
        {
            Random rnd = new Random();
            return rnd.Next(1, dice.EdgesCount);            
        }
    }
}
