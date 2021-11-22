using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using Algorithm_I.Day5;

namespace Algorithm_I.Day10
{
    public class MergeTwoSortedListProblem
    {
        /*
         * Merge two sorted linked lists and return it as a sorted list.
         * The list should be made by splicing together the nodes of the first two lists.
         */
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            // Iterative Way
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            var head = new ListNode();
            var current = head;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }

            current.next = l1 ?? l2;
            return head.next;
            
            // Recursion Way
            Merge(head, l1, l2);
            return head.next;
        }

        private void Merge(ListNode head, ListNode l1, ListNode l2)
        {
            // 1 - 2 4
            // 1 - 3 4
            // n 1 1
            if (l2 == null)
            {
                head.next = l1;
                return;
            }

            if (l1 == null)
            {
                head.next = l2;
                return;
            }

            if (l1.val < l2.val)
            {
                head.next = l1;
                Merge(head.next, l1.next, l2);
            }
            else
            {
                head.next = l2;
                Merge(head.next, l1, l2.next);
            }
        }
    }
}