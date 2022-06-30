using System;
using System.Diagnostics;
using System.Threading;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame mazeGame = new MazeGame();
            Maze maze = mazeGame.CreateMaze(new ConcreteMazeBuilder());
            Random random = new Random();
            Room room = maze.RoomNo(random.Next(1, 3));
            MapSite site = null;
            while (true)
            {
                site = room.GetSide((Direction)random.Next(0, 4));
                site.Enter();
                if (site is Door)
                {
                    room = ((Door) site).OtherSideFrom(room);
                }

                Console.WriteLine($"in room {room.RoomNumber}");
                Thread.Sleep(800);
            }
        }
    }
}
