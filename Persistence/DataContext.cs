using System;
using Domain;
using Microsoft.EntityFrameworkCore;


namespace Persistence
{
    //we will use this class to create our database and we derive from dbcontext framework
    //DB context instance represents instance of the database
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

    //values will be used as a table name in sql light
        public DbSet<Value> Values{ get; set; }
    //protected means it can be accessed form this class and any class that drevives from this one only
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>().HasData
                (
                    new Value{ID=1, name="Value 101" },
                    new Value{ID=2, name="Value 102" },
                    new Value{ID=3, name="Value 103" }
                );
            {
                
            }
        }
    }
}
