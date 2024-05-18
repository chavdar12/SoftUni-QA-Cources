using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        var noInputFibonacci = 0;

        int actualResult = Fibonacci.CalculateFibonacci(noInputFibonacci);
        var expectedResult = 0;

        Assert.That(actualResult == expectedResult);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        var fibonacci = 7;

        int actualResult = Fibonacci.CalculateFibonacci(fibonacci);
        var expectedResult = 13;

        Assert.AreEqual(expectedResult, actualResult);
    }
}