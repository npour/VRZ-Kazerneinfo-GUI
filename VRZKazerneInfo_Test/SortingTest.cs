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
        public void integerSortTest()
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
            Sorting.bubbleSort (testList);
            for(int i = 0; i < testList.Count; i++) 
            {
                Assert.AreEqual (testList [i], testList2 [i]);
            }
        }

        // TODO: Test with empty list and other failures
        // TODO: Test with different types since sorting method is generic
        // TODO: Test with same types
    }
}

