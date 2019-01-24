using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    //Move the objects.
    public interface IMovement
    {
        void Move(int val);
    }
}
