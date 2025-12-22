namespace LeetCode.Easy
{
    public class _0160_IntersectionofTwoLinkedLists
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public class Solution
        {
            public static void Main()
            {
                var headA = new ListNode(4)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(8)
                        {
                            next = new ListNode(4)
                            {
                                next = new ListNode(5)
                                {
                                    next = null
                                }
                            }
                        }
                    }
                };
                //5,6,1,8,4,5]
                var headB = new ListNode(5)
                {
                    next = new ListNode(6)
                    {
                        next = new ListNode(1)
                        {
                            next = new ListNode(8)
                            {
                                next = new ListNode(4)
                                {
                                    next = new ListNode(5)
                                    {
                                        next = null
                                    }
                                }
                            }
                        }
                    },

                };

                Solution solution = new Solution();
                Console.WriteLine(solution.GetIntersectionNode(headA, headB).val);
            }

            public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
            {
                var list1 = new List<ListNode>();
                var list2 = new List<ListNode>();

                while (headA != null)
                {
                    list1.Add(headA);
                    headA = headA.next;
                }

                while (headB != null)
                {
                    list2.Add(headB);
                    headB = headB.next;
                }

                list1.Reverse();
                list2.Reverse();

                ListNode result = null;

                for(int i = 0; i < list1.Count; i++)
                {
                    if (Equal(list1[i],list2[i]))
                        result = list1[i];
                    else break;
                }

                return result;
            }

            public bool Equal(ListNode headA, ListNode headB)
            {
                if (headA == null && headB == null)
                    return true;

                if(headA == null) return false;
                if (headB == null) return false;

                return headA.val == headB.val;
            }
        }
    }
}
