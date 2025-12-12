namespace LeetCode.Medium
{
    internal class _71
    {
        public class Solution
        {
            public string SimplifyPath(string path)
            {
                var parts = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
                var stack = new Stack<string>();

                foreach (var p in parts)
                {
                    if (p == ".")
                    {
                        // current directory -> skip
                        continue;
                    }
                    else if (p == "..")
                    {
                        // go one directory back if exists
                        if (stack.Count > 0)
                            stack.Pop();
                    }
                    else
                    {
                        // folder name -> push into stack
                        stack.Push(p);
                    }
                }

                // reverse because stack is LIFO
                return "/" + string.Join("/", stack.Reverse());
            }
        }
    }
}
