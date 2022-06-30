using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maze;

namespace Maze
{
    class MazeFactory
    {
        public virtual Wall CreateWall()
        {
            return new Wall();
        }
        public virtual Door CreateDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
        public virtual Room CreateRoom(int num)
        {
            return new Room(num);
        }
        public virtual Maze CreateMaze()
        {
            return new Maze();
        }
    }
}
