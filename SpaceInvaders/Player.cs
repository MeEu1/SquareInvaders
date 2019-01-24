using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpaceInvaders
{
    class Player : IObject, IMovement
    {
        public int Xpos;
        public int Ypos;

        Graphics G;

        public void Create(int x, int y)
        {
            Xpos = x;
            Ypos = y;
        }

        public void Draw(Form1 form)
        {
            //Draw a red 50x50 rectangle.
            G = form.CreateGraphics();

            G.DrawRectangle(new Pen(Brushes.White), Xpos, Ypos, 25, 25);
        }

        public void Move(int val)
        {
            //Move val pixels on the x axe.
            Xpos += val;
        }
    }
}
