using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            MSWindow msWindow = new MSWindow();
            msWindow.Draw();
            Console.ReadKey();
        }
    }
}
