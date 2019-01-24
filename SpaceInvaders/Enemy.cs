using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SpaceInvaders
{
    class Enemy : IObject, IMovement
    {
        public int Xpos;
        public int Ypos;

        Graphics G;

        public bool Delete;//Delete the object if it's true.

        public void Create(int x, int y)
        {
            Xpos = x;
            Ypos = y;

            Delete = false;
        }

        public void Draw(Form1 form)
        {
            G = form.CreateGraphics();

            G.DrawRectangle(new Pen(Brushes.Red), Xpos, Ypos, 30, 30);
        }

        public bool CollisionDetected(Drop drop)
        {
            //Detect a collision with an drop.
            if((drop.Xpos > this.Xpos) && (drop.Xpos < this.Xpos + 30) && (drop.Ypos > this.Ypos) && (drop.Ypos < this.Ypos + 30))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Move(int val)
        {
            Ypos += val;
        }
    }
}
