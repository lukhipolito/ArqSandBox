using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
    public interface IRepositoryManager<T>
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        T Get(int id);
        IList<T> List();
    }
}
