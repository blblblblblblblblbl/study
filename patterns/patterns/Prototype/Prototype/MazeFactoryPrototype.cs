
namespace Maze
{
    class MazeFactoryPrototype:MazeFactory
    {
        private Wall _wallProtype = null;
        private Door _doorProtype = null;
        private Room _roomProtype = null;
        private Maze _mazeProtype = null;

        public MazeFactoryPrototype(Wall wallProtype, Door doorProtype, Room roomProtype, Maze mazeProtype)
        {
            _wallProtype = wallProtype;
            _doorProtype = doorProtype;
            _roomProtype = roomProtype;
            _mazeProtype = mazeProtype;
        }

        public override Wall CreateWall()
        {
            return _wallProtype.Clone();
        }
        public override Door CreateDoor(Room room1, Room room2)
        {
            Door door = _doorProtype.Clone();
            door.Initialize(room1,room2);
            return door;
        }
        public override Room CreateRoom(int num)
        {
            Room room = _roomProtype.Clone();
            room.Initialize(num);
            return room;
        }
        public override Maze CreateMaze()
        {
            return new Maze();
        }
    }
}

