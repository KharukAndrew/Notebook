using System.Collections.Generic;

namespace Notebook.Domain.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetForId(int id);
        void Add(T item);
    }
}
