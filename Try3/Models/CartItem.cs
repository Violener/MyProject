using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Try3.Models
{
    public class CartItem
    {
        public Book book;
        public int count;
        public CartItem(Book bokkk,int ccount)
        {
            book = bokkk;
            count = ccount;
        }
        
    }
}
