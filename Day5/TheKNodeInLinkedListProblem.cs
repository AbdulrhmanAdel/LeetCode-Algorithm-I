using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Algorithm_I.Day5
{
    public class TheKNodeInLinkedListProblem
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var lastNode = head;
            var kNode = head;
            var nodesCount = 1;
            var tmp = kNode;
            
            while (nodesCount <= n && lastNode?.next != null)
            {
                lastNode = lastNode?.next;
                nodesCount++;
            }
            
            while (lastNode?.next != null)
            {
                lastNode = lastNode?.next;
            
                kNode = kNode?.next;
                nodesCount++;
            }
            
            if (n == nodesCount)
            {
                return tmp.next;
            }
            
            kNode.next = kNode?.next?.next;
            return tmp;
        }
    }
}