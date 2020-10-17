using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp_EF_HW_3.Interfaces;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.DataRepositories.MemoryRepositories
{
    class CatRepository : IRepository<Cat>
    {
        private static List<Cat> cats = new List<Cat>();

        static CatRepository()
        {
            Cat cat1 = new Cat { Id = 1, Name = "Вертиль", Weight = 2.33 };
            Cat cat2 = new Cat { Id = 2, Name = "Лопасть", Weight = 5 };
            Cat cat3 = new Cat { Id = 3, Name = "Гав", Weight = 1.31 };
            Cat cat4 = new Cat { Id = 4, Name = "Март", Weight = 6.8 };
            cats.AddRange(new List<Cat> { cat1, cat2, cat3, cat4 });
        }

        public CatRepository() { }

        public void Create(Cat item)
        {
            if(cats.Any(c => c.Name == item.Name))
            {
                throw new Exception("Попытка добавить существующего кота");
            }
            else
            {
                int lastId = cats.Last().Id;
                item.Id = ++lastId;
                cats.Add(item);
            }
        }

        public void Delete(Cat item)
        {
            if(!cats.Any(c => c.Name == item.Name))
            {
                throw new Exception("Кота с указанной кличкой не существует");
            }
            else
            {
                cats.Remove(cats.First(c => c.Name == item.Name));
            }
        }

        public Cat Get(int id)
        {
            if(!cats.Any(c => c.Id == id))
            {
                throw new Exception("По указанному индексу не было найдено кота");
            }
            else
            {
                return cats.First(c => c.Id == id);
            }
        }

        public IEnumerable<Cat> GetAll() => cats;

        public void Update(Cat item)
        {
            Cat cat = cats.First(c => c.Id == item.Id);
            cat.Name = item.Name;
            cat.Weight = item.Weight;
        }
    }
}