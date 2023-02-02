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
    public abstract class Line : Obstacle
    {
       protected PointF A;
       protected PointF B;
       protected Pen pen;

        public void GDraw(Graphics g) 
        {
            
            g.DrawLine(pen, A.X, A.Y, B.X, B.Y);
        }

        public void Collision(Ball ball)
        {
           if(Distance(A,B,ball.BallPos()) < 7)
            {
                Bounce(ball);
            }
        
        }
        //COLLSION
        public abstract void Bounce(Ball ball);

        public double Distance(PointF A, PointF B, PointF C)
        {
            Vector2 AC = sub(C, A);
            Vector2 AB = sub(B, A);

            PointF proj = Proj(AC, AB);
            PointF D = add(proj, A);

            Vector2 AD = sub(D, A);

            var k = Math.Abs(AB.X) > Math.Abs(AB.Y) ? AD.X / AB.X : AD.Y / AB.Y;

            if (k <= 0.0)
            {
                return Math.Sqrt(hypot2(C, A));
            }

            else if (k >= 1.0)
            {
                return Math.Sqrt(hypot2(C, B));
            }

            return Math.Sqrt(hypot2(C, D));
        }
        public Vector2 sub(PointF a, PointF b)
        {
            return new Vector2(a.X - b.X, a.Y - b.Y);
        }

        public PointF add(PointF a, PointF b)
        {
            return new PointF(a.X + b.X, a.Y + b.Y);
        }

        public PointF Proj(Vector2 a, Vector2 b)
        {
            float k = (float)(dot(a, b) / dot(b, b));
            return new PointF(k * b.X, k * b.Y);

        }

        public double dot(Vector2 a, Vector2 b)
        {
            return (a.X * b.X + a.Y * b.Y);
        }

        public double hypot2(PointF a, PointF b)
        {
            return dot(sub(a, b), sub(a, b));
        }


    }
}
