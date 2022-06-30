using System;
using System.Diagnostics;
using System.Threading;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            //MazeGame mazeGame = new MazeGame();
            MazeGame mazeGame = new BombedMazeGame();
            Maze maze = mazeGame.CreateMaze();
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

                Console.WriteLine($"in  {room.RoomNumber}");
                room.Enter();
                Thread.Sleep(800);
            }
        }
    }
}
