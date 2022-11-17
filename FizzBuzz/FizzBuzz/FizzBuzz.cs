namespace FizzBuzz;

public static class FizzBuzz
{
    public static string Calculate(int count)
    {
        var list = Enumerable.Range(1, count)
            .Select(DetermineFizzBuzz)
            .ToList();

        return string.Join(Environment.NewLine, list);
    }

    private static string DetermineFizzBuzz(int number)
    {
        var divisibleByThree = number % 3 == 0;
        var divisibleByFive = number % 5 == 0;
        
        return number switch
        {
            _ when divisibleByThree && divisibleByFive => "FizzBuzz",
            _ when divisibleByThree => "Fizz",
            _ when divisibleByFive => "Buzz",
            _ => number.ToString()
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
    
    [Test]
    public static void DivisibleByThreeAndFive()
    {
        Assert.That(DetermineFizzBuzz(15), Is.EqualTo("FizzBuzz"));
    }
    
    [Test]
    public static void NotDivisibleByThreeOrFive()
    {
        Assert.That(DetermineFizzBuzz(1), Is.EqualTo("1"));
    }
}