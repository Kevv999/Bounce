using System;
using System.Drawing;

namespace Bounce
{
	public class Ball
	{
	    Pen Pen = new Pen(Color.Black);

		PointF Position;
		public PointF Speed { get; set; }
		public float Radius { get; }

		static Random Random = new Random();

		public Ball(float x, float y, float radius)
		{
			Position = new PointF(x,y);
			var xd = Random.Next(1, 6);
			var yd = Random.Next(1, 6);
			if (Random.Next(0, 2) == 0) xd = -xd;
			if (Random.Next(0, 2) == 0) yd = -yd;

			Speed = new PointF(xd,yd);
			Radius = radius;
		}

		public PointF BallPos()
        {
			return Position;
        }
		
		public void Draw(Graphics g)
		{
			g.DrawEllipse(Pen,Position.X - Radius, Position.Y - Radius, 2 * Radius, 2 * Radius);
		}

		public void Move()
		{
			Position.X += Speed.X;
			Position.Y += Speed.Y;
		}
		


    }
}
