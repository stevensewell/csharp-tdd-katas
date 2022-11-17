namespace RpgCombat;

public class LevelUnitTests
{
  [Test]
  public void CharacterStartsAtLevel1()
  {
    var character = new Character();
    Assert.That(character.Level, Is.EqualTo(1));
  }
  
  //A Character cannot have a health above 1000 until they reach level 6
  [Test]
  public void CharacterCannotHaveHealthAbove1000UntilLevel6()
  {
    var character = new Character();
    Assert.That(character.Health, Is.EqualTo(1000));
  }
}