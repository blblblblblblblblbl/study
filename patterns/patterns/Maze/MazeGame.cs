using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class MazeGame
    {
        public Maze CreateMaze()
        {
            Maze maze = new Maze();
            maze.AddRoom(new Room(1));
            maze.AddRoom(new Room(2));
            Door door = new Door(maze.RoomNo(1),maze.RoomNo(2));

            maze.RoomNo(1).SetSide(Direction.North,new Wall());
            maze.RoomNo(1).SetSide(Direction.South, door);
            maze.RoomNo(1).SetSide(Direction.East, new Wall());
            maze.RoomNo(1).SetSide(Direction.West, new Wall());

            maze.RoomNo(2).SetSide(Direction.North, door);
            maze.RoomNo(2).SetSide(Direction.South, new Wall());
            maze.RoomNo(2).SetSide(Direction.East, new Wall());
            maze.RoomNo(2).SetSide(Direction.West, new Wall());
            return maze;
        }
    }
}
