namespace LeetCode.Easy
{
    internal class _1700
    {
        public class Solution
        {
            //private static void Main()
            //{
            //    var solution = new Solution();
            //    var students = new int[] { 1, 1, 1, 0, 0, 1 };
            //    var sandwiches = new int[] { 1, 0, 0, 0, 1, 1 };
            //    var result = solution.CountStudents(students, sandwiches);
            //    Console.WriteLine(result);
            //}

            public int CountStudents(int[] students, int[] sandwiches)
            {
                var counto = students.Where(s => s == 0).Count();
                var count1 = students.Where(s => s == 1).Count();

                foreach (var sandwich in sandwiches)
                {
                    if(sandwich == 0)
                    {
                        if(counto == 0)
                        {
                            break;
                        }
                        counto--;
                    }
                    else
                    {
                        if(count1 == 0)
                        {
                            break;
                        }
                        count1--;
                    }
                }

                return counto + count1;
            }
        }
    }
}
