//this class acts as Director in builder pattern

namespace Maze
{
    class MazeGame
    {
        public Maze CreateMaze(ConcreteMazeBuilder builder)
        {
            builder.BuildMaze();
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1,2);
            return builder.GetMaze();
        }
    }
}
