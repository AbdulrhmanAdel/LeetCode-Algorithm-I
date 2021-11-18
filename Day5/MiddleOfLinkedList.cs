namespace Algorithm_I.Day5
{
    public class MiddleOfLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            var middle = head;
            var lastNode = head;
            var tracker = 0;

            while (lastNode != null)
            {
                lastNode = lastNode.next;
                if (tracker == 1)
                {
                    middle = middle.next;
                    tracker--;
                }
                else
                {
                    tracker++;
                }
            }

            return middle;
        }
    }

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
}