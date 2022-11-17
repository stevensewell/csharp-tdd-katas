namespace RpgCombat;

public class Character
{
  public int Health { get; private set; }
  public int Level { get; private set; }
  
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
    if(!IsAlive) return;
    Health += i;
  }
}