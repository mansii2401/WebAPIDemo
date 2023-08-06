using WebAPIDemo.Models;

namespace WebAPIDemo.Data
{
    public class EmployeeData
    {

        public static List<Employee> employees = new List<Employee>
    {
        new Employee { Id = 1, Name = "Meeta", Salary = 10000 , FullTime = true },
        new Employee { Id = 2, Name = "Geeta", Salary = 20000 , FullTime = false },
        new Employee { Id = 3, Name = "Reeta", Salary = 30000 , FullTime = true },
    };

    }


}


