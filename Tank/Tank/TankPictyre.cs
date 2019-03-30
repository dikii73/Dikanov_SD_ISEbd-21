using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tank
{
    class TankPictyre:Tank
    {
        public Color DopColor { private set; get; }

        public TankPictyre(Color main, int speed, int startx, int starty, int widht, int height,Color dop) : base (main, speed, startx, starty, widht, height)
        {
            MainColor = main;
            _startPosX = startx;
            _startPosY = starty;
            _pictureWidth = widht;
            _pictureHeight = height;
            Speed = speed;
            DopColor = dop;
        }
        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, _startPosX - 11, _startPosY + 70, 170, 40);//гусеницы
            g.DrawRectangle(pen, _startPosX + 90, _startPosY + 30, 100, 10);//пушка
            g.DrawEllipse(pen, _startPosX + 5, _startPosY + 80, 25, 25);//1 колесо
            g.DrawEllipse(pen, _startPosX + 40, _startPosY + 80, 25, 25);//2 колесо
            g.DrawEllipse(pen, _startPosX + 75, _startPosY + 80, 25, 25);//3 колесо
            g.DrawEllipse(pen, _startPosX + 110, _startPosY + 80, 25, 25);//4 колесо
            Brush dopbr = new SolidBrush(DopColor);

            Brush gray = new SolidBrush(Color.Gray);
            Brush black = new SolidBrush(Color.Black);
            g.FillEllipse(gray, _startPosX - 11, _startPosY + 70, 170, 40);//гусеницы
            g.FillRectangle(dopbr, _startPosX + 90, _startPosY + 30, 100, 10);//пушка
            g.FillEllipse(black, _startPosX + 5, _startPosY + 80, 25, 25);//1 колесо
            g.FillEllipse(black, _startPosX + 40, _startPosY + 80, 25, 25);//2 колесо
            g.FillEllipse(black, _startPosX + 75, _startPosY + 80, 25, 25);//3 колесо
            g.FillEllipse(black, _startPosX + 110, _startPosY + 80, 25, 25);//4 колесо
        }
    }
}
