
namespace Maze
{
    abstract class MazeBuilder
    {
        abstract public void BuildRoom(int num);
        abstract public void BuildDoor(int room1, int room2);
        abstract public void BuildMaze();
        abstract public Maze GetMaze();
    }
}
