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
  
  //Characters can Deal Damage to Characters
  [Test]
  public void CharacterShouldDealDamageToCharacter()
  {
    var attacker = new Character();
    var defender = new Character();
    attacker.DealDamage(defender, 100);
    Assert.That(defender.Health, Is.EqualTo(900));
  }
}