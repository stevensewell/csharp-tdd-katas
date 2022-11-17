namespace RpgCombat;

public class Character
{
  public int Health { get; }
  
  public Character()
  {
    Health = 1000;
  }

  public bool IsAlive => Health >= 0;
}