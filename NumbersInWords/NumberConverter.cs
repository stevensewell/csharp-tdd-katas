namespace NumbersInWords;

public class NumberConverter
{
    private readonly decimal _number;
    private readonly string _numberInWords;

    public NumberConverter(decimal number)
    {
        _number = number;
        _numberInWords = ConvertNumberToWords(number);
    }

    private string ConvertNumberToWords(decimal number)
    {
        return number switch
        {
            <= 10 => NumberDictionary.Ones.TryGetValue(number, out var value) ? value : string.Empty,
            < 20 => NumberDictionary.Teens.TryGetValue(number, out var value) ? value : string.Empty,
            <= 99 => ConvertTens(number),
            <= 999 => ConvertScale(number, 100),
            <= 999999 => ConvertScale(number, 1000),
            <= 999999999 => ConvertScale(number, 1000000),
            _ => throw new ArgumentOutOfRangeException(nameof(number), number, null)
        };
    }

    private string ConvertScale(decimal number, int scale = 100)
    {
        var baseNumber = Math.Floor(number / scale);
        var remainder = number % scale;

        var baseNumbers = new List<string>
        {
            $"{ConvertNumberToWords(baseNumber)} {(NumberDictionary.Scales.TryGetValue(scale, out var value) ? value : string.Empty)}",
            ConvertNumberToWords(remainder)
        };

        return string.Join(" ", baseNumbers.Where(x => !string.IsNullOrEmpty(x)));
    }

    private string ConvertTens(decimal number)
    {
        var remainder = number % 10;
        var baseNumber = number - remainder;
        var ones = NumberDictionary.Ones.TryGetValue(remainder, out var onesValue) ? onesValue : string.Empty;
        var tens = NumberDictionary.Tens.TryGetValue(baseNumber, out var tensValue) ? tensValue : string.Empty;
        return $"{tens} {ones}".Trim();
    }

    public NumberConverter(string numberInWords)
    {
        _numberInWords = numberInWords;
        _number = ConvertWordsToNumber(numberInWords);
    }

    private decimal ConvertWordsToNumber(string num)
    {
        var words = num.Split(" ");
        
        var x = words.Aggregate(
            (low: 0m, total: 0m),
            (acc, word) => GetCumulativeTotal(word, acc.low, acc.total));
        
        return x.low + x.total;
    }

    private (decimal, decimal) GetCumulativeTotal(string word, decimal low, decimal total)
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

    private decimal GetLowNumberFromKey(string key)
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

    private decimal GetScaleFromKey(string key)
    {
        return NumberDictionary.Scales.ContainsValue(key)
            ? NumberDictionary.Scales.FirstOrDefault(p => p.Value == key).Key
            : 0;
    }

    public void Deconstruct(out decimal number, out string numberInWords)
    {
        number = _number;
        numberInWords = _numberInWords;
    }
}