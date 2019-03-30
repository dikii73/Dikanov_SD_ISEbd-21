using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tank
{
    public abstract class Vehicle:ITransport
    {
        public enum Direction
        {
            Up,
            Down,
            Left,
            Right

        }
        protected float _startPosX;

        protected float _startPosY;

        protected int _pictureWidth;

        protected int _pictureHeight;

        public int Speed { protected set; get; }
        public Color MainColor;
        public void SetStartPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public abstract void MoveTransport(Vehicle.Direction direction);
        public abstract void DrawTransport(Graphics g);
    }
}
