using System;
using System.Windows.Forms;


namespace Bounce
{
	public class MainForm : Form
	{
		public MainForm() : base()
		{
			Text = "Bounce!";
			Width = 800;
			Height = 600;
			DoubleBuffered = true;
		}
	}
}
