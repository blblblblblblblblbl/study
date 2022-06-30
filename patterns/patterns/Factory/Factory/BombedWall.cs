
using System;

namespace Maze
{
    class BombedWall:Wall
    {

        public override void Enter()
        {
            Console.WriteLine("Bombed wall");
        }
    }
}
