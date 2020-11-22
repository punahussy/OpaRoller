using OpaRoller.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpaRoller.Controllers
{
    public static class Roller
    {
        public static readonly object RndSync = new object();

        public static int[] Roll(int quantity, IDice dice)
        {
            Random rnd = new Random();
            int[] result = new int[quantity];
            for (int i = 0; i < quantity; i++)
            {
                lock (RndSync)
                {
                    result[i] = rnd.Next(1, dice.EdgesCount);
                }
            }
            return result;
        }
    }
}
