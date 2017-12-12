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
            Random random = new Random();
            MyBinaryList list1 = new MyBinaryList();
            for(int i = 0; i <26; i ++)
            {
                (random.Next(0, 100));
            }
            list1.Add(4);
            list1.Add(2);
            list1.Add(7);
            list1.Add(6);
            list1.Add(1);
            list1.Add(9);
            list1.Add(3);
            list1.Add(10);
            list1.Add(5);
            list1.Add(8);
            list1.Display();
            Console.ReadLine();
        }
    }
}
