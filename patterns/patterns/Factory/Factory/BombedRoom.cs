
using System;

namespace Maze
{
    class BombedRoom:Room
    {
        public BombedRoom(int num):base(num) { }
        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("there is bomb in the room!");
        }
    }
}
