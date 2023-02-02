using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Bounce
{
    public class SpeedUpBox : Box
    {
       
        public SpeedUpBox(int x, int y, int width, int height)
        {
           base.Position = new PointF(x, y);
           base.Size = new PointF(width, height);
           base.pen = new Pen(Color.Red); 
        }
        public override void ChangeSpeed(Ball ball)
        {
            if (ball.Speed.X < 8 && ball.Speed.Y < 8)
            {
                ball.Speed = new PointF(ball.Speed.X * 1.04f, ball.Speed.Y * 1.04f);
            }
            
        }
    }
}
