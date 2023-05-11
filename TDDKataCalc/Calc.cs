using System.Text.RegularExpressions;

namespace TDDKataCalc;

public class Calc
{
    public static int Add(string digits)
    {
        if(digits is null) return -1;
        if (digits == "") return 0;

        string[] digitsAsArray = Array.Empty<string>();

        if (digits.StartsWith("//"))
        {
            var digitsSplit = digits.Split('\n');
            var delimeter = digitsSplit[0][2];
            var newDigits = digitsSplit[1];
            digitsAsArray = newDigits.Split(delimeter);
        }
        else
        {
            digitsAsArray = Regex.Split(digits, ",|\n");
        }
        
        try
        {
            return CalculateSum();
        }catch (Exception) { return -1; }

        int CalculateSum() => digitsAsArray.Select(x => int.Parse(x)).Sum();
    }
}