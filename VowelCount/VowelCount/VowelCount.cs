namespace VowelCount;

public static class VowelCount
{
    private static IEnumerable<char> _vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
    
    public static int Calculate(string str) => str.Count(c => _vowels.Contains(c));
}