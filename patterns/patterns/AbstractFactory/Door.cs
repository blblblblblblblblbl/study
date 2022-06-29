using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Door:MapSite
    {
        private Room room1;
        private Room room2;
        private bool isOpen;

        public Door(Room room1, Room room2)
        {
            this.room1 = room1;
            this.room2 = room2;
        }

        public override void Enter()
        {
            Console.WriteLine("open the door");
        }

        public virtual Room OtherSideFrom(Room room)
        {
            if (room1 == room)
            {
                return room2;
            }

            return room1;
        }
    }
}
