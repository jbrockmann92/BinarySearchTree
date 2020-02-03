using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(4);
            binaryTree.Add(6);
            binaryTree.Add(5);
            binaryTree.Add(35);
            binaryTree.Add(22);
            binaryTree.Add(9);
            binaryTree.Add(103);
            binaryTree.Add(33);
            binaryTree.Add(12);
            binaryTree.Add(100);

            bool result = binaryTree.Search(22);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
