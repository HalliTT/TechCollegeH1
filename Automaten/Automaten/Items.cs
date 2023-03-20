using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Items
    {
        //Constructor
        public Items()
        {

        }

        private string _name;
        public string Name { set { _name = value; } get { return _name; } }

        
        private int _code;
        public int Code { set { _code = value; } get { return _code; } }

        
        private double _price;
        public double Price {
            set {
                    _price = value;
            }
            get {
                return _price;
            }
        }

        private int _quantaty;
        public int Quantaty { set { _quantaty = value; } get { return _quantaty; } }


        public override string ToString()
        {
            return $"{_name} for {_price} enter code: {_code}";
        }
    }

    class ItemCollection
    {
        public static List<Items> ListOfItems = new List<Items>();
        
        public static void PrintList()
        {
            foreach (Items item in ListOfItems)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static Items SelectObject(int code)
        {
            Items FoundItem = ListOfItems.Find(x => x.Code == code);
            return FoundItem;
        }

        public static dynamic PrintObject(Items code, string type)
        {
            if (type == "name")
            {
                return code.Name;
            }
            if (type == "code")
            {
                return code.Code;
            }
            if (type == "price")
            {
                return code.Price;
            }
            if (type == "quantaty")
            {
                return code.Quantaty;
            }
            return code;
        }
    }

}
