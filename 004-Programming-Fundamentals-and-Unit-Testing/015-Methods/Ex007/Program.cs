namespace Ex007;

internal class Program
{
    private static void Main(string[] args)
    {
        var type = Console.ReadLine();

        switch (type)
        {
            case "int":
            {
                var numberOne = int.Parse(Console.ReadLine());
                var numberTwo = int.Parse(Console.ReadLine());
                Console.WriteLine(GetGreaterInt(numberOne, numberTwo));
                break;
            }
            case "char":
            {
                var firstChar = char.Parse(Console.ReadLine());
                var secondChar = char.Parse(Console.ReadLine());
                Console.WriteLine(GetGreaterChar(firstChar, secondChar));
                break;
            }
            case "string":
            {
                var firstText = Console.ReadLine();
                var secondText = Console.ReadLine();
                Console.WriteLine(GetGreaterString(firstText, secondText));
                break;
            }
        }
    }

    private static int GetGreaterInt(int number1, int number2)
    {
        return number1 > number2 ? number1 : number2;
    }


    private static char GetGreaterChar(char char1, char char2)
    {
        return char1 > char2 ? char1 : char2;
    }

    private static string GetGreaterString(string string1, string string2)
    {
        return string1 == string2 ? string1 : string2;
    }
}