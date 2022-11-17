namespace LinqKata;

public class Tests
{
  [Test]
  public void SumOfArrayTest()
  {
    Assert.That(Kata.Sum(new[] {2, 3, 1}), Is.EqualTo(6));
  }

  [Test]
  public void CountOccurencesOfCharacterTest()
  {
    Assert.That(Kata.CountChar(new[] {'A', 'B', 'C', 'A'}, 'A'), Is.EqualTo(2));
  }

  [Test]
  public void CalculateSquaresTest()
  {
    Assert.That(Kata.CalculateSquares(2, 6), Is.EqualTo(new[] {4, 9, 16, 25, 36}));
  }

  [Test]
  public void AnimalBySpeciesTest()
  {
    var animals = new List<Animal>
    {
      new Animal {Name = "Bobby", Species = "Dog"},
      new Animal {Name = "Fido", Species = "Dog"},
      new Animal {Name = "Mittens", Species = "Cat"},
      new Animal {Name = "Spot", Species = "Dog"},
      new Animal {Name = "Fluffy", Species = "Cat"},
      new Animal {Name = "Rover", Species = "Dog"},
      new Animal {Name = "Whiskers", Species = "Cat"},
      new Animal {Name = "Spike", Species = "Dog"},
    };

    var result = Kata.AnimalsBySpecies(animals).ToList();

    Assert.Multiple(() =>
    {
      Assert.That(result.FirstOrDefault()!.All(s => s.Species == "Dog"), Is.True);
      Assert.That(result.FirstOrDefault()!.Count(), Is.EqualTo(5));
      Assert.That(result.LastOrDefault()!.All(s => s.Species == "Cat"), Is.True);
      Assert.That(result.LastOrDefault()!.Count(), Is.EqualTo(3));
    });
  }
}