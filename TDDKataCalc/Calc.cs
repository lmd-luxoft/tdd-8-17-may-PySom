using System.Text.RegularExpressions;

namespace TDDKataCalc;

public class Calc
{
    public static int Add(string digits)
    {
        if(digits is null) return -1;
        if (digits == "") return 0;
        try
        {
            return Regex.Split(digits, ",|\n").Select(x => int.Parse(x)).Sum();
        }catch (Exception) { return -1; }
    }
}