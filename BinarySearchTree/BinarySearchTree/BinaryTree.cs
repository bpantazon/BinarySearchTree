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
            bool wasAdded = false;
            Node node;
            Node temp = new Node(data);
            if (start == null)
            {
                start = temp;               
            }         
            node = start;
            if (node.link != null) //while
            {               
                node = node.link;
            }
            while (wasAdded == false)
            {
                if (temp.data > node.data)
                {
                    
                    if (node.right == null)
                    {
                        node.right = temp;
                        node.right.link = node;
                        wasAdded = true;
                    }
                    else if (node.right != null)
                    {
                        node = node.right;

                    }
                }
                else if (temp.data < node.data)
                {
                    if (node.left == null)
                    {
                        node.left = temp;
                        node.left.link = node;
                        wasAdded = true;
                    }
                    else if (node.left != null)
                    {
                        node = node.left;
                    }
                }
                else if (temp.data == node.data)
                {
                    wasAdded = true;
                }               
            }           
        }
        
        public void Search(int data)
        {
            bool wasFound = false;
            Node node;
            Node temp = new Node(data);
            if (start == null)
            {
                start = temp;
            }
            node = start;
            if (node.link != null) //while
            {
                node = node.link;
            }
            while (wasFound == false)
            {
                if (temp.data > node.data)
                {

                    if (node.right == null)
                    {
                        node.right = temp;
                        //node.right.link = node;
                        wasFound = true;
                    }
                    else if (node.right != null)
                    {
                        node = node.right;

                    }
                }
                else if (temp.data < node.data)
                {
                    if (node.left == null)
                    {
                        node.left = temp;
                        //node.left.link = node;
                        wasFound = true;
                    }
                    else if (node.left != null)
                    {
                        node = node.left;
                    }
                }
                else if (temp.data == node.data)
                {
                    wasFound = true;
                    Console.WriteLine($"Your value of {temp.data} was found");
                }
                
            }
        }
    }
}
