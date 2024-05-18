namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        var command = Console.ReadLine();

        while (command != "end")
        {
            if (command.StartsWith("Contains"))
            {
                var numberContained = int.Parse(command.Split(" ")[1]);
                if (numbers.Contains(numberContained))
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No such number");
            }
            else if (command == "PrintEven")
            {
                foreach (var number in numbers)
                    if (number % 2 == 0)
                        Console.Write(number + " ");
                Console.WriteLine();
            }
            else if (command == "PrintOdd")
            {
                foreach (var number in numbers)
                    if (number % 2 != 0)
                        Console.Write(number + " ");
                Console.WriteLine();
            }
            else if (command == "GetSum")
            {
                Console.WriteLine(numbers.Sum());
            }
            else if (command.StartsWith("Filter"))
            {
                var condition = command.Split(" ")[1];
                var number = int.Parse(command.Split(" ")[2]);
                switch (condition)
                {
                    case "<":
                        numbers.RemoveAll(numberInList => numberInList >= number);
                        break;
                    case ">":
                        numbers.RemoveAll(numberInList => numberInList <= number);
                        break;
                    case "<=":
                        numbers.RemoveAll(numberInList => numberInList > number);
                        break;
                    case ">=":
                        numbers.RemoveAll(numberInList => numberInList < number);
                        break;
                }
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}