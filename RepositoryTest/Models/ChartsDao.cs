using RepositoryTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryTest.Models
{
    public class ChartsDao
    {
        public IEnumerable<Chart> getBritishCharts(DataContext cntx)
        {
            string query = "SELECT * FROM british_chart ORDER BY prefix, CAST (number AS INTEGER)";
            return cntx.ExecuteQuery<Chart>(query);
        }
    }
}
