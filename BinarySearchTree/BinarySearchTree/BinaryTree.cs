using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        Node start = null;
        public BinaryTree()
        {

        }
        public void Add(int data)
        {
            Node node;
            Node temp = new Node(data);
            if (start == null)
            {
                start = temp;
                //node = root;
            }
            //else
            //{
            //    node = newNode;
            //}
            node = start;
            if (node.link != null) //while
            {
                //node.link = null;
                node = node.link;
            }
            //node.link = temp;
            
            if (temp.data > node.data)
            {
                //node.right.data = temp.data;
                //node.right.link = temp;
                node.right = temp;
                node.right.link = node;
            }
            else if (temp.data < node.data)
            {
                //node.left.data = temp.data;
                //node.left.link = temp;
                node.left = temp;
                node.left.link = node;
            }
        }
        
    }
}
