using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        //arrange

        var input = 0;
        //act
        string actual = Triangle.PrintTriangle(input);
        //assert
        Assert.AreEqual("", actual);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        var input = 3;

        var expectedOutput = $"1{Environment.NewLine}" +
                             $"1 2{Environment.NewLine}" +
                             $"1 2 3{Environment.NewLine}" +
                             $"1 2{Environment.NewLine}" +
                             $"1";

        string result = Triangle.PrintTriangle(input);


        Assert.AreEqual(expectedOutput, result);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        var input = 5;

        var expectedOutput = $"1{Environment.NewLine}" +
                             $"1 2{Environment.NewLine}" +
                             $"1 2 3{Environment.NewLine}" +
                             $"1 2 3 4{Environment.NewLine}" +
                             $"1 2 3 4 5{Environment.NewLine}" +
                             $"1 2 3 4{Environment.NewLine}" +
                             $"1 2 3{Environment.NewLine}" +
                             $"1 2{Environment.NewLine}" +
                             $"1";

        string result = Triangle.PrintTriangle(input);

        Assert.AreEqual(expectedOutput, result);
    }
}