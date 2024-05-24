namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var countOfStudents = int.Parse(Console.ReadLine());

        List<Student> students = new();

        for (var i = 1; i <= countOfStudents; i++)
        {
            string[] studentsInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var firstName = studentsInfo[0];
            var lastName = studentsInfo[1];
            var grade = double.Parse(studentsInfo[2]);

            var student = new Student(firstName, lastName, grade);
            students.Add(student);
        }

        students.OrderByDescending(s => s.Grade)
            .Select(s =>
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}: {s.Grade:F2}");

                return 1;
            })
            .ToList();
    }
}