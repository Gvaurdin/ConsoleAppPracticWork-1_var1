using ConsoleAppPracticWork_1_var1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPracticWork_1_var1.Data
{
    public class WorkerContext : DbContext
    {
        public DbSet<Employee> employees { get; set; } = null!;

        public DbSet<WorkerJournal> workerJournals { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1I3N93J;Initial Catalog=MyWorkerService;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
