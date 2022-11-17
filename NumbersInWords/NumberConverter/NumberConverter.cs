namespace NumbersInWords;

public class NumberConverter 
{
    private readonly decimal _number;
    private readonly string _numberInWords;

    public NumberConverter(decimal number)
    {
        _number = number;
        _numberInWords = ConvertNumberToWords.Convert(number);
    }
    
    public NumberConverter(string numberInWords)
    {
        _numberInWords = numberInWords;
        _number = ConvertWordsToNumber.Convert(numberInWords);
    }

    public void Deconstruct(out decimal number, out string numberInWords)
    {
        number = _number;
        numberInWords = _numberInWords;
    }
}