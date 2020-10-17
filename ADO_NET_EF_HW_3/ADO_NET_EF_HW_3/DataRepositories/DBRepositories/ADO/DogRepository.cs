using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using WindowsFormsApp_EF_HW_3.Interfaces;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.DataRepositories.DBRepositories.ADO
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
                cnn.Open();

                using (SqlCommand insert = cnn.CreateCommand())
                {
                    insert.CommandText = "IF NOT EXISTS(SELECT * FROM Dogs WHERE Name LIKE @name) INSERT INTO Dogs(Name, Age) VALUES(@name, @age)";
                    insert.Parameters.AddWithValue("@name", item.Name);
                    insert.Parameters.AddWithValue("@age", item.Age);
                    if (insert.ExecuteNonQuery() == -1)
                    {
                        throw new Exception("Возникла ошибка при доабвлении собаки");
                    }
                }
            }
        }

        public void Delete(Dog item)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();

                using (SqlCommand delete = cnn.CreateCommand())
                {
                    delete.CommandText = "DELETE FROM Dogs WHERE Name LIKE @userName";
                    delete.Parameters.AddWithValue("@userName", item.Name);
                    if(delete.ExecuteNonQuery() == -1)
                    {
                        throw new Exception("Ошибка при удалении собаки по указанной кличке");
                    }
                }
            }
        }

        public Dog Get(int id)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();

                using (SqlCommand get = cnn.CreateCommand())
                {
                    get.CommandText = "SELECT Id, Name, Age FROM Dogs WHERE Id = @userId";
                    get.Parameters.AddWithValue("@userId", id);

                    using (SqlDataReader reader = get.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            return new Dog { Id = reader.GetInt32(0), Name = reader.GetString(1), Age = reader.GetInt32(2) };
                        }
                        else
                        {
                            throw new Exception("По укзанному индексу не удалось найти собаку");
                        }
                    }
                }
            }
        }

        public IEnumerable<Dog> GetAll()
        {
            List<Dog> dogs = new List<Dog>();
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();

                using (SqlCommand select = new SqlCommand("SELECT * FROM Dogs", cnn))
                {
                    using (SqlDataReader reader = select.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                dogs.Add(new Dog { Id = reader.GetInt32(0), Name = reader.GetString(1), Age = reader.GetInt32(2) });
                            }
                        }
                    }
                }
            }

            return dogs;
        }

        public void Update(Dog item)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();

                using (SqlCommand update = cnn.CreateCommand())
                {
                    update.CommandText = "UPDATE Dogs SET Name = @name, Age = @age WHERE Id = @id";
                    update.Parameters.AddWithValue("@name", item.Name);
                    update.Parameters.AddWithValue("@age", item.Age);
                    update.Parameters.AddWithValue("@id", item.Id);
                    if(update.ExecuteNonQuery() == -1)
                    {
                        throw new Exception("Возникла ошибка при обновлении собаки");
                    }
                }
            }
        }
    }
}