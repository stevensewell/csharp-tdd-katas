namespace VowelCount;

public class Tests
{
    [Test]
    [TestCase("abracadabra", 5)]
    [TestCase("pear tree", 4)]
    [TestCase("o a e asd rfbwe", 5)]
    [TestCase("aeiou", 5)]
    [TestCase("aypyx", 0)]
    public void ShouldCalculateNumberOfVowels(string input, int expected)
    {
        var actual = VowelCount.Calculate(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
}