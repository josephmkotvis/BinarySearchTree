using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class MyBinaryList
    {
        Node head;
        int count;
        List<string> pathWay = new List<string>();
        public int pathWayAmount;

        public MyBinaryList()
        {

        }
        public void Add(int number)
        {
            Node node = new Node(number);
            if (head == null)
            {
                count++;
                head = node;
                return;
            }
            Node current = head;
            while (((current.left != null) && (current.right != null)) && (current.data != node.data))
            {
                    if (current.data > node.data)
                    {
                        current = current.left;
                    }
                    else if (current.data < node.data)
                    {
                        current = current.right;
                    }
            }
            if (current.data > node.data)
               {
                count++;
                current.left = node;
               }
            else if (current.data < node.data)
               {
                count++;
                current.right = node;
               }
            else if (current.data == node.data)
            {
                count++;
                current = node;
            }
        }
        public bool Search(int searchNumber)
        {
            Node current = head;
            while ((current.left == null) || (current.right == null) || ((current.left == null) && (current.right == null)))
            {
                if (current.data.Equals(searchNumber))
                {
                    return true;
                }
                else
                {
                    if (current.data > searchNumber)
                    {
                        current = current.left;
                        pathWay.Add("left (lesser)");
                        pathWayAmount++;
                    }
                    else if (current.data < searchNumber)
                    {
                        current = current.right;
                        pathWay.Add("right (greater)");
                        pathWayAmount++;
                    }
                }
            }
            return false;
        }
        // Display method for visual testing purposes only.
        public void Display()
       {
           Display(head, 0);
           Console.WriteLine();
       }
       public void Display(Node node, int generation)
       {
           if (node == null)
           {
               return;
           }

           Display(node.right, generation + 1);
           Console.WriteLine();

           for (int i = 0; i < generation; i++)
           {
               Console.Write("    ");
           }
           Console.Write(node.data);

           Display(node.left, generation + 1);
       }
        public void DisplayRoute()
        {
            for (int i =0; i < pathWayAmount; i++)
            {
                Console.WriteLine(pathWay[i]);
            }
        }
        public void DisplaySize()
        {
            Console.WriteLine("The size of this binary tree is " + count + "." );
        }
    }
}
