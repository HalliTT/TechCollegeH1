using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    class Note
    {
        private static int m_Counter = 0;

        public Note()
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

        //Title
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        //Note content // maybe choos diferent kind of content ??
        private string _content;
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        //Tags // Maybe choose betwenn and make own tag ?
        private Tag _tags;
        public Tag Tags
        {
            get { return _tags; }
            set { _tags = value; }
        }
    }
}
