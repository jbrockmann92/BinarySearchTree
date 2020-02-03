using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        //Member Variables (HAS A)
        Node start;

        //Constructor

        //Member Methods (CAN DO)
        public void Add(int value)
        {
            //Lower than previous = left; Higher = right
            //First node has to have its own value, but is not linked from the previous one. Null test probably, like the whiteboard
            Node node = new Node(value);

            //Set node's link to something
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
                        //Change to greater than
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
                //Lower than previous = left; Higher = right
                //First node has to have its own value, but is not linked from the previous one. Null test probably, like the whiteboard
                Node node = new Node(value);

                //Set node's link to something
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
                        //Change to greater than
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
