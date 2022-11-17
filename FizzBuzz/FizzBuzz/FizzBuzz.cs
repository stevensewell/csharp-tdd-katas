namespace FizzBuzz;

public static class FizzBuzz
{
    public static IList<string> Calculate(int count)
    {
      return Enumerable.Range(1, count)
        .Select(DetermineFizzBuzz)
        .ToList();
    }

    private static string DetermineFizzBuzz(int number)
    {
        return number switch
        {
            _ when number % 3 == 0 => "Fizz",
        };
    }
    
    [Test]
    public static void DivisibleByThree()
    {
        Assert.That(DetermineFizzBuzz(3), Is.EqualTo("Fizz"));
    }
    
    [Test]
    public static void DivisibleByFive()
    {
        Assert.That(DetermineFizzBuzz(5), Is.EqualTo("Buzz"));
    }
}