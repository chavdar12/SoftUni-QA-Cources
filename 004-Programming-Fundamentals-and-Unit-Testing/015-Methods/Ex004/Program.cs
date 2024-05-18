namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var w = int.Parse(Console.ReadLine());
        var l = int.Parse(Console.ReadLine());

        Console.WriteLine(GetRectArea(w, l));
    }

    private static int GetRectArea(int width, int length)
    {
        var area = width * length;
        return area;
    }
}