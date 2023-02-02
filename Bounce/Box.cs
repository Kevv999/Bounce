using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Numerics;

namespace Bounce
{
    public abstract class Box : Obstacle
    {
        protected  Pen pen;
        protected  PointF Position;
        protected  PointF Size; 

        public void GDraw(Graphics g)
        {
                g.DrawRectangle(pen, Position.X, Position.Y, Size.X, Size.Y);
        }
        
        public void Collision(Ball ball)
        {
          

            var r1 = new Rectangle((int)Position.X, (int)Position.Y, (int)Size.X, (int)Size.Y);
            var ballX = ball.BallPos().X;
            var ballY = ball.BallPos().Y;
            var r = (int)ball.Radius;

            var r2 = new Rectangle((int)ballX - r, (int)ballY - r, 2 * r, 2 * r);

            if (r1.IntersectsWith(r2))
            {
                ChangeSpeed(ball);
            }
            
        }
        public abstract void ChangeSpeed(Ball ball);
        
           
        

        //public void SpeedUp(Ball ball)
        //{
        //    ball.Speed = new PointF(ball.Speed.X * 1.04f, ball.Speed.Y * 1.04f);
        //}
        //public void SlowDown(Ball ball)
        //{
        //    ball.Speed = new PointF(ball.Speed.X * 0.96f, ball.Speed.Y * 0.96f);
        //}
    }

}

