using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        Node start;

        public void Add(int value)
        {
            Node node = new Node(value);

            if (start == null)
            {
                start = node;
            }
            else
            {
                Node current = start;
                while (true)
                {
                    if (node.value >= current.value)
                    {
                        if (current.higher == null)
                        {
                            current.higher = node;
                            break;
                        }
                        else
                        {
                            current = current.higher;
                        }
                    }
                    else if (node.value < current.value)
                    {
                        if (current.lower == null)
                        {
                            current.lower = node;
                            break;
                        }
                        else
                        {
                            current = current.lower;
                        }
                    }
                }
            }
        }

        public bool Search(int value)
        {
            bool isFound = false;
            Node test = new Node(value);

            {
                Node node = new Node(value);

                if (start == null)
                {
                    start = node;
                }
                else
                {
                    Node current = start;
                    while (true)
                    {
                        if (node.value > current.value)
                        {
                            if (current.higher == null)
                            {
                                return isFound;
                            }
                            else
                            {
                                current = current.higher;
                            }
                        }
                        else if (node.value < current.value)
                        {
                            if (current.lower == null)
                            {
                                return isFound;
                            }
                            else
                            {
                                current = current.lower;
                            }
                        }
                        else if (node.value == current.value);
                        {
                            return isFound = true;
                        }
                    }
                }
            }
            return isFound;
        }
    }
}
