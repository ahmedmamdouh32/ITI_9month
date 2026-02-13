using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day4.Entites
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>    
            optionsBuilder.UseSqlServer("data source=AHMED\\SQLEXPRESS;initial catalog=BookStoreDB;integrated security=true;trust server certificate=true");
        public virtual DbSet<Author> Authors { set; get; }
        public virtual DbSet<Book> Books{ set; get; }
        public virtual DbSet<Category> Categories { set; get; }
    }
}
