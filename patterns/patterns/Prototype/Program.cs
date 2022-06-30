using System;
using System.Threading;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame mazeGame = new MazeGame();
            Maze maze = mazeGame.CreateMaze(new MazeFactoryPrototype(new WallBombed(),new Door(new RoomBombed(1), new RoomBombed(1)),new RoomBombed(1),new Maze()));
            Random random = new Random();
            Room room = maze.RoomNo(random.Next(1, 3));
            MapSite site = null;
            while (true)
            {
                site = room.GetSide((Direction)random.Next(0, 4));
                site.Enter();
                if (site is Door)
                {
                    room = ((Door)site).OtherSideFrom(room);
                }

                Console.WriteLine($"in room {room.RoomNumber}");
                room.Enter();
                Thread.Sleep(800);
            }
        }
    }
}
