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
            <= 999 => ConvertHundreds(number),
            _ => throw new ArgumentOutOfRangeException(nameof(number), number, null)
        };
    }

    private  string ConvertHundreds(decimal number)
    {
        return $"{ConvertNumberToWords(Math.Floor(number / 100))} hundred {ConvertNumberToWords(number % 100)}".Trim();
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
    }
 
    public void Deconstruct(out decimal number, out string numberInWords)
    {
        number = _number;
        numberInWords = _numberInWords;
    }

}