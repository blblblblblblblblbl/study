using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Room: MapSite
    {
        public int RoomNumber { get; set; } = 0;
        private Dictionary<Direction, MapSite> _sides;

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
            _sides = new Dictionary<Direction, MapSite>(4);
            foreach (Direction side in (Direction[])Enum.GetValues(typeof(Direction)))
            {

                _sides.Add(side, null);
            }
        }

        public override void Enter()
        {
            Console.WriteLine("Room");
        }

        public void SetSide(Direction direction, MapSite side)
        {
            _sides[direction]=side;
        }

        public MapSite GetSide(Direction direction)
        {
            return _sides[direction];
        }
    }
}
