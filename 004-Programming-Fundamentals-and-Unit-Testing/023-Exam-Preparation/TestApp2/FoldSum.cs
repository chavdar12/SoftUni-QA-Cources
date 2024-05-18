namespace TestApp2;

public class FoldSum
{
    public static string FoldArray(int[] arr)
    {
        var k = arr.Length / 4;

        var topRow = arr
            .Take(k)
            .Reverse()
            .Concat(arr.Skip(arr.Length - k).Reverse())
            .ToArray();

        var bottomRow = arr
            .Skip(k)
            .Take(k * 2)
            .ToArray();

        var result = string.Empty;
        for (var i = 0; i < topRow.Length; i++) result += $"{topRow[i] + bottomRow[i]} ";

        return result.Trim();
    }
}