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
        NumberDictionary.Ones.TryGetValue(number, out var ones);
        
        return ones ?? "Error";
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