using RepositoryTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryTest.Patterns
{
    public class VesselChartsRepository : IRepository<VesselChart>
    {
        private DataContext Context { get; set; }

        public VesselChartsRepository(DataContext context)
        {
            Context = context;
        }

        public void Add(VesselChart Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(VesselChart Entity)
        {
            throw new NotImplementedException();
        }

        public VesselChart GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VesselChart> GetAll()
        {
            VesselChartsDao dao = new VesselChartsDao();
            return dao.getVesselBritishCharts(Context);
        }
    }
}
