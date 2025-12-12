using System.Numerics;

namespace LeetCode.Medium
{
    internal class _49
    {
        public class Solution
        {
            public IList<IList<string>> GroupAnagrams(string[] strs)
            {
                var dictionary = new Dictionary<string, List<string>>();

                foreach (var str in strs)
                {
                    var key = string.Concat(str.OrderBy(c => c));

                    if(!dictionary.ContainsKey(key))
                        dictionary.Add(key, [str]);
                    else 
                        dictionary[key].Add(str);
                }

                return dictionary.Values.ToList<IList<string>>();
            }
        }
    }
}
