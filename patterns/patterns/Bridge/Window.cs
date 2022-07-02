using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Window
    {
        protected WindowImp windowImp;
        protected Form form;
        protected Button button;
        public virtual void Draw()
        {
            Console.WriteLine("form config");
            Console.WriteLine("add button to form");
            Console.WriteLine("visualize form with button");
        }

    }
}
