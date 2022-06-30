using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class RoomBombed:Room
    {
        public RoomBombed(int num):base(num) { }
        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("BOMB!!!");
        }

        public override Room Clone()
        {
            RoomBombed room = new RoomBombed(RoomNumber);
            foreach (var dir in (Direction[])Enum.GetValues(typeof(Direction)))
            {
                room.SetSide((dir),this.GetSide(dir));
            }
            return room;
        }
    }
}
