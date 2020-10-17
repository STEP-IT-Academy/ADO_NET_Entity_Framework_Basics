using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using WindowsFormsApp_EF_HW_3.DataRepositories.DBRepositories.EF.Context;
using WindowsFormsApp_EF_HW_3.Interfaces;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.DataRepositories.DBRepositories.EF.Repositories
{
    class DogRepository : IRepository<Dog>
    {
        private readonly string connectionString;
        private AnimalsContext db;

        public DogRepository()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(localdb)\mssqllocaldb";
            builder.InitialCatalog = "Animals";
            builder.AttachDBFilename = System.Windows.Forms.Application.StartupPath + @"\Db\Animals.mdf";
            builder.IntegratedSecurity = true;
            connectionString = builder.ConnectionString;
            db = new AnimalsContext(connectionString);
        }

        public DogRepository(string connectionString) => this.connectionString = connectionString;

        public void Create(Dog item)
        {
            using (db = new AnimalsContext(connectionString))
            {
                if (db.Dogs.Any(c => c.Name == item.Name))
                {
                    throw new Exception("Попытка добавления существующего кота");
                }
                else
                {
                    db.Dogs.Add(item);
                    db.SaveChanges();
                }
            }
        }

        public void Delete(Dog item)
        {
            using (db = new AnimalsContext(connectionString))
            {
                if (db.Dogs.Any(d => d.Name == item.Name))
                {
                    db.Dogs.Remove(db.Dogs.First(d => d.Name == item.Name));
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Не удалось найти собаку по указанной кличке");
                }
            }
        }

        public Dog Get(int id)
        {
            using (db = new AnimalsContext(connectionString))
            {
                if(db.Dogs.Any(d => d.Id == id))
                {
                    return db.Dogs.First(d => d.Id == id);
                }
                else
                {
                    throw new Exception("По указанному индексу не нашлось собаки");
                }
            }
        }

        public IEnumerable<Dog> GetAll()
        {
            using (db = new AnimalsContext(connectionString))
            {
                return db.Dogs.ToList();
            }
        }

        public void Update(Dog item)
        {
            using (db = new AnimalsContext(connectionString))
            {
                Dog dog = db.Dogs.FirstOrDefault(c => c.Id == item.Id);
                dog.Name = item.Name;
                dog.Age = item.Age;
                db.SaveChanges();
            }
        }
    }
}