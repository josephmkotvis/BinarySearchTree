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
                if ((current.next == null) && (current.left == null) && (current.right == null))
                {
                    current.next = current;
                }
                else if ((current.next != null) && (current.left == null) && (current.right == null))
                {
                    if (current.next.data < current.data)
                    {
                        current.left = current.next;
                        current.right = current;
                    }
                    else if (current.next.data > current.data)
                    {
                        current.left = current;
                        current.right = current.next;
                    }
                }
            }
            if ((current.left.data < node.data) && (node.data < current.data))
            {
                if (current.left.next == null)
                {
                    current.left.next = node;
                }
                else if (current.left.next != null)
                    if (current.left.next.data < node.data)
                    {
                        current.left.left = current.left.next;
                        current.left.right = node;
                    }
                    else if (current.left.next.data > node.data)
                    {
                        current.left.left = node;
                        current.left.right = current.left.next;
                    }
            }
            else if ((current.left.data > node.data) && (node.data > current.data))
            {
                if (current.left.next == null)
                {
                    current.left.next = node;
                }
                else if (current.left.next != null)
                    if (current.left.next.data < node.data)
                    {
                        current.left.left = current.left.next;
                        current.left.right = node; 
                    }
                    else if (current.left.next.data > node.data)
                    {
                        current.left.left = node;
                        current.left.right = current.left.next;
                    }   
            }
            else if ((current.right.data < node.data) && (node.data < current.data))
            {
                if (current.right.next == null)
                {
                    current.right.next = node;
                }
                else if (current.right.next != null)
                    if (current.right.next.data < node.data)
                    {
                        current.right.left = current.right.next;
                        current.right.right = node;
                    }
                    else if (current.right.next.data > node.data)
                    {
                        current.right.left = node;
                        current.right.right = current.right.next;
                    }
            }
            else if ((current.right.data > node.data) && (node.data > current.data))
            {
                if (current.right.next == null)
                {
                    current.right.next = node;
                }
                else if (current.right.next != null)
                    if (current.right.next.data < node.data)
                    {
                        current.right.left = current.right.next;
                        current.right.right = node;
                    }
                    else if (current.right.next.data > node.data)
                    {
                        current.right.left = node;
                        current.right.right = current.right.next;
                    }
            }
            else if ((current.left.data > node.data) && (current.data > current.left.data))
            {
                if (current.left.next == null)
                {
                    current.left.next = node;
                }
                else if (current.left.next != null)
                    if (current.left.next.data < node.data)
                    {
                        current.left.left = current.left.next;
                        current.left.right = node;
                    }
                    else if (current.left.next.data > node.data)
                    {
                        current.left.left = node;
                        current.left.right = current.left.next;
                    }
            }
            else if ((current.right.data > node.data) && (current.data > current.right.data))
            {
                if (current.right.next == null)
                {
                    current.right.next = node;
                }
                else if (current.right.next != null)
                    if (current.right.next.data < node.data)
                    {
                        current.right.left = current.right.next;
                        current.right.right = node;
                    }
                    else if (current.right.next.data > node.data)
                    {
                        current.right.left = node;
                        current.right.right = current.right.next;
                    }
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
    }
}
