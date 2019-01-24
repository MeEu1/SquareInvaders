using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Drop :IObject, IMovement
    {
        public int Xpos;
        public int Ypos;

        public bool IsSet;//Is true whenever the player shots.

        Graphics G;

        public void Create(int x, int y)
        {
            //Get the x and y positions.
            Xpos = x;
            Ypos = y;

            IsSet = false;
        }

        public void Draw(Form1 form)
        {
            //Draw a blue 10x10 ellipse.
            G = form.CreateGraphics();

            form.Draw();//Draw evey element on the form.
            G.DrawEllipse(new Pen(Brushes.Red), Xpos, Ypos, 10, 10);
        }

        public void Move(int val)
        {
            //Move val pixels on the y axe.
            Ypos += val;
        }
    }
}
