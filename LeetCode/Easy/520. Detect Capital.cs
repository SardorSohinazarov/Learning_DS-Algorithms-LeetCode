using System.Text.RegularExpressions;

namespace LeetCode.Easy._520;

public class _520
{
    public class Solution
    {
        //public static void Main()
        //{
        //    string word = "g";
        //    Console.WriteLine(DetectCapitalUse(word));
        //}

        public static bool DetectCapitalUse(string word)
        {
            var allUpper = "^[A-Z]+$";
            var allLower = "^[a-z]+$";
            var firstCapital = "^[A-Z][a-z]*$";

            return Regex.IsMatch(word, firstCapital) || Regex.IsMatch(word, allLower) || Regex.IsMatch(word, allUpper);
        }
    }
}
