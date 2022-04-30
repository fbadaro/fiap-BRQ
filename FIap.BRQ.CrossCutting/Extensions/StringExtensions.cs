namespace FIap.BRQ.CrossCutting.Extensions;

public static class StringExtensions
{
    public static string OnlyNumbers(this string str)
    {
        return string.Join("", System.Text.RegularExpressions.Regex.Split(str, @"[^\d]")).Trim();
    }
}
