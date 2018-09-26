using RepositoryTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryTest.Patterns
{
    public interface IUnitOfWork
    {
        IRepository<Chart> Charts { get; }
        IRepository<VesselChart> VesselCharts { get; }
    }
}
