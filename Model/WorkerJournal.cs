using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPracticWork_1_var1.Model
{
    public class WorkerJournal
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public DateTime DateCameWork { get; set; }

        public DateTime? EscapeCameWork { get; set; }
    }
}
