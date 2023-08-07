using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Try3.Models
{
    public class BookContext : DbContext 
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
       





        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
           Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>()
         .HasKey(c => c.ID);

            modelBuilder.Entity<Order>()
         .HasKey(c => c.ID);

            modelBuilder.Entity<Book>().HasData(
                    new Book ( 1, "Tom" ),
                    new Book ( 2, "Bob" ),
                    new Book ( 3, "Sam" )
            );
           
           
        }
    }
}
