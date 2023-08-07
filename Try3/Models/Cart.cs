using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Try3.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public List<CartItem> items;
        public CartItem item;
        public Cart()
        {
            items = new List<CartItem>();
        }
        public Cart(CartItem _item)
        {
            items = new List<CartItem>();
            item = _item;
            items.Add(item);
        }
    }
}
