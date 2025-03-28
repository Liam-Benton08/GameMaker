using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMaker
{
    internal class Ibox
    {
        public int x, y;
        public int size = 5;
        public bool up, down, left, right, stop;
        public Rectangle boxRec;

        public Ibox(int _x, int _y, bool _up, bool _down, bool _left, bool _right)
        {
            x = _x;
            y = _y;
            up = _up; 
            down = _down; 
            left = _left; 
            right = _right;

            boxRec = new Rectangle(x, y, size, size);
        }




    }
}
