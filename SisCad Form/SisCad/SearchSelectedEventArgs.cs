using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SisCad
{
    public class SearchSelectedEventArgs : EventArgs
    {
        public readonly object selected;
        public SearchSelectedEventArgs(object selected)
        {
            this.selected = selected;
        }
    }
}
