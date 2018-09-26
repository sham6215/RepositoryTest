using RepositoryTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryTest.Patterns
{
    public class ChartsRepository : IRepository<Chart>
    {
        private DataContext Context { get; set; }

        public ChartsRepository(DataContext context)
        {
            Context = context;
        }

        public void Add(Chart Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Chart Entity)
        {
            throw new NotImplementedException();
        }

        public Chart GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Chart> GetAll()
        {
            ChartsDao dao = new ChartsDao();
            return dao.getBritishCharts(Context);
        }
    }
}
