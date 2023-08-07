using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Try3.Models;
using Microsoft.AspNetCore.Session;
using Microsoft.EntityFrameworkCore;

namespace Try3.Controllers
{
    public class HomeController : Controller
    {
        BookContext bookContext;
        
        
        public HomeController(BookContext book)
        {
            bookContext = book;
        }

        
        
           public  async Task<IActionResult> Index(int page = 1)
            {
                int pageSize = 2;   // количество элементов на странице

                IQueryable<Book> source = bookContext.Books;
                var count = await source.CountAsync();
                var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

                PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
                IndexViewModel viewModel = new IndexViewModel
                {
                    PageViewModel = pageViewModel,
                    Books = items
                };
                return View(viewModel);
            
           
        }
        [HttpGet]
        public IActionResult About(string name)
        {
            Book book = bookContext.Books.FirstOrDefault(bokk => bokk.Name == name);
            return View(book);
        }
        
        public IActionResult AddToCart(int id,int count)
        {

          
            
            
            if (HttpContext.Session.Keys.Contains("someKey"))
            {
                Book book = bookContext.Books.FirstOrDefault(bokk => bokk.Id == id);
                CartItem cart = new CartItem(book, count);
                
                var classCollection = HttpContext.Session.Get<Cart>("someKey");
                classCollection.items.Add(cart);
                HttpContext.Session.Set<Cart>("someKey", classCollection);
                
            }
            else
            {
                Book book = bookContext.Books.FirstOrDefault(bokk => bokk.Id == id);
                CartItem cart = new CartItem(book, count);

                Cart c = new Cart(cart);
                var hope = c.items.ToList();
                HttpContext.Session.Set<Cart>("someKey", c);
            }
            return RedirectToAction("Index");
        }


        public IActionResult Cart()
        {
            if (HttpContext.Session.Keys.Contains("someKey"))
            {
                var classCollection = HttpContext.Session.Get<Cart>("someKey");
                var c = classCollection.items.ToList();

                return View(c);

            }
            return View();
        }

       
    }
}
