using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class LockedDoor:Door
    {
        public LockedDoor(Room room1, Room room2) : base(room1, room2)
        {
        }

        public override void Enter()
        {
            Console.WriteLine("the door is locked");
        }

        public override Room OtherSideFrom(Room room)
        {
            return room;
        }
    }
}
