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
            maze.AddRoom(MakeRoom(1));
            maze.AddRoom(MakeRoom(2));
            Door door = MakeDoor(maze.RoomNo(1),maze.RoomNo(2));

            maze.RoomNo(1).SetSide(Direction.North, MakeWall());
            maze.RoomNo(1).SetSide(Direction.South, door);
            maze.RoomNo(1).SetSide(Direction.East, MakeWall());
            maze.RoomNo(1).SetSide(Direction.West, MakeWall());

            maze.RoomNo(2).SetSide(Direction.North, door);
            maze.RoomNo(2).SetSide(Direction.South, MakeWall());
            maze.RoomNo(2).SetSide(Direction.East, MakeWall());
            maze.RoomNo(2).SetSide(Direction.West, MakeWall());
            return maze;
        }

        public virtual Room MakeRoom(int num)
        {
            return new Room(num);
        }
        public virtual Wall MakeWall()
        {
            return new Wall();
        }
        public virtual Door MakeDoor(Room r1, Room r2)
        {
            return new Door(r1, r2);
        }
        public virtual Maze MakeMaze()
        {
            return new Maze();
        }
    }
}
