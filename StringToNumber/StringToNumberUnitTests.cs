namespace StringToNumber;

public class StringToNumberUnitTests
{
    [Test]
    public void ShouldConvert1()
    {
        Assert.That(StringToNumber.Calculate("1"), Is.EqualTo(1));
    }
}