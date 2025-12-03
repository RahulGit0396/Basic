using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfoManager
{
    internal class Employee
    {
        int Id { get; set; }
        String Name { get; set; }
        String Salary { get; set; }
        public Employee()
        {
            Id = 0;
            Name = string.Empty;
            Salary = string.Empty;
        }
        void AddEmployeeDetails(int EmpId, String EmpName, String EmpSalary)
        {
            Id = EmpId;
            Name = EmpName;
            Salary= EmpSalary;
        }
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            List<Employee> list = new List<Employee>();

            emp.Id = 1;
            emp.Name = "Rahul";
            emp.Salary = "75000";
            list.Add(emp);

            Employee emp2 = new Employee();
            emp2.AddEmployeeDetails(2, "Ruchi", "45000");
            list.Add(emp2);

            Employee emp3 = new Employee();
            emp3.AddEmployeeDetails(3, "Sarthak", "35000");
            list.Add(emp3);

            emp3.AddEmployeeDetails(4, "Aman", "40000");
            list.Add(emp3);

            foreach(var employee in list)
            {
                Console.WriteLine($"ID {employee.Id}, Name {employee.Name}, Salary {employee.Salary}");                
                Console.WriteLine($"Bonus %: {Convert.ToDouble(employee.Salary) * 0.10}");
                if (Convert.ToDouble(employee.Salary) >= 45000)
                {
                    Console.WriteLine(employee.Name + " has salary more than 45K");
                }
            }
        }
    }
}
