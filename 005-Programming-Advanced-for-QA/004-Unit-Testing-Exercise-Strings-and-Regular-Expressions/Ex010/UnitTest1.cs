using TestApp;

namespace Ex010;

public class Tests
{
    [TestCase("john@example.com")]
    [TestCase("jane.doe@example.co.uk")]
    [TestCase("info123@test-domain.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Act
        var result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("john@example")]
    [TestCase("jane.doe@example")]
    [TestCase("info123@test-domain")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Act
        var result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.False);
    }
}