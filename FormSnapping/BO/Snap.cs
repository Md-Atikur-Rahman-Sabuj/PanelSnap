using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace BO
{
    public class Snap
    {
        Panel p1, p2, p3, p4;
        public int panelbup(Panel p1)
        {
            if (p1.Location.X > 0 && p1.Location.Y > 112 && p1.Location.X < 200 && p1.Location.Y < 350)
            {
                return 3;
            }
            else if (p1.Location.X > 330 && p1.Location.Y > 0 && p1.Location.X < 500 && p1.Location.Y < 100)
            {
                return 2;
            }
            else if (p1.Location.X > 330 && p1.Location.Y > 157 && p1.Location.X < 500 && p1.Location.Y < 350)
            {
                return 4;
            }
            else if (p1.Location.X > 0 && p1.Location.Y > 0 && p1.Location.X < 150 && p1.Location.Y < 150)
            {
                return 1;
            }
            else
                return 0;
        }
        Panel getpanel(float x, float y,Panel pp1,Panel pp2,Panel pp3,Panel pp4)
        {
            if (pp1.Location.X == x && pp1.Location.Y == y)
                return pp1;
            else if (pp2.Location.X == x && pp2.Location.Y == y)
                return pp2;
            else if (pp3.Location.X == x && pp3.Location.Y == y)
                return pp3;
            else
                return pp4;
        }
        public int getxx(int x,int y)
        {
            if (x == 81 && y == 42)
            {
                return 1;
            }
            else if (x == 423 && y == 42)
            {
                return 2;
            }
            else if (x == 81 && y == 257)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
        public void pinitialization(Panel a1, Panel a2, Panel a3, Panel a4)
        {
            p1 = getpanel(81, 42, a1, a2, a3, a4);
            p2 = getpanel(423, 42, a1, a2, a3, a4);
            p3 = getpanel(81, 257, a1, a2, a3, a4);
            p4 = getpanel(423, 257, a1, a2, a3, a4);
        }
        public void sort(int x1,int x2)
        {
            
            if((x1==1&&x2==2)||(x1==2&&x2==1))
            {
                p2.Location = new Point(81, 42);
                p1.Location = new Point(423, 42);
            }
            else if(x1==1&&(x2==0||x2==1))
            {
                p1.Location = new Point(81, 42);
            }
            else if (x1 == 1 && x2 == 3)
            {
                p2.Location = new Point(81, 42);
                p1.Location = new Point(81, 257);
                p3.Location = new Point(423,42);
            }
            else if (x1 == 1 && x2 == 4)
            {
                p2.Location = new Point(81, 42);
                p1.Location = new Point(423, 257);
                p3.Location = new Point(423, 42);
                p4.Location = new Point(81, 257);
            }
            else if ((x1 == 2 && x2 == 3)||(x1==3 && x2==2))
            {
                p2.Location = new Point(81, 257);
                p3.Location = new Point(423, 42);
            }
            else if (x1 == 2 && x2 == 4)
            {
                p2.Location = new Point(423, 257);
                p4.Location = new Point(81, 257);
                p3.Location = new Point(423, 42);
            }
            else if(x1 == 2 && (x2 == 0||x2==2))
            {
                p2.Location = new Point(423, 42);
            }
            else if (x1 == 3 && x2 == 1)
            {
                p3.Location = new Point(81, 42);
                p2.Location = new Point(81, 257);
                p1.Location = new Point(423, 42);
            }
            else if ((x1 == 3 && x2 == 4)||(x1==4&&x2==3))
            {
                p3.Location = new Point(423, 257);
                p4.Location = new Point(81, 257);
            }
            else if (x1 == 3 && (x2 == 0||x2==3))
            {
                p3.Location = new Point(81, 257);
            }
            else if (x1 == 4 && x2 == 1)
            {
                p4.Location = new Point(81, 42);
                p3.Location = new Point(423, 257);
                p2.Location = new Point(81, 257);
                p1.Location = new Point(423, 42);
            }
            else if (x1 == 4 && x2 == 2)
            {
                p4.Location = new Point(423, 42);
                p3.Location = new Point(423, 257);
                p2.Location = new Point(81, 257);
            }
            else if(x1==4&&(x2==0||x2==4))
            {
                p4.Location = new Point(423, 257);
            }
            
        }

    }
}
