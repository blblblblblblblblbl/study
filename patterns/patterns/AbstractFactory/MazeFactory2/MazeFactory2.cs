using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    sealed class MazeFactory2:MazeFactory
    {
        public override Wall CreateWall()
        {
            return new BombedWall();
        }
        public override Door CreateDoor(Room room1, Room room2)
        {
            return new LockedDoor(room1, room2);
        }
        
    }
}
