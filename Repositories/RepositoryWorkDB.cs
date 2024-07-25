using ConsoleAppPracticWork_1_var1.Data;
using ConsoleAppPracticWork_1_var1.Model;
using ConsoleAppPracticWork_1_var1.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPracticWork_1_var1.Repositories
{
    public class RepositoryWorkerDB : IRepositoryWork
    {
        public void CameToWork(Employee employee)
        {
            using var context = new WorkerContext();
            var workerJournal = new WorkerJournal
            {
                DateCameWork = DateTime.Now,
                EmployeeId = employee.Id
            };

            context.workerJournals.Add(workerJournal);
            context.SaveChanges();
        }

        public void EscapeFromWork(Employee employee)
        {
            using var context = new WorkerContext();

            var workerJournal = context.workerJournals.Where(x => x.EmployeeId == employee.Id && x.EscapeCameWork == null).First();
            workerJournal.EscapeCameWork = DateTime.Now;
            context.SaveChanges();
        }
    }
}
