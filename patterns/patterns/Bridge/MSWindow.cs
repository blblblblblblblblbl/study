using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class MSWindow : Window
    {
        public MSWindow()
        {
            this.windowImp = new MSWindowImp();
            this.button = windowImp.DevDrawButton();
            this.form = windowImp.DevDrawForm();
        }

        public override void Draw()
        {
            Console.WriteLine($"set form style to {form.Style}");
            Console.WriteLine($"set button style to {button.Style}");
            base.Draw();
        }
    }
}
