using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppPracticWork_1_var1.Model;
using ConsoleAppPracticWork_1_var1.Repositories.Interfaces;

namespace ConsoleAppPracticWork_1_var1.Repositories
{
    public class RepositoryWork : IRepositoryWork
    {
        public void CameToWork(Employee employee)
        {
            var currentDate = DateTime.Now;
            Console.WriteLine($"{employee.LastName} {employee.FirstName} came to work {currentDate}");
        }

        public void EscapeFromWork(Employee employee)
        {
            var currentDate = DateTime.Now;
            Console.WriteLine($"{employee.LastName} {employee.FirstName} escape from work {currentDate}");
        }
    }
}
