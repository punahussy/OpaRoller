using OpaRoller.Models;
using OpaRoller.View;
using OpaRoller.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OpaRoller
{
    public partial class RollerWindow : Form
    {
        Scene scene = new Scene();
        List<IDice> Drawables = new List<IDice>();
        bool Rotate = false;
        int RotateTimer = 0;
        int RotateAnimDuration = 1; //seconds
        bool DisplayText = false;

        Font NumberFont = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Point);
        TextFormatFlags TextFlags = TextFormatFlags.HorizontalCenter |
            TextFormatFlags.VerticalCenter;
        


        public RollerWindow()
        {
            InitializeComponent();

            //Устранение мерцания
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);
            UpdateStyles();

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            AllowTransparency = true;
            BackColor = Color.Green;//цвет фона  
            TransparencyKey = BackColor;//он же будет заменен на прозрачный цвет
            
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
            D8Amount.Text = $"{scene.Dices["D8"].Count}";
            D12Amount.Text = $"{scene.Dices["D12"].Count}";
            D20Amount.Text = $"{scene.Dices["D20"].Count}";
            if (Drawables.Count > 0 && Rotate)
            {
                RotateTimer++;    
                foreach (var dice in Drawables)
                {
                    dice.Texture.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                if ((1000 / mainTimer.Interval) * RotateAnimDuration < RotateTimer)
                {
                    RotateTimer = 0;
                    Rotate = false;
                    DisplayText = true;
                }
            }
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

                    if (DisplayText)
                        TextRenderer.DrawText(g, dice.Number.ToString(), 
                            NumberFont, diceRect, Color.Black, Color.Transparent, TextFlags);
                }
            }
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
                    case "AddD20":
                        scene.Dices["D20"].Push(new D20());
                        break;
                    case "AddD8":
                        scene.Dices["D8"].Push(new D8());
                        break;
                    case "AddD12":
                        scene.Dices["D12"].Push(new D12());
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
                    case "DelD20":
                        if (scene.Dices["D20"].Count > 0)
                            scene.Dices["D20"].Pop();
                        break;
                    case "DelD8":
                        if (scene.Dices["D8"].Count > 0)
                            scene.Dices["D8"].Pop();
                        break;
                    case "DelD12":
                        if (scene.Dices["D12"].Count > 0)
                            scene.Dices["D12"].Pop();
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
            DisplayText = false;
            Roller.Roll(scene);
            Drawables = scene.Dices.Values.SelectMany(d => d).ToList();
            Roller.Throw(this, Drawables);
            Rotate = true;
        }

        private void show_frame_btn_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle == FormBorderStyle.None 
                ? FormBorderStyle.Sizable : FormBorderStyle.None;
        }
    }
}
