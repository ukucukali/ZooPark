using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("name= connect")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());
        }   
        public DbSet<Animal> Animals{ get; set; }
        public DbSet<Food> Food{ get; set; }
        public DbSet<Keeper> Keepers{ get; set; }
}
}
