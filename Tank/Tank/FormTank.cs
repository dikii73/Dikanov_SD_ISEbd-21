using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank
{
    public partial class FormTank : Form
    {
        private ITransport tank;

        public FormTank()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTank.Width, pictureBoxTank.Height);
            Graphics gr = Graphics.FromImage(bmp);
            tank.DrawTransport(gr);
            pictureBoxTank.Image = bmp;
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
           
            tank = new Tank(Color.Green,20,0,0,pictureBoxTank.Width,pictureBoxTank.Height);
            tank.SetStartPosition(0, 0, pictureBoxTank.Width, pictureBoxTank.Height);
            
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    tank.MoveTransport(Vehicle.Direction.Up);
                    break;
                case "buttonDown":
                    tank.MoveTransport(Vehicle.Direction.Down);
                   break;
                case "buttonLeft":
                    tank.MoveTransport(Vehicle.Direction.Left);
                    break;
                case "buttonRight":
                    tank.MoveTransport(Vehicle.Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonCreateTank_Click(object sender, EventArgs e)
        {
            tank = new TankPictyre(Color.Green, 20, 0, 0, pictureBoxTank.Width, pictureBoxTank.Height,Color.Blue);
            tank.SetStartPosition(0,0, pictureBoxTank.Width, pictureBoxTank.Height);

            Draw();
        }
    }
}

