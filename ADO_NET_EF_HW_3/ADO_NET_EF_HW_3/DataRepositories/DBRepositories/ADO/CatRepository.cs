using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using WindowsFormsApp_EF_HW_3.Interfaces;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.DataRepositories.DBRepositories.ADO
{
    class CatRepository : IRepository<Cat>
    {
        private readonly string cnnString;

        public CatRepository() => cnnString = ConfigurationManager.ConnectionStrings["Animals"].ConnectionString;

        public CatRepository(string connectionStirng) => cnnString = connectionStirng;

        public void Create(Cat item)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();

                using (SqlCommand insert = cnn.CreateCommand())
                {
                    insert.CommandText = "IF NOT EXISTS(SELECT * FROM Cats WHERE Name LIKE @name) INSERT INTO Cats(Name, Weight) VALUES(@name, @weight)";
                    insert.Parameters.AddWithValue("@name", item.Name);
                    insert.Parameters.AddWithValue("@weight", item.Weight);
                    if (insert.ExecuteNonQuery() == -1)
                    {
                        throw new Exception("Возникла ошибка при доабвлении кота");
                    }
                }
            }
        }

        public void Delete(Cat item)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();

                using (SqlCommand delete = cnn.CreateCommand())
                {
                    delete.CommandText = "DELETE FROM Cats WHERE Name LIKE @userName";
                    delete.Parameters.AddWithValue("@userName", item.Name);
                    if (delete.ExecuteNonQuery() == -1)
                    {
                        throw new Exception("Возникла ошибка при удалии кота по указанной кличке");
                    }
                }
            }
        }

        public Cat Get(int id)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();

                using (SqlCommand get = cnn.CreateCommand())
                {
                    get.CommandText = "SELECT Id, Name, Weight FROM Cats WHERE Id = @userId";
                    get.Parameters.AddWithValue("@userId", id);

                    using (SqlDataReader reader = get.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            return new Cat { Id = reader.GetInt32(0), Name = reader.GetString(1), Weight = reader.GetDouble(2) };
                        }
                        else
                        {
                            throw new Exception("По укзанному индексу не удалось найти кота");
                        }
                    }
                }
            }
        }

        public IEnumerable<Cat> GetAll()
        {
            List<Cat> cats = new List<Cat>();
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();

                using (SqlCommand select = new SqlCommand("SELECT * FROM Cats", cnn))
                {
                    using (SqlDataReader reader = select.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                cats.Add(new Cat { Id = reader.GetInt32(0), Name = reader.GetString(1), Weight = reader.GetDouble(2) });
                            }
                        }
                    }
                }
            }

            return cats;
        }

        public void Update(Cat item)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();

                using (SqlCommand update = cnn.CreateCommand())
                {
                    update.CommandText = "UPDATE Cats SET Name = @name, Weight = @weight WHERE Id = @id";
                    update.Parameters.AddWithValue("@name", item.Name);
                    update.Parameters.AddWithValue("@weight", item.Weight);
                    update.Parameters.AddWithValue("@id", item.Id);
                    if (update.ExecuteNonQuery() == -1)
                    {
                        throw new Exception("Возникла ошибка при обновлении кота");
                    }
                }
            }
        }
    }
}