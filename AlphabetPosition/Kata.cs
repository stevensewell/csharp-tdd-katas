namespace AlphabetPosition;

public class Kata
{
  public static object? AlphabetPosition(string input)
  {
    return input.Select(CalculatePosition).Aggregate((acc, next) => string.IsNullOrWhiteSpace(next) ? acc : $"{acc} {next}");
  }

  private static string CalculatePosition(char arg)
  {
    return !char.IsLetter(arg) 
      ? string.Empty 
      : (char.ToUpper(arg) - 64).ToString();
  }
}