using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread
{
    internal class Program
    {
        static List<Student> GetStudentData() =>
            Enumerable.Range(1, 10).Select(i => new Student
            {
                ID = i,
                Name = $"Student-{i}"
            }).ToList();

        static async Task<int> ProcessStudentAsync(Student student)
        {
            await Task.Delay(100);
            Console.WriteLine($"Processing data for {student.Name}");
            return student.ID * 2;
        }

        static async Task Main()
        {
            var students = GetStudentData();
            var results = await Task.WhenAll(students.Select(ProcessStudentAsync));
            Console.WriteLine($"Total processed data: {results.Sum()}");
        }
    }
}
