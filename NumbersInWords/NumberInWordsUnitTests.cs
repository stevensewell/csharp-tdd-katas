namespace NumbersInWords;

public class NumberInWordsUnitTests
{

  [Test]
  public void ShouldConvert1ToOne()
  {
    var (_, numberInWords) = NumberConverter(1)
    Assert.AreEqual("one", numberInWords);
  }
}