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
            if(IsUpper(word) || IsLower(word))
                return true;

            return IsUpper(word[..1]) && IsLower(word[1..]);
        }

        public static bool IsUpper(string word) => IsInRange(word, 'A', 'Z');

        public static bool IsLower(string word) => IsInRange(word, 'a', 'z');

        public static bool IsInRange(string word, char a, char b)
        {
            foreach (char c in word)
                if(a > c &&  b < c)
                    return false;

            return true;
        }

        //public static bool DetectCapitalUse(string word)
        //{
        //    var allUpper = "^[A-Z]+$";
        //    var allLower = "^[a-z]+$";
        //    var firstCapital = "^[A-Z][a-z]*$";

        //    return Regex.IsMatch(word, firstCapital) || Regex.IsMatch(word, allLower) || Regex.IsMatch(word, allUpper);
        //}
    }
}
