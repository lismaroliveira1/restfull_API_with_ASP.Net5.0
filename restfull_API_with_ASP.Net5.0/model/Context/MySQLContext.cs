using System;
using Microsoft.EntityFrameworkCore;

namespace restfull_API_with_ASP.Net5._0.model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
            
    }
}
