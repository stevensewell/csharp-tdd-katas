namespace FizzBuzz;

public static class FizzBuzz
{
    public static IList<string> Calculate(int count)
    {
    }
    
    [Test]
    public static void DivisibleByThree()
    {
        Assert.That(DetermineFizzBuzz(3), Is.EqualTo("Fizz"));
    }
}