using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class WallBombed:Wall
    {
        public override void Enter()
        {
            Console.WriteLine("Bombed wall");
        }

        public override Wall Clone()
        {
            return new WallBombed();
        }
    }
}
