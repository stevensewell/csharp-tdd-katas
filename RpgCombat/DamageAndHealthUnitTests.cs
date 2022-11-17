namespace RpgCombat;

public class DamageAndHealthUnitTests
{
  
  [Test]
  public void CharacterShouldHaveStartingHealthOf1000()
  {
    var character = new Character();
    Assert.That(character.Health, Is.EqualTo(1000));
  }
  
  [Test]
  public void CharacterShouldStartAsAlive()
  {
    var character = new Character();
    Assert.That(character.IsAlive, Is.True);
  }
}