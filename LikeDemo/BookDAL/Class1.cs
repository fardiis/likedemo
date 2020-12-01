using Microsoft.EntityFrameworkCore;
using System;

namespace BookDAL
{
    public class BookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Initial Catalog=BookLike;integrated Security =True");
            base.OnConfiguring(optionsBuilder);

        }
        public DbSet<Book> Books { get; set; }
    }
}
