using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows.Forms;
using WindowsFormsApp_EF_HW_2.Models;

namespace WindowsFormsApp_EF_HW_2.EF
{
    class DbInitializer : DropCreateDatabaseIfModelChanges<NotebookContext>
    {
        protected override void Seed(NotebookContext db)
        {
            try
            {
                Country country1 = new Country { Name = "Беларусь" };
                Country country2 = new Country { Name = "Россия" };
                Country country3 = new Country { Name = "Украина" };
                db.Countries.AddRange(new List<Country> { country1, country2, country3 });
                db.SaveChanges();

                Person person1 = new Person { Name = "Вася", LastName = "Васильев", Birthday = "01.01.2000", Phone = "+375441112223", CountryId = country1.Id};
                Person person2 = new Person { Name = "Петя", LastName = "Петров", Birthday = "07.05.1995", Phone = "+3752999966655", CountryId = country2.Id };
                Person person3 = new Person { Name = "Коля", LastName = "Николаев", Birthday = "12.11.1996", Phone = "+3754411122234", CountryId = country3.Id };
                Person person4 = new Person { Name = "Игорь", LastName = "Игорев", Birthday = "26.05.1996", Phone = "+375444534663", CountryId = country1.Id };
                db.People.AddRange(new List<Person> { person1, person2, person3, person4 });
                db.SaveChanges(); 

                country1.People.Add(person1);
                country2.People.Add(person2);
                country3.People.Add(person3);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}