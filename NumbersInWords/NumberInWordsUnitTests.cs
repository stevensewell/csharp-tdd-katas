namespace NumbersInWords;

public class NumberInWordsUnitTests
{
    [Test]
    [TestCase(1, "one")]
    [TestCase(2, "two")]
    [TestCase(3, "three")]
    [TestCase(4, "four")]
    [TestCase(5, "five")]
    [TestCase(6, "six")]
    [TestCase(7, "seven")]
    [TestCase(8, "eight")]
    [TestCase(9, "nine")]
    [TestCase(10, "ten")]
    public void ShouldConvertAllNumbersUpTo10(int number, string expectedNumberInWords)
    {
        var (_, numberInWords) = new NumberConverter(number);
        Assert.That(numberInWords, Is.EqualTo(expectedNumberInWords));
    }
    
    [Test]
    [TestCase(11, "eleven")]
    [TestCase(12, "twelve")]
    [TestCase(13, "thirteen")]
    [TestCase(14, "fourteen")]
    [TestCase(15, "fifteen")]
    [TestCase(16, "sixteen")]
    [TestCase(17, "seventeen")]
    [TestCase(18, "eighteen")]
    [TestCase(19, "nineteen")]
    public void ShouldConvert11UpTo19(int number, string expectedNumberInWords)
    {
        var (_, numberInWords) = new NumberConverter(number);
        Assert.That(numberInWords, Is.EqualTo(expectedNumberInWords));
    }
}