using System.Data.Entity;
using WindowsFormsApp_EF_HW_2.Models;

namespace WindowsFormsApp_EF_HW_2.EF
{
    class NotebookContext : DbContext
    {
        static NotebookContext() => Database.SetInitializer(new DbInitializer());

        public NotebookContext() : base() { }

        public NotebookContext(string connectionString) : base(connectionString) { }

        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<Person> People { get; set; }
    }
}