using System;

public class Kata
{
  public static int Sum(int[] integers)
  {
    var sum = 0;
    foreach (var i in integers)
    {
      sum += i;
    }

    return sum;
  }

  public static int CountChar(char[] chars, char charToCount)
  {
    var occurences = 0;
    foreach (var c in chars)
    {
      if (c == charToCount)
        occurences++;
    }

    return occurences;
  }

  public static int[] CalculateSquares(int start, int end)
  {
    var result = new int[end - start + 1];
    for (var i = start; i <= end; i++)
    {
      result[i - start] = i * i;
    }

    return result;
  }
  
  public static IEnumerable<IEnumerable<Animal>> AnimalsBySpecies(IEnumerable<Animal> animals)
  {
    var result = new List<List<Animal>>();
    foreach (var animal in animals)
    {
      var species = result.FirstOrDefault(x => x[0].Species == animal.Species);
      if (species == null)
      {
        species = new List<Animal>();
        result.Add(species);
      }

      species.Add(animal);
    }

    return result;
  }
}

public class Animal
{
  public string Name { get; set; }
  public string Species { get; set; }
}