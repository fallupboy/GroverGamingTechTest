using EmployeeDirectory.Models;

namespace EmployeeDirectory.Repositories
{
    public interface IEmployeeRepository
    {
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
