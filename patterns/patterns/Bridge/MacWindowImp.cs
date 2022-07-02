using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class MacWindowImp : WindowImp
    {
        public override Button DevDrawButton()
        {
            button = new Button();
            button.Style = "MacStyleButton";
            return button;
        }

        public override Form DevDrawForm()
        {
            form = new Form();
            form.Style = "MacStyleForm";
            return form;
        }
    }
}
