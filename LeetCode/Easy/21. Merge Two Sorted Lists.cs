namespace LeetCode.Easy
{
    internal class _21
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public class Solution
        {
            private static void Main(string[] args)
            {
                var solution = new Solution();
                var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
                var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
                var result = solution.MergeTwoLists(list1, list2);
                while (result != null)
                {
                    Console.WriteLine(result.val);
                    result = result.next;
                }
            }

            public ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                var temp1 = list1;
                var temp2 = list2;
                ListNode result = new ListNode();
                var res = result;

                while (temp1 != null && temp2 != null)
                {
                    if (temp1.val > temp2.val)
                    {
                        res.next = temp2;
                        temp2 = temp2.next;
                    }
                    else
                    {
                        res.next = temp1;
                        temp1 = temp1.next;
                    }
                    res = res.next;
                }

                if (temp1 != null)
                {
                    res.next = temp1;
                }
                else
                {
                    res.next = temp2;
                }

                return result.next;
            }
        }
    }
}
