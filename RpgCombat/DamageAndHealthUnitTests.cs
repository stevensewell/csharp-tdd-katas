namespace RpgCombat;

public class DamageAndHealthUnitTests
{
  
  [Test]
  public void CharacterShouldHaveStartingHealthOf1000()
  {
    var character = new Character();
    Assert.AreEqual(1000, character.Health);
  }
}