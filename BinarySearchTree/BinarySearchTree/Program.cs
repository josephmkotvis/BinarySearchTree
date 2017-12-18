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
            for(int i = 1; i <21; i ++)
            {
                int randomNumber = random.Next(1, 21);
                list1.Add(randomNumber);
            }
            int randomNumber2 = random.Next(1, 21);
            bool resultsFoundResult = list1.Search(randomNumber2);
            list1.Display();
            list1.DisplaySize();
            Console.WriteLine("You found your search result of " + randomNumber2 + " after going through " + list1.pathWayAmount + " pathways." +Environment.NewLine+ "The order that was taken to find " + randomNumber2 + " is the following");
            list1.DisplayRoute();
            Console.ReadLine();
        }
    }
}
