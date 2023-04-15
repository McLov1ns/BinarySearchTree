using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Tree
    {
        public Node root;

        public Tree()
        {
            root = null;
        }

        public Node Search(int data)
        {
            return Search(root, data);
        }

        private Node Search(Node node, int data)
        {
            if (node == null || node.Data == data)
                return node;

            if (data < node.Data)
                return Search(node.Left, data);
            else
                return Search(node.Right, data);
        }

        public void Add(int data)
        {
            root = Add(root, data);
        }

        private Node Add(Node node, int data)
        {
            if (node == null)
                return new Node(data);

            if (data < node.Data)
                node.Left = Add(node.Left, data);
            else if (data > node.Data)
                node.Right = Add(node.Right, data);

            return node;
        }
    }
}
