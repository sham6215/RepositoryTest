using RepositoryTest.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryTest
{
    class Program
    {
        private static string ConnectionString => "Data Source=\"F:\\Challenger_1.1.9_35\\Databases\\british.db\"; Version=3;foreign keys=true";
        static void Main(string[] args)
        {
            TestRepositories();
        }

        static void TestRepositories()
        {
            using (UnitOfWork uow = new UnitOfWork(ConnectionString))
            {
                var charts = uow.Charts.GetAll().ToList();
                var vCharts = uow.VesselCharts.GetAll().ToList();

                int i = 0;
            }
        }
    }
}
