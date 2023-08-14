using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    class Tag
    {
        private static int m_Counter = 0;

        public Tag()
        {
            Id = System.Threading.Interlocked.Increment(ref m_Counter);
        }

        //Id
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        //Tags // Maybe choose betwenn and make own tag ?
        private string _tags;
        public string Tags
        {
            get { return _tags; }
            set { _tags = value; }
        }
    }
}
