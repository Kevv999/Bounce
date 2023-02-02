using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Bounce
{
    public class Vertical : Line
    {
     
     
        public Vertical(int x, int y, int xd, int yd)
        {
           base.A = new PointF(x, y);
           base.B = new PointF(xd, yd);
           base.pen = new Pen(Color.Yellow);
        }
        public override void Bounce(Ball ball)
        {
            ball.Speed = new PointF(-ball.Speed.X, ball.Speed.Y);
        }
    }
}
