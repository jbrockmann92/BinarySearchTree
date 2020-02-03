using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        public int value;
        public Node lower;
        public Node higher;

        public Node(int value)
        {
            this.value = value;
        }
    }
}
