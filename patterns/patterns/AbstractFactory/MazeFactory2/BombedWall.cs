using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class BombedWall:Wall
    {
        public override void Enter()
        {
            Console.WriteLine("BOOM");
        }
    }
}
