namespace TDDKataCalc;

public class Calc
{
    public static int Add(string digits)
    {
        if(digits is null) return -1;
        if (digits == "") return 0;
        try
        {

            return digits.Split(',').Select(x => int.Parse(x)).Sum();
        }catch (Exception) { return -1; }
    }
}