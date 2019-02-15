using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(100);
            tree.Add(110);
            tree.Add(90);
            tree.Add(120);
            tree.Add(85);
            tree.Add(150);
            tree.Add(130);
            tree.Add(70);
            tree.Add(95);
            tree.Add(70);
        }
    }
}
