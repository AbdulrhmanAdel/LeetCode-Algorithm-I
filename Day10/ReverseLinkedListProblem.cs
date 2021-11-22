using System.Net.Http;
using System.Net.Sockets;
using Algorithm_I.Day4;
using Algorithm_I.Day5;

namespace Algorithm_I.Day10
{
    public class ReverseLinkedListProblem
    {
        // Given the head of a singly linked list,
        // reverse the list, and return the reversed list.

        public static void Run()
        {
            var problem = new ReverseLinkedListProblem();
            problem.ReverseList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4)))));
        }

        private ListNode _head;

        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return null;
            _head = head;
            var reversed = new ListNode();
            Reverse(reversed, head);
            return reversed.next;
        }

        private ListNode Reverse(ListNode reversed, ListNode node)
        {
            if (node.next == null)
            {
                _head.next = null;
                reversed.next = node;
                return node;
            }

            var current = node;
            var last = Reverse(reversed, node.next);
            last.next = current;
            return current;
        }
    }
}