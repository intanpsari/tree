using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class Node
    {
        int data;
        public Node left, right;
        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }
    
    class BinaryTree
    {
        public Node root;

        int minimumDepth()
        {
            return minimumDepth(root);
        }

        public int minimumDepth(Node root)
        {
            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
                return 1;

            if (root.left == null)
                return minimumDepth(root.right) + 1;

            if (root.right == null)
                return minimumDepth(root.left) + 1;

            return Math.Min(minimumDepth(root.left), minimumDepth(root.right)) + 1;


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            Console.WriteLine("Min Depth is " + tree.minimumDepth(tree.root));
        }
    }
}
