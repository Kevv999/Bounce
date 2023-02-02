using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Bounce
{
    public class SpeedDownBox : Box
    {
     
        public SpeedDownBox(int x, int y, int width, int height)
        {
            base.Position = new PointF(x, y);
            base.Size = new PointF(width, height);
            base.pen = new Pen(Color.Blue);
        }
        public override void ChangeSpeed(Ball ball)
        {
            if (ball.Speed.X > 0.75 && ball.Speed.Y > 0.75)
            {
                ball.Speed = new PointF(ball.Speed.X * 0.90f, ball.Speed.Y * 0.90f);
            
            }
           
        }
    }
}
