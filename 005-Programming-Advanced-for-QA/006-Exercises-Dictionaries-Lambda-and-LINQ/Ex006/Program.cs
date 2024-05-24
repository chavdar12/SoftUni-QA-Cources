namespace Ex006;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, HashSet<string>> companies = new();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] data = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            var companyName = data[0];
            var employeeId = data[1];

            if (!companies.ContainsKey(companyName)) companies[companyName] = new HashSet<string>();

            companies[companyName].Add(employeeId);
        }

        foreach (var kvp in companies)
        {
            Console.WriteLine(kvp.Key);
            foreach (var employeeId in kvp.Value) Console.WriteLine($"-- {employeeId}");
        }
    }
}