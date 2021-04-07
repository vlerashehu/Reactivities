using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;


namespace Persistence
{
  
        public class DataContext: DbContext
        {
            
            public DataContext(DbContextOptions options ): base(options)
            {
            }
            public DbSet<Value> Values {get; set;}

            protected override void OnModelCreating(ModelBuilder builder)
            {
                builder.Entity<Value>()
                    .HasData(
                        new Value{id = 1, Name = "Value Anna"},
                        new Value{id = 2, Name = "Value Nicole"},
                        new Value{id = 3, Name = "Value Bob"}
                    );

            }
        }
}