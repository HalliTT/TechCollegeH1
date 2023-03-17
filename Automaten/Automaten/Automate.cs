using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//TODO
//DISPLAY ITEM LIST
//SELECT ITEM
//PAYMENT
//DISPLAY ITEM

namespace Automaten
{
    public class Automate
    {
        //Constructor
        public Automate()
        {
            Items.Add(new Items { name = "Milkshake", code = 001 });
        }

        /// Items
        /// <summary>
        /// Set List
        /// </summary>
        public List<Items> Items
        {
            get => default;
            set
            {
                if (value != null)
                    Items = value;
            }
        }

        public Payment Payment
        {
            get => default;
            set
            {
            }
        }

        public void Controls()
        {

            throw new System.NotImplementedException();
        }
    }
}