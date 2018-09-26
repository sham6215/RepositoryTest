using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryTest.Patterns
{
    public interface IRepository<T> where T : class
    {
        void Add(T Entity);
        void Delete(T Entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
