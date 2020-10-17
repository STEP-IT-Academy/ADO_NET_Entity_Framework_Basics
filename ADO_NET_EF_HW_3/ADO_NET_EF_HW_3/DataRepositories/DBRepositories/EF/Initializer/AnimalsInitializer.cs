using System.Collections.Generic;
using System.Data.Entity;
using WindowsFormsApp_EF_HW_3.DataRepositories.DBRepositories.EF.Context;
using WindowsFormsApp_EF_HW_3.Models;

namespace WindowsFormsApp_EF_HW_3.DataRepositories.DBRepositories.EF.Initializer
{
    class AnimalsInitializer : DropCreateDatabaseAlways<AnimalsContext>
    {
        protected override void Seed(AnimalsContext db)
        {
            Cat cat1 = new Cat { Name = "Лолик", Weight = 2.2 };
            Cat cat2 = new Cat { Name = "Болик", Weight = 5 };
            Cat cat3 = new Cat { Name = "Анаболик", Weight = 3.6 };
            db.Cats.AddRange(new List<Cat> { cat1, cat2, cat3 });
            db.SaveChanges();

            Dog dog1 = new Dog { Name = "Изя", Age = 12 };
            Dog dog2 = new Dog { Name = "Илья", Age = 5 };
            Dog dog3 = new Dog { Name = "Фант", Age = 2 };
            db.Dogs.AddRange(new List<Dog> { dog1, dog2, dog3 });
            db.SaveChanges();
        }
    }
}