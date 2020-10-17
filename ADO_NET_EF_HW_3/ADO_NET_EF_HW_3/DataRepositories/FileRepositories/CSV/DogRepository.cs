﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WindowsFormsApp_EF_HW_3.Interfaces;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.DataRepositories.FileRepositories.CSV
{
    class DogRepository : IRepository<Dog>
    {
        private readonly string fileName;

        public DogRepository() => fileName = @"..\..\AppData\Dogs.txt";

        public DogRepository(string fileName) => this.fileName = fileName;

        public void Create(Dog item)
        {
            List<string> lines = File.ReadAllLines(fileName).ToList();
            if (!lines.Any(s => s.Split(';')[1].Contains(item.Name)))
            {
                int lastId = Convert.ToInt32(lines.Last().Split(';')[0]);
                lines.Add($"{++lastId};{item.Name};{item.Age};");

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(string.Join(Environment.NewLine, lines.ToArray()));
                }
            }
            else
            {
                throw new Exception("Попытка добавления существующеq собаки");
            }
        }

        public void Delete(Dog item)
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
                throw new Exception("Не удалось найти собаку по указанной кличке");
            }
        }

        public Dog Get(int id)
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string item in lines)
            {
                if (Convert.ToInt32(item.Split(';')[0]) == id)
                {
                    return new Dog { Id = id, Name = item.Split(';')[1], Age = Convert.ToInt32(item.Split(';')[2]) };
                }
            }

            throw new Exception("По указанному индексу не нашлось кота");
        }

        public IEnumerable<Dog> GetAll()
        {
            List<Dog> dogs = new List<Dog>();
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(';');
                    dogs.Add(new Dog { Id = Convert.ToInt32(line[0]), Name = line[1], Age = Convert.ToInt32(line[2]) });
                }
            }

            return dogs;
        }

        public void Update(Dog item)
        {
            List<string> lines = File.ReadAllLines(fileName).ToList();
            string dog = lines.Where(l => Convert.ToInt32(l.Split(';')[0]) == item.Id).First();
            lines.RemoveAt(lines.IndexOf(dog));
            lines.Insert(lines.IndexOf(dog), $"{item.Id};{item.Name};{item.Age};");

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(string.Join(Environment.NewLine, lines.ToArray()));
            }
        }
    }
}