using System;
using System.Linq;

namespace BinaryTreeFromArray
{
    class BinaryTreeFromArray
    {
        // https://www.youtube.com/watch?v=PAA2mKGNf6Q
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Node tree = new Node(arr);
            PrintInOrder(tree);
        }

        static void PrintInOrder(Node node)
        {
            if (node == null)
                return;
            PrintInOrder(node.leftChild);
            Console.WriteLine(node.value + " ");
            PrintInOrder(node.rightChild);
        }

        void printPreorder(Node node)
        {
            if (node == null)
                return;

            /* first print data of node */
            Console.Write(node.value + " ");

            /* then recur on left sutree */
            printPreorder(node.leftChild);

            /* now recur on right subtree */
            printPreorder(node.rightChild);
        }

        void printPostorder(Node node)
        {
            if (node == null)
                return;

            // first recur on left subtree 
            printPostorder(node.leftChild);

            // then recur on right subtree 
            printPostorder(node.rightChild);

            // now deal with the node 
            Console.Write(node.value + " ");
        }
    }

    public class Node
    {
        public int value;
        public Node leftChild;
        public Node rightChild;
        public Node(int value)
        {
            this.value = value;
        }

        public Node(int[] values)
        {
            int length = values.Length;

            switch (length)
            {
                case 1:
                    this.value = values[0];
                    return;
                case 2:
                    int min = Math.Min(values[0], values[1]);
                    int max = Math.Max(values[0], values[1]);
                    this.value = max;
                    this.leftChild = new Node(min);
                    break;
                default: // Recursion
                    int median = length / 2;
                    int[] leftArray = values.Take(median).ToArray();
                    int[] rightArray = values.Skip(median).ToArray();
                    if (leftArray.Length > 0) this.leftChild = new Node(leftArray);
                    this.value = values[median];
                    if (rightArray.Length > 0) this.rightChild = new Node(rightArray);
                    break;
            }
        }
    }
}
