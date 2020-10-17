using System.Data.Entity;
using WindowsFormsApp_EF_HW_3.DataRepositories.DBRepositories.EF.Initializer;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.DataRepositories.DBRepositories.EF.Context
{
    class AnimalsContext: DbContext
    {
        static AnimalsContext() => Database.SetInitializer(new AnimalsInitializer());

        public AnimalsContext() : base() { }

        public AnimalsContext(string connectionString) : base(connectionString) { }

        public DbSet<Cat> Cats { get; set; }

        public DbSet<Dog> Dogs { get; set; }
    }
}