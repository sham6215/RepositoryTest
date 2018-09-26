using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryTest.Models;

namespace RepositoryTest.Patterns
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private SQLiteConnection Connection { get; set; }
        private DataContext Context { get; set; }
        public IRepository<Chart> Charts { get; private set; }
        public IRepository<VesselChart> VesselCharts { get; private set; }

        public UnitOfWork(string connectionString)
        {
            Connection = new SQLiteConnection(connectionString);
            Context = new DataContext(Connection);
            Charts = new ChartsRepository(Context) as IRepository<Chart>;
            VesselCharts = new VesselChartsRepository(Context) as IRepository<VesselChart>;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
