using System;
using Microsoft.EntityFrameworkCore;
using ApiAspnetCore.Models;

namespace ApiAspnetCore.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DataContext(DbContextOptions<DataContext> options): base(options)
       {}
    }
}