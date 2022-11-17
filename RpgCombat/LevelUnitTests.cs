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
  
  //when the maximum increases to 1500
  [Test]
  public void CharacterCanHaveMaxHealthOf1500AtLevel6()
  {
    var character = new Character();
    character.LevelUp(); //2
    character.LevelUp(); //3
    character.LevelUp(); //4
    character.LevelUp(); //5
    character.LevelUp(); //6
    Assert.That(character.Health, Is.EqualTo(1500));
  }
  
  //If the target is 5 or more Levels above the attacker, Damage is reduced by 50%
  [Test]
  public void ShouldReduceDamageBy50PercentIfTargetIs5OrMoreLevelsAboveTheAttacker()
  {
    var attacker = new Character();
    var target = new Character();
    target.LevelUp(); //2
    target.LevelUp(); //3
    target.LevelUp(); //4
    target.LevelUp(); //5
    target.LevelUp(); //6
    attacker.DealDamage(target, 100); //deal 50% of 100 = 50
    Assert.That(target.Health, Is.EqualTo(1450));
  }
}