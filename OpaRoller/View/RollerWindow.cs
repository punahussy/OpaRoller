using OpaRoller.Models;
using OpaRoller.View;
using OpaRoller.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpaRoller
{
    public partial class RollerWindow : Form
    {
        D4 d4 = new D4();
        Scene scene = new Scene();
        List<IDice> Drawables = new List<IDice>();

        Font NumberFont = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Point);
        TextFormatFlags flags = TextFormatFlags.HorizontalCenter |
            TextFormatFlags.VerticalCenter | TextFormatFlags.Bottom;


        public RollerWindow()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            AllowTransparency = true;
            BackColor = Color.AliceBlue;//цвет фона  
            TransparencyKey = this.BackColor;//он же будет заменен на прозрачный цвет
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainTimer.Stop();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            D4Amount.Text = $"{scene.Dices["D4"].Count}";
            D6Amount.Text = $"{scene.Dices["D6"].Count}";
            Refresh();
        }

        private void RollerWindow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (Drawables.Count > 0)
            {
                foreach (var dice in Drawables)
                {
                    Rectangle diceRect = new Rectangle(dice.X, dice.Y, 128, 128);
                    g.DrawImage(dice.Texture, Rectangle.Round(diceRect));

                    TextRenderer.DrawText(g, dice.Number.ToString(), 
                        NumberFont, diceRect, Color.Black, Color.Transparent, flags);
                }
            }
            //string Number = "4";


        }

        private void AddDice(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                switch (btn.Name)
                {
                    case "AddD4":
                        scene.Dices["D4"].Push(new D4());
                        break;
                    case "AddD6":
                        scene.Dices["D6"].Push(new D6());
                        break;
                }
            }
        }

        private void RemoveDice(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                switch (btn.Name)
                {
                    case "DelD4":
                        if (scene.Dices["D4"].Count > 0)
                            scene.Dices["D4"].Pop();
                        break;
                    case "DelD6":
                        if (scene.Dices["D6"].Count > 0)
                            scene.Dices["D6"].Pop();
                        break;
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            scene.Reset();
        }

        private void RollBtn_Click(object sender, EventArgs e)
        {
            Roller.Roll(scene);
            Drawables = scene.Dices.Values.SelectMany(d => d).ToList();
            Roller.Throw(this, Drawables);
            int a;
            a = 3;
        }
    }
}
