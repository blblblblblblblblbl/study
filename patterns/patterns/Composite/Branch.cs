using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Branch : Component
    {
        private ArrayList _nodes;

        public Branch(string name) : base(name)
        {
            _nodes = new ArrayList();
        }

        public override void Add(Component component)
        {
            _nodes.Add(component);
        }

        public override void Remove(Component component)
        {
            _nodes.Remove(component);
        }

        public override Component GetChild(int index)
        {
            return (Component)_nodes[index];
        }

        public override void Operation()
        {
            Console.WriteLine(Name);
            foreach (Component el in _nodes)
            {
                el.Operation();
            }

        }
    }
}
