using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Automaten
    {
        public static void newTest()
        {
            ItemCollection.ListOfItems.Add(new Items { Name = "Mars bar", Code = 11, Price = 14.95, Quantaty = 12 });
            ItemCollection.ListOfItems.Add(new Items { Name = "Snickers bar", Code = 12, Price = 14.95, Quantaty = 5 });

        }
    }
}
