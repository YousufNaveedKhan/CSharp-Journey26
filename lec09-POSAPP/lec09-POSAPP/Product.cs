using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec09_POSAPP
{
    internal class Product
    {
        public String name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }   

        public double TotalPrice()
        {
            return price * quantity;
        }
    }
    }
