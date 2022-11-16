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

    private decimal ConvertWordsToNumber(string numberInWords)
    {
        Func<string, decimal> MapNumberPart() =>
            s =>
            {
                var matchingOnes = NumberDictionary.Ones.FirstOrDefault(x => x.Value == s).Key;
                var matchingTeens = NumberDictionary.Teens.FirstOrDefault(x => x.Value == s).Key;
                var matchingTens = NumberDictionary.Tens.FirstOrDefault(x => x.Value == s).Key;

                return new List<decimal> {matchingOnes, matchingTeens, matchingTens}.Max();
            };

        var splitWords = numberInWords.Split(" ");

        return splitWords
            .Select(MapNumberPart())
            .Sum();
    }

    public void Deconstruct(out decimal number, out string numberInWords)
    {
        number = _number;
        numberInWords = _numberInWords;
    }

}