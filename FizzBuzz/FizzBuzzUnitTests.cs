namespace FizzBuzz;

public partial class FizzBuzzUnitTests
{
    [Test]
    public void ShouldCalculateUpTo100()
    {
        var result = FizzBuzz.Calculate(100);
        Assert.That(result, Is.EqualTo(_fizzBuzzExpectedResultUpTo100));
    }
}