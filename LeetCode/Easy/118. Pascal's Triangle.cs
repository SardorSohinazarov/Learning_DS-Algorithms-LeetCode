namespace LeetCode.Easy._118
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();
            if (numRows == 0)
            {
                return result;
            }

            for (int i = 0; i < numRows; i++)
            {
                if(i == 0)
                {
                    result.Add(new List<int> { 1 });
                    continue;
                }
                else
                {
                    result.Add(GenerateNewLine(result[result.Count - 1]));
                }
            }

            return result;
        }

        private IList<int> GenerateNewLine(IList<int>? oldLine)
        {
            var newLine = new List<int>();

            for (int i = 0; i < oldLine.Count; i++)
            {
                newLine.Add(i == 0 ? 1 : oldLine[i - 1] + oldLine[i]);
            }
            newLine.Add(1);

            return newLine;
        }
    }
    internal class _118
    {
        //private static void Main()
        //{
        //    var solution = new Solution();
        //    var result = solution.Generate(5);
        //    foreach (var list in result)
        //    {
        //        foreach (var item in list)
        //        {
        //            Console.Write(item + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
