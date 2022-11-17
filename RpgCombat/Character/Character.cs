namespace RpgCombat;

public class Character
{
  public int Health { get; private set; }
  public int Level { get; private set; }

  private int _maxHealth { get; set; }

  public Character()
  {
    Health = 1000;
    Level = 1;
  }

  public bool IsAlive => Health > 0;

  public void DealDamage(Character defender, int i)
  {
    if (defender != this) defender.Health -= i;
  }

  public void Heal(int i)
  {
    if (!IsAlive) return;
    Health += i;
  }

  public void LevelUp()
  {
    Level++;
    
    if(Level == 6)
      _maxHealth = 1500;
    
    Health = _maxHealth;
  }
}