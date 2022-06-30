
using System;

namespace Maze
{
    class ConcreteMazeBuilder:MazeBuilder
    {
        private Maze _maze;

        public ConcreteMazeBuilder()
        {
            _maze = null;
        }

        public override void BuildRoom(int num)
        {
            Room room = new Room(num);
            foreach (Direction dir in (Direction[])Enum.GetValues(typeof(Direction)))
            {
                room.SetSide(dir,new Wall());
            }
            _maze.AddRoom(room);
        }

        public override void BuildDoor(int room1, int room2)
        {
            bool IsR1hasWall = false;
            bool IsR2hasWall = false;
            Room r1 = _maze.RoomNo(room1);
            Room r2 = _maze.RoomNo(room2);
            foreach (Direction dir in (Direction[])Enum.GetValues(typeof(Direction)))
            {
                IsR1hasWall = IsR1hasWall || (r1.GetSide(dir) is Wall);
            }
            foreach (Direction dir in (Direction[])Enum.GetValues(typeof(Direction)))
            {
                IsR2hasWall = IsR2hasWall || (r2.GetSide(dir) is Wall);
            }

            if (IsR1hasWall && IsR2hasWall == false)
            {
                return;
            }

            Door door = new Door(r1, r2);
            {
                foreach (Direction dir in (Direction[])Enum.GetValues(typeof(Direction)))
                {
                    if (r1.GetSide(dir) is Wall)
                    {
                        r1.SetSide(dir,door);
                        break;
                        
                    }
                }
                foreach (Direction dir in (Direction[])Enum.GetValues(typeof(Direction)))
                {
                    if (r2.GetSide(dir) is Wall)
                    {
                        r2.SetSide(dir, door);
                        break;
                    }
                }

            }
            
        }

        public override void BuildMaze()
        {
            _maze = new Maze();
        }

        public override Maze GetMaze()
        {
            return _maze;
        }
    }
}
