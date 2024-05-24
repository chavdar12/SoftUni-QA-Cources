namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var studentsWithGrades = new Dictionary<string, List<double>>();
        var count = int.Parse(Console.ReadLine());

        for (var i = 0; i < count; i++)
        {
            var student = Console.ReadLine();
            var grade = double.Parse(Console.ReadLine());

            if (studentsWithGrades.ContainsKey(student))
                studentsWithGrades[student].Add(grade);
            else
                studentsWithGrades.Add(student, new List<double> { grade });
        }

        foreach (var pair in studentsWithGrades)
        {
            var student = pair.Key;
            var averageGrade = pair.Value.Average();
            if (averageGrade >= 4.50) Console.WriteLine($"{student} -> {averageGrade:F2}");
        }
    }
}