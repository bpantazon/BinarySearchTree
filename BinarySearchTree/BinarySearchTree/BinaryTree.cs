using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        Node root = null;

        public void Add(int data)
        {
            Node node;
            Node newNode = new Node(data);
            if (root == null)
            {
                root = newNode;
            }            
            node = root;
            while (node.link != null)
            {
                node = node.link;
            }
            node.link = newNode;

            if (newNode.data > node.data)
            {
                node.right = newNode;
            }
        }
        
    }
}
