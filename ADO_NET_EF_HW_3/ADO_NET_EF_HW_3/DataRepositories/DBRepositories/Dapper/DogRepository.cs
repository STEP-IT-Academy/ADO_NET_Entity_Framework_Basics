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
    class DogRepository : IRepository<Dog>
    {
        private readonly string cnnString;

        public DogRepository() => cnnString = ConfigurationManager.ConnectionStrings["Animals"].ConnectionString;

        public DogRepository(string connectionString) => cnnString = connectionString;

        public void Create(Dog item)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                string insertQuery = "IF NOT EXISTS(SELECT * FROM Dogs WHERE Name LIKE @name) INSERT INTO Dogs(Name, Age) VALUES(@name, @age)";
                if (cnn.Execute(insertQuery, new { item.Name, item.Age }) == -1)
                {
                    throw new Exception("При добавлении собаки возникла ошибка");
                }
            }
        }

        public void Delete(Dog item)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                if(cnn.Execute("DELETE FROM Dogs WHERE Name = @name", new { item.Name }) == -1)
                {
                    throw new Exception("При удалении собаки возникла ошибка");
                }
            }
        }

        public Dog Get(int id)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                return cnn.Query<Dog>("SELECT * FROM Dogs WHERE Id = @id", new { id }).First();
            }
        }

        public IEnumerable<Dog> GetAll()
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                return cnn.Query<Dog>("SELECT * FROM Dogs");
            }
        }

        public void Update(Dog item)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                if (cnn.Execute("UPDATE Dogs SET Name = @name, Age = @age WHERE Id = @id", new { item.Name, item.Age, item.Id }) == -1)
                {
                    throw new Exception("При обновлении собаки возникла ошибка");
                }
            }
        }
    }
}