using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Numerics;
using System.Diagnostics;

namespace Bounce
{
	public class Engine
	{
		MainForm Form = new MainForm();
		Timer Timer = new Timer();
		List<Ball> Balls = new List<Ball>();
		Random Random = new Random();

		//List<Line> lines = new List<Line>();
		//List<Box> rektangles = new List<Box>();
		List<Obstacle> obstacles = new List<Obstacle>();
		public void Run()
		{
			
			obstacles.Add(new Horizontal(500, 100, 700, 100));
			//lines.Add(new Line(500, 100, 700, 100, pen = new Pen(Color.Green)));
			obstacles.Add(new Horizontal(300, 150, 500, 150));
			//lines.Add(new Line(300, 150, 500, 150, pen = new Pen(Color.Green)));
			obstacles.Add(new Horizontal(50, 50, 300, 50));
			//lines.Add(new Line(50, 50, 300, 50, pen = new Pen(Color.Green)));
			obstacles.Add(new Horizontal(200, 520, 700, 520));
			//lines.Add(new Line(200, 520, 700, 520, pen = new Pen(Color.Green)));
			obstacles.Add(new Vertical(750, 550, 750, 150));
			obstacles.Add(new Vertical(20, 100, 20, 750));

			//lines.Add(new Line(750, 550, 750, 150, pen = new Pen(Color.Yellow)));
			//lines.Add(new Line(20, 100, 20, 750, pen = new Pen(Color.Yellow)));
			obstacles.Add(new SpeedUpBox(600, 150, 100, 100));
			obstacles.Add(new SpeedUpBox(100, 200, 100, 200));
			obstacles.Add(new SpeedDownBox(600, 300, 50, 200));

			//rektangles.Add(new Box(600, 150, 100, 100));
			//rektangles.Add(new Box(100, 200, 100, 200 ));
			//rektangles.Add(new Box(600, 300, 50, 200 ));

			Form.Paint += Draw;
			Timer.Tick += TimerEventHandler;
			Timer.Interval = 1000 / 25;
			Timer.Start();


			Application.Run(Form);
		}

		void TimerEventHandler(Object obj, EventArgs args)
		{
			if (Random.Next(100) < 10)
			{
				var ball = new Ball(400, 300, 10);
				Balls.Add(ball);
			}

			foreach (var ball in Balls)
			{
				ball.Move();
				foreach (var obstacle in obstacles)
				{
					obstacle.Collision(ball);
				}

			}

			Form.Refresh();
		}





		void Draw(Object obj, PaintEventArgs args)
		{

			foreach (var ball in Balls) ball.Draw(args.Graphics);


			foreach (var obstacle in obstacles) obstacle.GDraw(args.Graphics);



		}
	}
	
}
