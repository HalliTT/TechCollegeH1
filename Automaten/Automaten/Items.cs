using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Items
    {
        private string Name { set { Name = value; } get { return Name; } }
        private int Code { set { Code = value; } get { return Code; } }

        private string _price;
        public string Price {
            set {
                if (Price != null)
                {
                    _price = value;
                }
            }
            get {
                return Price;
            }
        }
        private int Quantaty { set { Quantaty = value; } get { return Quantaty; } }

        protected static List<Items> Item = new List<Items>();

        //Constructor
        public Items()
        {
            Item.Add(this);
        }
        public void PrintList()
        {
            foreach (object items in Item)
            {
                Console.WriteLine(items);
            }
        }

    }

}
