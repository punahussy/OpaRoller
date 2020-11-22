using OpaRoller.Models;
using OpaRoller.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpaRoller.Controllers
{
    public static class Roller
    {
        public static readonly object RndSync = new object();

        private static Stack<int> Roll(int quantity, IDice dice)
        {
            Random rnd = new Random();
            Stack<int> result = new Stack<int>();
            for (int i = 0; i < quantity; i++)
            {
                lock (RndSync)
                {
                    result.Push(rnd.Next(1, dice.EdgesCount + 1));
                }
            }
            return result;
        }

        public static void Roll(Scene scene)
        {
            foreach(var diceType in scene.Dices.Keys)
            {
                if (scene.Dices[diceType].Count > 0)
                {
                    var currentRoll = Roll(scene.Dices[diceType].Count, scene.Dices[diceType].Peek());
                    foreach (var dice in scene.Dices[diceType])
                    {
                        dice.Number = currentRoll.Pop();
                    }
                }
            }
        }

        public static void Throw(Form form, List<IDice> dices)
        {
            Random rnd = new Random();
            foreach (var dice in dices)
            {
                lock (RndSync)
                {
                    dice.X = rnd.Next(1, (int)(form.Width * 0.8));
                    dice.Y = rnd.Next(128, (int)(form.Height * 0.8));
                }
            }
        }
    }
}
