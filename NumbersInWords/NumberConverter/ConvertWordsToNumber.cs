namespace NumbersInWords;

public static class ConvertWordsToNumber
{
    public static decimal Convert(string num)
    {
        var words = num.Split(" ");
        
        var (low,total) = words.Aggregate(
            (low: 0m, total: 0m),
            (acc, word) => GetCumulativeTotal(word, acc.low, acc.total));
        
        return low + total;
    }

    private static (decimal, decimal) GetCumulativeTotal(string word, decimal low, decimal total)
    {
        var x = new
        {
            lowV = GetLowNumberFromKey(word),
            scaleV = GetScaleFromKey(word)
        };

        return x switch
        {
            { } when x.lowV != 0 => (x.lowV + low, total),
            { } when x.scaleV != 0 && x.scaleV == 100 => (low * 100, total),
            _ => (0, total + low * x!.scaleV)
        };
    }

    private static decimal GetLowNumberFromKey(string key)
    {
        var dictionaries = new List<Dictionary<decimal, string>>
        {
            NumberDictionary.Ones,
            NumberDictionary.Teens,
            NumberDictionary.Tens
        };

        return dictionaries
            .Select(d => d.ContainsValue(key) ? d.FirstOrDefault(p => p.Value == key).Key : 0)
            .FirstOrDefault(x => x != 0);
    }

    private static decimal GetScaleFromKey(string key)
    {
        return NumberDictionary.Scales.ContainsValue(key)
            ? NumberDictionary.Scales.FirstOrDefault(p => p.Value == key).Key
            : 0;
    }
}