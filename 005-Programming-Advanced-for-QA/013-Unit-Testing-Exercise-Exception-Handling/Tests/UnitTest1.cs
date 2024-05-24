using TestApp;

namespace Tests;

public class Tests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        _exceptions = new Exceptions();
    }

    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        var input = "SoftUni";
        var expected = "inUtfoS";

        // Act
        var actual = _exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string? input = null;

        // Act & Assert
        //Assert.That(() => _exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
        Assert.Throws<ArgumentNullException>(() => _exceptions.ArgumentNullReverse(input), "String cannot be null.");
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        // Arrange
        var totalPrice = 101.25m;
        var discount = 8.1m;
        var expected = 93.04875m;

        // Act
        var actual = _exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        var totalPrice = 101.25m;
        var discount = -0.1m;

        // Act & Assert
        Assert.That(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        var totalPrice = 101.25m;
        var discount = 100.1m;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discount),
            "Discount must be between 0 and 100.");
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        // Arrange
        int[] array = { 1, 5, -1, 100, 19 };
        var index = 2;
        var expected = -1;

        // Act
        var actual = _exceptions.IndexOutOfRangeGetElement(array, index);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 1, 5, -1, 100, 19 };
        var index = -1;

        // Act & Assert
        Assert.That(() => _exceptions.IndexOutOfRangeGetElement(array, index),
            Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        var index = array.Length;

        // Act & Assert
        Assert.Throws<IndexOutOfRangeException>(() => _exceptions.IndexOutOfRangeGetElement(array, index),
            "Index is out of range.");
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        var index = array.Length + 1;

        // Act & Assert
        Assert.Throws<IndexOutOfRangeException>(() => _exceptions.IndexOutOfRangeGetElement(array, index),
            "Index is out of range.");
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        // Arrange
        var isLoggedIn = true;
        var expected = "User logged in.";

        // Act
        var actual = _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);

        // Assert
        Assert.IsTrue(expected.Equals(actual));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        var isLoggedIn = false;

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn),
            "User must be logged in to perform this operation.");
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        var input = "10";
        var expected = 10;

        // Act
        var actual = _exceptions.FormatExceptionParseInt(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        // Arrange
        var input = "10.";

        // Act & Assert
        Assert.Throws<FormatException>(() => _exceptions.FormatExceptionParseInt(input),
            "Input is not in the correct format for an integer.");
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        // Arrange
        var dictionary = new Dictionary<string, int>()
        {
            { "Day of Birth", 18 },
            { "Month of Birth", 9 },
            { "Year of Birth", 1995 }
        };
        var key = "Day of Birth";
        var expected = 18;

        // Act
        var actual = _exceptions.KeyNotFoundFindValueByKey(dictionary, key);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        // Arrange
        var dictionary = new Dictionary<string, int>()
        {
            { "Day of Birth", 18 },
            { "Month of Birth", 9 },
            { "Year of Birth", 1995 }
        };
        var key = "EGN";

        // Act & Assert
        Assert.Throws<KeyNotFoundException>(() => _exceptions.KeyNotFoundFindValueByKey(dictionary, key),
            "The specified key was not found in the dictionary.");
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        // Arrange
        var a = 2147483646;
        var b = 1;
        var expected = int.MaxValue;

        // Act
        var actual = _exceptions.OverflowAddNumbers(a, b);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange
        var a = 2147483647;
        var b = 2147483647;

        // Act & Assert
        Assert.Throws<OverflowException>(() => _exceptions.OverflowAddNumbers(a, b),
            "Arithmetic overflow occurred during addition.");
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange
        var a = -2147483648;
        var b = -2147483648;

        // Act & Assert
        Assert.Throws<OverflowException>(() => _exceptions.OverflowAddNumbers(a, b),
            "Arithmetic overflow occurred during addition.");
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // Arrange
        var dividend = 100;
        var divisor = 2;
        var expected = 50;

        // Act
        var actual = _exceptions.DivideByZeroDivideNumbers(dividend, divisor);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        var dividend = 100;
        var divisor = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _exceptions.DivideByZeroDivideNumbers(dividend, divisor),
            "Division by zero is not allowed.");
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange
        int[] collection = { 10, 20, 30, 40, 50 };
        var index = 0;
        var expected = 150;

        // Act
        var actual = _exceptions.SumCollectionElements(collection, index);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // Arrange
        int[]? collection = null;
        var index = 0;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => _exceptions.SumCollectionElements(collection, index),
            "Collection cannot be null.");
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] collection = { 10, 20, 30, 40, 50 };
        var index = -1;

        // Act & Assert
        Assert.Throws<IndexOutOfRangeException>(() => _exceptions.SumCollectionElements(collection, index),
            "Index has to be within bounds.");
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // Arrange
        var dictionary = new Dictionary<string, string>()
        {
            { "Day of Birth", "18" },
            { "Month of Birth", "9" },
            { "Year of Birth", "1995" }
        };
        var key = "Day of Birth";
        var expected = 18;

        // Act
        var actual = _exceptions.GetElementAsNumber(dictionary, key);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // Arrange
        var dictionary = new Dictionary<string, string>()
        {
            { "Day of Birth", "18" },
            { "Month of Birth", "9" },
            { "Year of Birth", "1995" }
        };
        var key = "EGN";

        // Act & Assert
        Assert.Throws<KeyNotFoundException>(() => _exceptions.GetElementAsNumber(dictionary, key),
            "Key not found in the dictionary.");
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // Arrange
        var dictionary = new Dictionary<string, string>()
        {
            { "Day of Birth", "Invalid" },
            { "Month of Birth", "9" },
            { "Year of Birth", "1995" }
        };
        var key = "Day of Birth";

        // Act & Assert
        Assert.Throws<FormatException>(() => _exceptions.GetElementAsNumber(dictionary, key), "Can't parse string.");
    }
}