using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using WindowsFormsApp_EF_HW_3.DataRepositories.DBRepositories.EF.Context;
using WindowsFormsApp_EF_HW_3.Interfaces;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.DataRepositories.DBRepositories.EF.Repositories
{
    class CatRepository : IRepository<Cat>
    {
        private readonly string connectionString;
        private AnimalsContext db;

        public CatRepository()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(localdb)\mssqllocaldb";
            builder.InitialCatalog = "Animals";
            builder.AttachDBFilename = System.Windows.Forms.Application.StartupPath + @"\Db\Animals.mdf";
            builder.IntegratedSecurity = true;
            connectionString = builder.ConnectionString;
            db = new AnimalsContext(connectionString);
        }

        public CatRepository(string connectionString) => this.connectionString = connectionString;

        public void Create(Cat item)
        {
            using (db = new AnimalsContext(connectionString))
            {
                if(db.Cats.Any(c => c.Name == item.Name))
                {
                    throw new Exception("Попытка добавления существующего кота");
                }
                else
                {
                    db.Cats.Add(item);
                    db.SaveChanges();
                }
            }
        }

        public void Delete(Cat item)
        {
            using (db = new AnimalsContext(connectionString))
            {
                if(db.Cats.Any(c => c.Name == item.Name))
                {
                    db.Cats.Remove(db.Cats.First(c => c.Name == item.Name));
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Не удалось найти кота по указанной кличке");
                }
            }
        }

        public Cat Get(int id)
        {
            using (db = new AnimalsContext(connectionString))
            {
                if (db.Cats.Any(c => c.Id == id))
                {
                    return db.Cats.First(c => c.Id == id);
                }
                else
                {
                    throw new Exception("По указанному индексу не нашлось кота");
                }
            }
        }

        public IEnumerable<Cat> GetAll()
        {
            using (db = new AnimalsContext(connectionString))
            {
                return db.Cats.ToList();
            }
        }

        public void Update(Cat item)
        {
            using (db = new AnimalsContext(connectionString))
            {
                Cat cat = db.Cats.FirstOrDefault(c => c.Id == item.Id);
                cat.Name = item.Name;
                cat.Weight = item.Weight;
                db.SaveChanges();
            }
        }
    }
}