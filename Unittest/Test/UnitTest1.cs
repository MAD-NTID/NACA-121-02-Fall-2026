namespace Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddTwoNumbersIsSum()
    {
        // Setup
        int num1 = 5, num2 = 2;
        int expected = 7;

        // Invoke
        Calculate calculate = new();
        int actual = calculate.Add(num1, num2);

        // Analyze - English like expression
        // Assert That actual Is Equal to expected
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void MultiplyTwoNumberIsProduct()
    {
        int num1 = 5, num2 = 2;
        int expected = 10;

        Calculate calculate = new();
        int actual = calculate.Multiply(num1, num2);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
