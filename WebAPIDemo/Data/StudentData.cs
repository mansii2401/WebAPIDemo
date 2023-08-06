using WebAPIDemo.Models;

namespace WebAPIDemo.Data
{
    public class StudentData
    {
        public static List<Student> students = new List<Student>
     {
        new Student { Id = 101, Name = "Alia", Age = 25, Course = "Science" },
        new Student { Id = 102, Name = "Sonali", Age = 24, Course = "English" },
     };
    }
}
