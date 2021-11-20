using System.Collections;
using System.Collections.Generic;

namespace Algorithm_I.Day8
{
    public class PopulatingNextRightPointersInEachNodeProblem
    {
        public Node Connect(Node root)
        {
            if (root == null || (root.left == null && root.right == null)) return root;
            var queue = new Queue<Node>();
            queue.Enqueue(root);
            queue.Enqueue(null);

            while (queue.Count != 0)
            {
                var tmp = queue.Dequeue();

                if (tmp != null)
                {
                    tmp.next = queue.Peek();
                    if (tmp.left != null)
                    {
                        queue.Enqueue(tmp.left);
                    }
                    if (tmp.right != null)
                    {
                        queue.Enqueue(tmp.right);
                    }
                }
                else
                {
                    if (queue.Count == 0)
                    {
                        break;
                    }
                    
                    queue.Enqueue(null);
                }
            }

            return root;
        }

        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node()
            {
            }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
    }
}