using ConsoleAppPracticWork_1_var1.Model;
using ConsoleAppPracticWork_1_var1.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPracticWork_1_var1.Modules
{
    public class Worker
    {
        private readonly IRepositoryWork repositoryWork;

        public Worker(IRepositoryWork _repositoryWork)
        {
            repositoryWork = _repositoryWork;
        }

        public void CameToWork(Employee employee)
        {
            repositoryWork.CameToWork(employee);
        }

        public void EscapeFromWork(Employee employee)
        {
            repositoryWork.EscapeFromWork(employee);
        }
    }
}
