using DB_CRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DB_CRUD.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<User> Categories { get; set; }
    }
}
