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
            foreach (var dir in (Direction[])Enum.GetValues(typeof(Direction)))
            {
                _sides.Add(dir,null);
            }
        }

        public virtual Room Clone()
        {
            Room room = new Room(RoomNumber);
            foreach (var dir in (Direction[])Enum.GetValues(typeof(Direction)))
            {
                room._sides[dir] = _sides[dir];
            }
            return new Room(RoomNumber);
        }

        public virtual void Initialize(int num)
        {
            RoomNumber = num;
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
