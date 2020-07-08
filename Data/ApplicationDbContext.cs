
using Data.Entity;
using Data.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        internal ApplicationDbContext(string nameOrConnectionString)
         : base(nameOrConnectionString = "DefaultConnection")
        {
        }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {

        }
        public IDbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
        }

        }
    }
