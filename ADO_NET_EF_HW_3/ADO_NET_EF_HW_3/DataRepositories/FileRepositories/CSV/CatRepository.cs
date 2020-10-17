using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WindowsFormsApp_EF_HW_3.Interfaces;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.DataRepositories.FileRepositories.CSV
{
    class CatRepository : IRepository<Cat>
    {
        private readonly string fileName;

        public CatRepository() => fileName = @"..\..\AppData\Cats.txt";

        public CatRepository(string fileName) => this.fileName = fileName;

        public void Create(Cat item)
        {
            List<string> lines = File.ReadAllLines(fileName).ToList();
            if(!lines.Any(s => s.Split(';')[1].Contains(item.Name)))
            {
                int lastId = Convert.ToInt32(lines.Last().Split(';')[0]);
                lines.Add($"{++lastId};{item.Name};{item.Weight};");

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(string.Join(Environment.NewLine, lines.ToArray()));
                }
            }
            else
            {
                throw new Exception("Попытка добавления существующего кота");
            }
        }

        public void Delete(Cat item)
        {
            List<string> lines = File.ReadAllLines(fileName).ToList();

            if (lines.Any(s => s.Split(';').Contains(item.Name)))
            {
                lines.Remove(lines.First(l => l.Split(';').Contains(item.Name)));
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(string.Join(Environment.NewLine, lines.ToArray()));
                }
            }
            else
            {
                throw new Exception("Не удалось найти кота по указанной кличке");
            }
        }

        public Cat Get(int id)
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string item in lines)
            {
                if(Convert.ToInt32(item.Split(';')[0]) == id)
                {
                    return new Cat { Id = id, Name = item.Split(';')[1], Weight = Convert.ToDouble(item.Split(';')[2]) };
                }
            }

            throw new Exception("По указанному индексу не нашлось кота");
        }

        public IEnumerable<Cat> GetAll()
        {
            List<Cat> cats = new List<Cat>();
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(';');
                    cats.Add(new Cat { Id = Convert.ToInt32(line[0]), Name = line[1], Weight = Convert.ToDouble(line[2]) });
                }
            }

            return cats;
        }

        public void Update(Cat item)
        {
            List<string> lines = File.ReadAllLines(fileName).ToList();
            string cat = lines.Where(l => Convert.ToInt32(l.Split(';')[0]) == item.Id).First();
            lines.RemoveAt(lines.IndexOf(cat));
            lines.Insert(lines.IndexOf(cat), $"{item.Id};{item.Name};{item.Weight};");

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(string.Join(Environment.NewLine, lines.ToArray()));
            }
        }
    }
}