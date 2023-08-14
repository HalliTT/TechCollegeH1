using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    class NoteLink : Note
    {
        private string _link;
        public string Link
        {
            get { return _link; }
            set { _link = value; }
        }
    }
}
