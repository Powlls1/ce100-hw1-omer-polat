using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw1_algo_test_cs;
using ce100_hw1_algo_lib_cs;

namespace ce100_hw1_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {


       Class1 unitTest = new Class1();


        

        [TestMethod]
        
        public void InsSort_TestEmpty()
        {
            int[] Arr1 = new int[0];
            Class1.InsSort(Arr1);
            int[] Exp = new int[0];
            CollectionAssert.AreEqual(Exp, Arr1);
        }
        [TestMethod]
        public void InsSort_TestSingle()
        {
            int[] Arr1 = new int[1] { 1 };
            Class1.InsSort(Arr1);
            int[] Exp = new int[1] { 1 };
            CollectionAssert.AreEqual(Exp, Arr1);
        }
        [TestMethod]
        public void InsSort_TestSimple()
        {
            int[] Arr1 = new int[8] { 0, 2, 3, 7, 6, 1, 5, 4 };
            Class1.InsSort(Arr1);
            int[] Exp = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7, };
            CollectionAssert.AreEqual(Exp, Arr1);
        }
        [TestMethod]
        public void InsSort_TestMinus()
        {
            int[] Arr1 = new int[5] { 2, -1, 1, 0, -2 };
            Class1.InsSort(Arr1);
            int[] Exp = new int[5] { -2, -1, 0, 1, 2 };
            CollectionAssert.AreEqual(Exp, Arr1);
        }
        [TestMethod]
        public void InsSort_Test0()
        {
            int[] Arr1 = new int[6] { 0, 0, 0, 0, 0, 0 };
            Class1.InsSort(Arr1);
            int[] Exp = new int[6] { 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(Exp, Arr1);
        }

       
        [TestMethod]
        public void SelSort_TestEmpty()
        {
            int[] Arr1 = new int[0];
            Class1.SortArray(Arr1, 1);
            int[] Exp = new int[0];
            CollectionAssert.AreEqual(Exp, Arr1);
        }

        [TestMethod]
        public void SelSort_TestSimple()
        {

            int[] Arr1 = new int[6] { 3, 1, 2, 4, 5, 6 };
            Class1.SortArray(Arr1, 6);
            int[] Exp = new int[6] { 1, 2, 3, 4, 5, 6 };
            CollectionAssert.AreEqual(Arr1, Exp);
        }

        [TestMethod]
        public void SelSort_TestMinus()
        {
            int[] Arr1 = new int[5] { 2, -1, 1, 0, -2 };
            Class1.SortArray(Arr1,5);
            int[] Exp = new int[5] { -2, -1, 0, 1, 2 };
            CollectionAssert.AreEqual(Exp, Arr1);
        }

        //RECURSİVE-POWER


        [TestMethod]
        public void RecPow_test()
        {
            
            int result = Class1.CalcuOfPower(2, 3);
            Assert.AreEqual(result, 8);

        }

        [TestMethod]

        public void RecPow_testMinus()
        {
            
            int result = Class1.CalcuOfPower(-2, 3);
            Assert.AreEqual(result, -8);

        }

        [TestMethod]

        public void RecPow_test0()
        {
            
            int result = Class1.CalcuOfPower(2, 0);
            Assert.AreEqual(result, 1);

        }


        //Naive Power


        [TestMethod]
        public void NaivePow_test()
        {
            
            int result = Class1.Naivepower(4,2);
            Assert.AreEqual(result, 16);

        }

        [TestMethod]
        public void NaivePow_testMinus()
        {

            int result = Class1.Naivepower(-2, 3);
            Assert.AreEqual(result, -8);

        }

        [TestMethod]
        public void NaivePow_test0()
        {

            int result = Class1.Naivepower(2, 0);
            Assert.AreEqual(result, 1);

        }


        
        
        //Binary Search Iterative

        [TestMethod]

        public void BinarySearchIterative_test1()
        {
            int[] Arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 8;

            int bas = Class1.BinarySearchIterative(Arr1, key);
            Assert.AreEqual(bas, 7);
        }


        [TestMethod]

        public void BinarySearchIterative_test2()
        {
            int[] Arr1 = { 12,21,34,45,56,67 };
            int key = 21;

            int bas = Class1.BinarySearchIterative(Arr1, key);
            Assert.AreEqual(bas, 1);
        }

        [TestMethod]

        public void BinarySearchIterative_test3()
        {
            int[] Arr1 = { -9,-8,-7,-6,-5,-4};
            int key = -7;

            int bas = Class1.BinarySearchIterative(Arr1, key);
            Assert.AreEqual(bas, 2);
        }



        //Binary Search Recursive


        [TestMethod]

        public void BinarySearchRecursive_test()
        {
            int[] Arr1 = { 0, 1, 2, 3, 4, 5 };
            int key = 4;

            int bas = Class1.BinarySearchRecursive(Arr1, 0, 5, key);
            Assert.AreEqual(bas, 4);
        }


        [TestMethod]

        public void BinarySearchRecursive_test2()
        {
            int[] Arr1 = { 10,42,45,78,84,99};
            int key = 42;

            int bas = Class1.BinarySearchRecursive(Arr1, 0, 5, key);
            Assert.AreEqual(bas, 1);
        }

        [TestMethod]

        public void BinarySearchRecursive_test3()
        {
            int[] Arr1 = { -87,74,-69,-45,-33,-25,-11 };
            int key = -11;

            int bas = Class1.BinarySearchRecursive(Arr1, 0, 6, key);
            Assert.AreEqual(bas, 6);
        }



        //Merge Sort

        [TestMethod]

        public void merge_test1()
        {
            int[] Arr1 = { 12, 21, 67, 34, 56, 45 };
            int[] result = { 12, 21, 34, 45, 56, 67 };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), result);
        }

        [TestMethod]
        public void merge_test2()
        {
            int[] Arr1 = { 122, 421, 267, 334, 656, 545 };
            int[] result = { 122, 267, 334, 421, 545, 656 };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), result);
        }

        [TestMethod]
        public void merge_testMinus()
        {
            int[] Arr1 = { -12, -21, -67, -34, -56, -45 };
            int[] result = {-67, -56, -45, -34, -21, -12};
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), result);
        }














    }
}
