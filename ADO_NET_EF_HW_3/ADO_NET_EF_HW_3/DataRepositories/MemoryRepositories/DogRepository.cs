using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp_EF_HW_3.Interfaces;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.DataRepositories.MemoryRepositories
{
    class DogRepository : IRepository<Dog>
    {
        static List<Dog> dogs = new List<Dog>();

        static DogRepository()
        {
            Dog dog1 = new Dog { Id = 1, Name = "Апрель", Age = 10 };
            Dog dog2 = new Dog { Id = 2, Name = "Месси", Age = 3 };
            Dog dog3 = new Dog { Id = 3, Name = "Хави", Age = 12 };
            Dog dog4 = new Dog { Id = 4, Name = "Касильяс", Age = 6 };
            dogs.AddRange(new List<Dog> { dog1, dog2, dog3, dog4 });
        }

        public DogRepository() { }

        public void Create(Dog item)
        {
            if(dogs.Any(d => d.Name == item.Name))
            {
                throw new Exception("Попытка добавить существующую собаку");
            }
            else
            {
                int lastId = dogs.Last().Id;
                item.Id = ++lastId;
                dogs.Add(item);
            }
        }

        public void Delete(Dog item)
        {
            if(!dogs.Any(d => d.Name == item.Name))
            {
                throw new Exception("Собаки с указанной кличкой не существует");
            }
            else
            {
                dogs.Remove(dogs.First(d => d.Name == item.Name));
            }
        }

        public Dog Get(int id)
        {
            if(!dogs.Any(d => d.Id == id))
            {
                throw new Exception("По указанному индексу не было найдено собаки");
            }
            else
            {
                return dogs.First(d => d.Id == id);
            }
        }

        public IEnumerable<Dog> GetAll() => dogs;

        public void Update(Dog item)
        {
            Dog dog = dogs.FirstOrDefault(d => d.Id == item.Id);
            dog.Name = item.Name;
            dog.Age = item.Age;
        }
    }
}