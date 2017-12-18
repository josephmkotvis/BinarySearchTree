using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearchTree;

namespace BinaryTreeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateAllRightBinaryTree_CheckForSearch_SearchFound()
        {
            ////Arrange
            MyBinaryList list1 = new MyBinaryList();
            for (int i = 1; i <3; i++)
            {
                list1.Add(i);
            }
            ////Act 
            bool searchFound = list1.Search(2);
            //Assert
            Assert.AreEqual(searchFound, true);
        }
        [TestMethod]
        public void CreateFullBinaryTreeWithRepeat_CheckForSearch_SearchFound()
        {
            ////Arrange
            MyBinaryList list1 = new MyBinaryList();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(2);
            ////Act 
            bool searchFound = list1.Search(2);
            //Assert
            Assert.AreEqual(searchFound, true);
        }
    }
}
