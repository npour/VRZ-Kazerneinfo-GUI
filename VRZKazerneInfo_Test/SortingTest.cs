using System;
using System.Collections.Generic;
using VRZKazerneInfo;
using NUnit.Framework;

namespace VRZKazerneInfo_Test
{
    [TestFixture]
    public class SortingTest
    {
        [Test]
        public void integerBubbleSortTest()
        {
            this.integerListTest ("bubble");
        }

        [Test]
        public void integerQuickSortTest()
        {
            this.integerListTest ("quicksort");
        }

        private void integerListTest(string sortMethod)
        {
            List<int> testList = new List<int> ();
            List<int> testList2 = new List<int> ();
            testList.Add (1);
            testList.Add (0);
            testList.Add (10);
            testList.Add (8);
            testList2.Add (0);
            testList2.Add (1);
            testList2.Add (8);
            testList2.Add (10);
            this.sortList (testList, sortMethod);
            bool difference = false;
            for(int i = 0; i < testList.Count; i++) 
            {
                if (testList [i].CompareTo (testList2 [i]) != 0) {
                    difference = true;
                }
            }
            Assert.False (difference);
        }

        // TODO: Test with empty list and other failures
        // TODO: Test with different types since sorting method is generic
        // TODO: Test with same types
        // TODO: Test with other data types, since the sorting algorithm is generic
        [Test]
        public void emptyListBubbleSortTest()
        {
            List<int> testList = new List<int> ();
            Sorting.bubbleSort (testList);
            Assert.AreEqual (testList.Count, 0);
        }

        [Test]
        public void emptyListQuickSortTest()
        {
            List<int> testList = new List<int> ();
            Sorting.quickSort (testList);
            Assert.AreEqual (testList.Count, 0);
        }

        [Test]
        public void stringListBubbleSortTest()
        {
            testStringList ("bubble");
        }

        [Test]
        public void stringListQuickSortTest()
        {
            testStringList ("quicksort");
        }

        private void testStringList(string sortMethod)
        {
            List<string> testListSorted = new List<string> ();
            List<string> testList = new List<string> ();
            testListSorted.Add ("a");
            testListSorted.Add ("b");
            testListSorted.Add ("c");
            testListSorted.Add ("d");
            testList.Add ("b");
            testList.Add ("a");
            testList.Add ("d");
            testList.Add ("c");
            this.sortList (testList, sortMethod);
            bool isSame = true;
            for (int i = 0; i < testList.Count; i++) {
                if (testList [i] != testListSorted [i]) {
                    isSame = false;
                }
            }
            Assert.IsTrue (isSame);
        }

        /// <summary>
        /// Check which sorting method to use based on string
        /// Makes testing easier
        /// </summary>
        /// <param name="list">List.</param>
        /// <param name="sortMethod">Sort method.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        private void sortList<T>(IList<T> list, string sortMethod) where T: IComparable<T> 
        {
            if (sortMethod == "bubble") {
                Sorting.bubbleSort (list);
            }
            else {
                Sorting.quickSort (list);
            }
        }
    }
}

