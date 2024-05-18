namespace Ex009;

internal class Program
{
    private static void Main(string[] args)
    {
        var password = Console.ReadLine();


        var isValidLength = password.Length >= 6 && password.Length <= 10;


        var isValidContent = CheckContent(password);

        var isValidCountDigits = CheckCountDigits(password);


        if (isValidLength == true && isValidContent == true && isValidCountDigits == true)
        {
            Console.WriteLine("Password is valid");
        }
        else
        {
            if (isValidLength == false) Console.WriteLine("Password must be between 6 and 10 characters");


            if (isValidContent == false) Console.WriteLine("Password must consist only of letters and digits");


            if (isValidCountDigits == false) Console.WriteLine("Password must have at least 2 digits");
        }
    }

    private static bool CheckContent(string password)
    {
        for (var position = 0; position <= password.Length - 1; position++)
        {
            var symbol = password[position];


            if (char.IsLetterOrDigit(symbol) == false) return false;
        }


        return true;
    }


    private static bool CheckCountDigits(string password)
    {
        var count = 0;
        for (var position = 0; position <= password.Length - 1; position++)
        {
            var symbol = password[position];

            if (char.IsDigit(symbol) == true) count++;
        }


        return count >= 2;
    }
}