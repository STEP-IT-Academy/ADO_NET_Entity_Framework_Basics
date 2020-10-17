using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using WindowsFormsApp_EF_HW_3.Interfaces;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.DataRepositories.DBRepositories.Dapper
{
    class CatRepository : IRepository<Cat>
    {
        private readonly string cnnString;

        public CatRepository() => cnnString = ConfigurationManager.ConnectionStrings["Animals"].ConnectionString;

        public CatRepository(string connectionString) => cnnString = connectionString;

        public void Create(Cat item)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                string insertQuery = "IF NOT EXISTS(SELECT * FROM Cats WHERE Name LIKE @name) INSERT INTO Cats(Name, Weight) VALUES(@name, @weight)";
                if(cnn.Execute(insertQuery, new { item.Name, item.Weight }) == -1)
                {
                    throw new Exception("При добавлении кота возникла ошибка");
                }
            }
        }

        public void Delete(Cat item)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                if (cnn.Execute("DELETE FROM Cats WHERE Name = @name", new { item.Name }) == -1)
                {
                    throw new Exception("При удалении кота возникла ошибка");
                }
            }
        }

        public Cat Get(int id)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                return cnn.Query<Cat>("SELECT * FROM Cats WHERE Id = @id", new { id}).First();
            }
        }

        public IEnumerable<Cat> GetAll()
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                return cnn.Query<Cat>("SELECT * FROM Cats");
            }
        }

        public void Update(Cat item)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                if(cnn.Execute("UPDATE Cats SET Name = @name, Weight = @weight WHERE Id = @id", new {item.Name, item.Weight, item.Id }) == -1)
                {
                    throw new Exception("При обновлении кота возникла ошибка");
                }
            }
        }
    }
}