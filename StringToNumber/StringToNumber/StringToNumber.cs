namespace StringToNumber;

public class StringToNumber
{
    public static int Calculate(string str) {
        return int.TryParse(str, out var result) ? result : 0;
    }
}