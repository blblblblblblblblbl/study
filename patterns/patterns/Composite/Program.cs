using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Branch root = new Branch("root");
            Branch branch1 = new Branch("branch1");
            Branch branch2 = new Branch("branch2");
            for (int i = 1; i < 6; ++i)
            {
                branch1.Add(new Leaf($"Leaf{i}"));
                branch2.Add(new Leaf($"Leaf{i}"));
            }
            root.Add(branch1);
            root.Add(branch2);
            root.Operation();
        }
    }
}
