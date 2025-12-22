namespace LeetCode.Medium
{
    internal class _0150_EvaluateReversePolishNotation
    {
        public class Solution
        {
            public int EvalRPN(string[] tokens)
            {
                Stack<int> stack = new Stack<int>();

                for(int i = 0; i < tokens.Length; i++)
                {
                    var @char = tokens[i];

                    if ("+-*/".Contains(@char))
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        switch(@char)
                        {
                            case "+":
                                stack.Push(a + b);
                                break;
                            case "-":
                                stack.Push(a - b);
                                break;
                            case "*":
                                stack.Push(a * b);
                                break;
                            case "/":
                                stack.Push(a / b);
                                break;
                        }
                    }
                    else
                    {
                        stack.Push(int.Parse(tokens[i]));
                    }
                }

                return stack.Pop();
            }
        }
    }
}
