namespace NumbersInWords;

public static class ConvertNumberToWords
{
    public static string Convert(decimal number)
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

    private static string ConvertScale(decimal number, int scale)
    {
        var baseNumber = Math.Floor(number / scale);
        var remainder = number % scale;

        var baseNumbers = new List<string>
        {
            $"{Convert(baseNumber)} {(NumberDictionary.Scales.TryGetValue(scale, out var value) ? value : string.Empty)}",
            Convert(remainder)
        };

        return string.Join(" ", baseNumbers.Where(x => !string.IsNullOrEmpty(x)));
    }

    private static string ConvertTens(decimal number)
    {
        var remainder = number % 10;
        var baseNumber = number - remainder;
        var ones = NumberDictionary.Ones.TryGetValue(remainder, out var onesValue) ? onesValue : string.Empty;
        var tens = NumberDictionary.Tens.TryGetValue(baseNumber, out var tensValue) ? tensValue : string.Empty;
        return $"{tens} {ones}".Trim();
    }
}