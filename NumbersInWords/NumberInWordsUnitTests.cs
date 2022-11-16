namespace NumbersInWords;

public partial class NumberInWordsUnitTests
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

    [Test]
    [TestCase(20, "twenty")]
    [TestCase(30, "thirty")]
    [TestCase(40, "forty")]
    [TestCase(50, "fifty")]
    [TestCase(60, "sixty")]
    [TestCase(70, "seventy")]
    [TestCase(80, "eighty")]
    [TestCase(90, "ninety")]
    public void ShouldConvert20UpTo90IncrementsOf10(int number, string expectedNumberInWords)
    {
        var (_, numberInWords) = new NumberConverter(number);
        Assert.That(numberInWords, Is.EqualTo(expectedNumberInWords));
    }

    [Test]
    [TestCase(21, "twenty one")]
    [TestCase(22, "twenty two")]
    [TestCase(23, "twenty three")]
    [TestCase(24, "twenty four")]
    [TestCase(25, "twenty five")]
    [TestCase(26, "twenty six")]
    [TestCase(27, "twenty seven")]
    [TestCase(28, "twenty eight")]
    [TestCase(29, "twenty nine")]
    public void ShouldConvert21UpTo29(int number, string expectedNumberInWords)
    {
        var (_, numberInWords) = new NumberConverter(number);
        Assert.That(numberInWords, Is.EqualTo(expectedNumberInWords));
    }

    [Test]
    [TestCaseSource(nameof(_21To99Source))]
    public void ShouldConvertAllNumbersUpTo99((decimal, string) testCase)
    {
        var (number, expectedNumberInWords) = testCase;
        var (_, numberInWords) = new NumberConverter(number);
        Assert.That(numberInWords, Is.EqualTo(expectedNumberInWords));
    }
    
    [Test]
    [TestCase(100, "one hundred")]
    [TestCase(200, "two hundred")]
    [TestCase(300, "three hundred")]
    [TestCase(400, "four hundred")]
    [TestCase(500, "five hundred")]
    [TestCase(600, "six hundred")]
    [TestCase(700, "seven hundred")]
    [TestCase(800, "eight hundred")]
    [TestCase(900, "nine hundred")]
    public void ShouldConvert100UpTo900IncrementsOf100(decimal number, string expectedNumberInWords)
    {
        var (_, numberInWords) = new NumberConverter(number);
        Assert.That(numberInWords, Is.EqualTo(expectedNumberInWords));
    }
    
    [Test]
    [TestCaseSource(nameof(_100To999Source))]
    public void ShouldConvertAllNumbersUpTo999((decimal, string) testCase)
    {
        var (number, expectedNumberInWords) = testCase;
        var (_, numberInWords) = new NumberConverter(number);
        Assert.That(numberInWords, Is.EqualTo(expectedNumberInWords));
    }
    
    [Test]
    [TestCase(1000, "one thousand")]
    [TestCase(2000, "two thousand")]
    [TestCase(3000, "three thousand")]
    [TestCase(4000, "four thousand")]
    [TestCase(5000, "five thousand")]
    [TestCase(6000, "six thousand")]
    [TestCase(7000, "seven thousand")]
    [TestCase(8000, "eight thousand")]
    [TestCase(9000, "nine thousand")]
    public void ShouldConvert1000UpTo9000IncrementsOf1000(decimal number, string expectedNumberInWords)
    {
        var (_, numberInWords) = new NumberConverter(number);
        Assert.That(numberInWords, Is.EqualTo(expectedNumberInWords));
    }
    
    [Test]
    [TestCaseSource(nameof(_1000To9999Source))]
    public void ShouldConvertAllNumbersUpTo9999((decimal, string) testCase)
    {
        var (number, expectedNumberInWords) = testCase;
        var (_, numberInWords) = new NumberConverter(number);
        Assert.That(numberInWords, Is.EqualTo(expectedNumberInWords));
    }
    
    [Test]
    [TestCase(10000, "ten thousand")]
    [TestCase(24325, "twenty four thousand three hundred twenty five")]
    [TestCase(100000, "one hundred thousand")]
    [TestCase(890154, "eight hundred ninety thousand one hundred fifty four")]
    [TestCase(94154, "ninety four thousand one hundred fifty four")]
    [TestCase(992342, "nine hundred ninety two thousand three hundred forty two")]
    public void ShouldConvertRandomBigNumbersFrom9999to999999(decimal number, string expectedNumberInWords)
    {
        var (_, numberInWords) = new NumberConverter(number);
        Assert.That(numberInWords, Is.EqualTo(expectedNumberInWords));
    }
}