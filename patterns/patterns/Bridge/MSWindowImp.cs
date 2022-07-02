using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class MSWindowImp : WindowImp
    {
        public override Button DevDrawButton()
        {
            button = new Button();
            button.Style = "MSStyleButton";
            return button;
        }

        public override Form DevDrawForm()
        {
            form = new Form();
            form.Style = "MSStyleForm";
            return form;
        }
    }
}
