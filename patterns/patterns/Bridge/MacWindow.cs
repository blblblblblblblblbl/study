using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class MacWindow : Window
    {
        public MacWindow()
        {
            this.windowImp = new MacWindowImp();
            this.form = windowImp.DevDrawForm();
            this.button = windowImp.DevDrawButton();
        }

        public override void Draw()
        {
            Console.WriteLine($"set form style to {form.Style}");
            Console.WriteLine($"set button style to {button.Style}");
            base.Draw();
        }
    }
}
