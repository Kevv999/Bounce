using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bounce
{
    public class Horizontal : Line
    {
 
        public Horizontal(int x, int y, int xd, int yd)
        {
            base.A = new PointF(x, y);
            base.B = new PointF(xd, yd);
            base.pen = new Pen(Color.Green);

        }

        public override void Bounce(Ball ball)
        {
            ball.Speed = new PointF(ball.Speed.X, -ball.Speed.Y);
        }
    }
}
