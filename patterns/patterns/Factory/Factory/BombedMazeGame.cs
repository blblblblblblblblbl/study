

namespace Maze
{
    class BombedMazeGame:MazeGame
    {
        public override Room MakeRoom(int num)
        {
            return new BombedRoom(num);
        }

        public override Wall MakeWall()
        {
            return new BombedWall();
        }
    }
}
