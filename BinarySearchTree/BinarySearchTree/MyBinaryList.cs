using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class MyBinaryList
    {
        Node head = null;
        int count;
        List<int> pathWay;

        public MyBinaryList()
        {

        }
        public void Add(int number)
        {
            Node node = new Node(number);
            if (head == null)
            {
                head = node;
                return;
            }
            Node current = head;
            while ((current.left != null) && (current.right != null))
            {
                //while ((current.data > node.data) || (current.data < node.data))
                //{
                    if (current.data > node.data)
                    {
                        current = current.left;
                    }
                    else if (current.data < node.data)
                    {
                        current = current.right;
                    }
                //}
            }
            if (current.data > node.data)
               {
                 current.left = node;
               }
            else if (current.data < node.data)
               {
                 current.right = node;
               }
            }
        public bool Search(int searchNumber)
        {
            Node current = head;
            while ((current.left != null) && (current.right != null))
            {
                if (current.data.Equals(searchNumber))
                {
                    return true;
                }
                else if (current.data < current.right.data)
                {
                    current = current.left;
                }
                else if (current.data > current.left.data)
                {
                    current = current.right;
                }
            }
            return false;
        }
        public void Display()
       {
           Display(head, 0);
           Console.WriteLine();
       }
       public void Display(Node node, int level)
       {
           if (node == null)
           {
               return;
           }

           Display(node.right, level + 1);
           Console.WriteLine();

           for (int i = 0; i < level; i++)
           {
               Console.Write("    ");
           }
           Console.Write(node.data);

           Display(node.left, level + 1);
       }
    }
}
