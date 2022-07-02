using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class WindowImp
    {
        protected Form form;
        protected Button button;
        public abstract Form DevDrawForm();
        public abstract Button DevDrawButton();
    }
}
