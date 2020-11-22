using OpaRoller.Models;
using OpaRoller.View;
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
            d4.Texture.RotateFlip(RotateFlipType.Rotate90FlipX);
            D4Amount.Text = $"{scene.Dices["D4"].Count}";
            Refresh();
        }

        private void RollerWindow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(d4.Texture, new Rectangle(200, 400, 128, 128));
        }

        private void AddDice(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                switch (btn.Name)
                {
                    case "AddD4":
                        scene.Dices["D4"].Add(new D4());
                        break;
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            scene.Reset();
        }
    }
}
