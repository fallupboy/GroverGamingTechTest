using EmployeeDirectory.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDirectory.Repositories.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeRepository() { }

        public void AddEmployee(Employee employee)
        {
            using (EmployeeContext db = new EmployeeContext())
            {
                db.Employees.Add(employee);
                db.SaveChanges();
            }
                    
        }

        public void UpdateEmployee(Employee employee)
        {
            using (EmployeeContext db = new EmployeeContext())
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        
        public void DeleteEmployee(Employee employee)
        {
            using (EmployeeContext db = new EmployeeContext())
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
            }
        }
    }
}
