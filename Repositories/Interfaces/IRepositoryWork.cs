using ConsoleAppPracticWork_1_var1.Model;

namespace ConsoleAppPracticWork_1_var1.Repositories.Interfaces
{
    public interface IRepositoryWork
    {
        void CameToWork(Employee employee);
        void EscapeFromWork(Employee employee);
    }
}