using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bounce
{
    interface Obstacle
    {
       // void Line(int x, int y, int xd, int yd);
        void GDraw(Graphics g);
        void Collision(Ball ball);
        
           

    }
}
