using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int data;
        public Node link;
        public Node right;
        public Node left;
        

        public Node(int data)
        {
            this.data = data;
            this.link = null;
            left = null;
            right = null;
        }
    }
}
