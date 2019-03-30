using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tank
{
    public class Tank:Vehicle
    {
        private const int carWidth = 200;

        private const int carHeight = 159;

        public Tank(Color main,int speed,int startx,int starty,int widht,int height)
        {
            MainColor = main;
            _startPosX=startx ;
            _startPosY = starty;
            _pictureWidth = widht;
            _pictureHeight = height;
            Speed = speed;
        }
        public override void MoveTransport(Direction direction)
        {
            
            switch (direction)
            {

                case Direction.Right:
                    if (_startPosX + Speed < _pictureWidth - carWidth)
                    {
                        _startPosX += Speed;
                    }
                    break;

                case Direction.Left:
                    if (_startPosX - Speed > 0)
                    {
                        _startPosX -= Speed;
                    }
                    break;

                case Direction.Up:
                    if (_startPosY - Speed > 0)
                    {
                        _startPosY -= Speed;
                    }
                    break;

                case Direction.Down:
                    if (_startPosY + Speed < _pictureHeight - carHeight)
                    {
                        _startPosY += Speed;
                    }
                    break;
            }
            
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush main = new SolidBrush(MainColor);
            g.DrawRectangle(pen, _startPosX - 1, _startPosY + 50, 150, 40);//корпус
            
            g.DrawEllipse(pen, _startPosX + 49, _startPosY + 20, 80, 50);//башня
            
            g.DrawEllipse(pen, _startPosX + 5, _startPosY + 80, 25, 25);//1 колесо
            g.DrawEllipse(pen, _startPosX + 40, _startPosY + 80, 25, 25);//2 колесо
            g.DrawEllipse(pen, _startPosX + 75, _startPosY + 80, 25, 25);//3 колесо
            g.DrawEllipse(pen, _startPosX + 110, _startPosY + 80, 25, 25);//4 колесо

            Brush gray = new SolidBrush(Color.Gray);
            Brush black = new SolidBrush(Color.Black);
            g.FillRectangle(main, _startPosX - 1, _startPosY + 50, 150, 40);//корпус
            
            g.FillEllipse(main, _startPosX + 49, _startPosY + 20, 80, 50);//башня
            
            g.FillEllipse(black, _startPosX + 5, _startPosY + 80, 25, 25);//1 колесо
            g.FillEllipse(black, _startPosX + 40, _startPosY + 80, 25, 25);//2 колесо
            g.FillEllipse(black, _startPosX + 75, _startPosY + 80, 25, 25);//3 колесо
            g.FillEllipse(black, _startPosX + 110, _startPosY + 80, 25, 25);//4 колесо

        }
    }
}
