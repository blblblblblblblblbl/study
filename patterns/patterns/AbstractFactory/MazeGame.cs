using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class MazeGame
    {
        public Maze CreateMaze(MazeFactory mazeFactory)
        {
            Maze maze = mazeFactory.CreateMaze();
            maze.AddRoom(mazeFactory.CreateRoom(1));
            maze.AddRoom(mazeFactory.CreateRoom(2));
            Door door = mazeFactory.CreateDoor(maze.RoomNo(1),maze.RoomNo(2));

            maze.RoomNo(1).SetSide(Direction.North,mazeFactory.CreateWall());
            maze.RoomNo(1).SetSide(Direction.South, door);
            maze.RoomNo(1).SetSide(Direction.East, mazeFactory.CreateWall());
            maze.RoomNo(1).SetSide(Direction.West, mazeFactory.CreateWall());

            maze.RoomNo(2).SetSide(Direction.North, door);
            maze.RoomNo(2).SetSide(Direction.South, mazeFactory.CreateWall());
            maze.RoomNo(2).SetSide(Direction.East, mazeFactory.CreateWall());
            maze.RoomNo(2).SetSide(Direction.West, mazeFactory.CreateWall());
            return maze;
        }
    }
}
