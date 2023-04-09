using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Try3.Models
{
    public class Cart
    {
        public List<CartItem> items = new List<CartItem>();
        public CartItem item;
        public Cart(CartItem _item)
        {
            item = _item;
            items.Add(item);
        }
    }
}
