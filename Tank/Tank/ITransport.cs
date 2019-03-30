using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tank
{
    interface ITransport
    {
        void SetStartPosition(int x, int y, int width, int height);
        void MoveTransport(Vehicle.Direction direction);
        void DrawTransport(Graphics g);
    }
}
