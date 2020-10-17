using System.Collections.Generic;

namespace WindowsFormsApp_EF_HW_3.Interfaces
{
    interface IRepository<T> where T: class
    {
        void Create(T item);

        void Update(T item);

        void Delete(T item);

        T Get(int id);

        IEnumerable<T> GetAll();
    }
}