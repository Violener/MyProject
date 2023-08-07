using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Try3.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public Cart cart { get; set; }
        
      

        public Order()
        {
        }

        public Order(string name, Cart _cart) : this()
        {
            UserName = name;
            cart = _cart;
        }



    }
}
