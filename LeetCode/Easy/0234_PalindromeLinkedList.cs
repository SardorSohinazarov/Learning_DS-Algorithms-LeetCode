namespace LeetCode.Easy
{
    internal class _234
    {
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
   }
}

        public class Solution
        {
            public bool IsPalindrome(ListNode head)
            {
                var list = new List<int>();
                while(head != null)
                {
                    list.Add(head.val);
                    head = head.next;
                }

                return list.SequenceEqual(list.AsEnumerable().Reverse());
            }
        }
    }
}
