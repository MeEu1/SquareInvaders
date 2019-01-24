using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    //Every object has it.
    public interface IObject
    {
        void Create(int x, int y);//Get the x and y positions.
        void Draw(Form1 form);//Draw the object.
    }
}
