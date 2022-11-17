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
  
  [Test]
  public void CharacterShouldDealDamageToCharacter()
  {
    var attacker = new Character();
    var defender = new Character();
    attacker.DealDamage(defender, 100);
    Assert.That(defender.Health, Is.EqualTo(900));
  }
  
  [Test]
  public void CharacterShouldDieWhenHealthIsZero()
  {
    var attacker = new Character();
    var defender = new Character();
    attacker.DealDamage(defender, 1000);
    Assert.That(defender.IsAlive, Is.False);
  }
  
  //A Character cannot Deal Damage to itself
  [Test]
  public void CharacterCannotDealDamageToItself()
  {
    var attacker = new Character();
    attacker.DealDamage(attacker, 100);
    Assert.That(attacker.Health, Is.EqualTo(1000));
  }
  
  //A Character can Heal themselves.
  [Test]
  public void CharacterCanHealItself()
  {
    var attacker = new Character();
    var defender = new Character();
    attacker.DealDamage(defender, 100);
    defender.Heal(100);
    Assert.That(defender.Health, Is.EqualTo(1000));
  }
  
  //Dead characters cannot heal
  [Test]
  public void DeadCharacterCannotHeal()
  {
    var attacker = new Character();
    var defender = new Character();
    attacker.DealDamage(defender, 1000);
    defender.Heal(100);
    Assert.That(defender.Health, Is.EqualTo(0));
  }
}