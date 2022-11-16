namespace NumbersInWords;

public class NumberInWordsUnitTests
{

    [Test]
    public void ShouldConvert1ToOne()
    {
        var (_, numberInWords) = new NumberConverter(1);
        Assert.That(numberInWords, Is.EqualTo("one"));
    }
}