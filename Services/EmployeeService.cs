
using ReportAPI.Models;
using System.Runtime.CompilerServices;

namespace ReportAPI.Services
{
     public interface IEmployeeService
    {
        public List<EmployeeDetails> GetEmployees();

        public List<EmployeeDetails> GetEmployees(int empId);

        public List<EmployeeDetails> GetEmployeesByDepartment(int deptId);
    }

    public class EmployeeService : IEmployeeService
    {
        public EmployeeService()
        {

        }

        private List<Employee> _employees = new List<Employee>
        {
            new Employee(1, "Tosa", 25, 1),
            new Employee(2, "Tosa 2", 26, 2),
            new Employee(3, "Tosa 3", 27, 3),
            new Employee(4, "Tosa 4", 28, 1),
            new Employee(5, "Tosa 5", 29, 2),
            new Employee(6, "Tosa 6", 30, 3)
        };

        private List<Department> _departments = new List<Department>
        {
            new Department(1, "IT"),
            new Department(2, "Finance"),
            new Department(3, "HR")
        };

        public List<EmployeeDetails> GetEmployees()
        {
            return _employees.Select(
                emp => new EmployeeDetails
                {
                    Id = emp.Id,
                    Name = emp.Name,
                    Age = emp.Age,
                    DeptName = _departments.First(d => d.Id == emp.DeptId).Name,
                })
                .ToList();
        }

        public List<EmployeeDetails> GetEmployees(int empId)
        {
            return _employees.Where(emp => emp.Id == empId)
                .Select(
                    emp => new EmployeeDetails
                    {
                        Id = emp.Id,
                        Name = emp.Name,
                        Age = emp.Age,
                        DeptName = _departments.First(d => d.Id == emp.DeptId).Name,
                    })
                .ToList();
        }

        public List<EmployeeDetails> GetEmployeesByDepartment(int deptId)
        {
            return _employees.Where(emp => emp.DeptId == deptId)
                .Select(
                    emp => new EmployeeDetails
                    {
                        Id = emp.Id,
                        Name = emp.Name,
                        Age = emp.Age,
                        DeptName = _departments.First(d => d.Id == deptId).Name,
                    })
                .ToList();
        }
    }
}
