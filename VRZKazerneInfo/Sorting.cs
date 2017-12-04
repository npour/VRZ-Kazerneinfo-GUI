using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace VRZKazerneInfo
{
    /// <summary>
    /// Class with sorting algorithms
    /// TODO: Create quicksort
    /// </summary>
    public class Sorting
    {
        /// <summary>
        /// Sort a list with bubble sort
        /// </summary>
        /// <param name="sortList">List to sort.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static void bubbleSort<T>(IList<T> sortList) where T: IComparable<T>
        {
            // TODO: Look at different higher level list or collection
            // types, for instance: IEnumerable, ICollection, IList etc.
            for (int i = 0; i < sortList.Count; i++) {
                for(int j = 0; j < sortList.Count - 1; j++) {
                    if (sortList[j].CompareTo(sortList[j + 1]) > 0) {
                        T temp = sortList [j];
                        sortList [j] = sortList [j + 1];
                        sortList [j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Initiates quick sort
        /// </summary>
        /// <param name="sortList">Sort list.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static void quickSort<T> (IList<T> sortList) where T: IComparable<T>
        {
            // Check if there is something to stort, return the list if there isn't
            if (sortList.Count < 2) {
                return;
            }
            quickSort (sortList, 0, sortList.Count - 1);
        }

        /// <summary>
        /// Actual recursive sorting using quicksort
        /// </summary>
        /// <param name="sortList">Sort list.</param>
        /// <param name="left">Left.</param>
        /// <param name="right">Right.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static void quickSort<T> (IList<T> sortList, int left, int right) where T: IComparable<T>
        {
            int i = left, j = right;
            T pivot = sortList [(left + right) / 2]; // Choose the middle as partition

            while (i <= j) {
                while (sortList [i].CompareTo (pivot) < 0) {
                    i++;
                }

                while (sortList [j].CompareTo (pivot) > 0) {
                    j--;
                }

                if (i <= j) {
                    // Swap
                    T tempValue = sortList [i];
                    sortList [i] = sortList [j];
                    sortList [j] = tempValue;

                    i++;
                    j--;
                }
            }

            if (left < j) {
                quickSort (sortList, left, j);
            }

            if (i < right) {
                quickSort (sortList, i, right);
            }
        }
      

        /// <summary>
        /// Compares the sorting algoritms quicksort and bubble-sort
        /// </summary>
        /// <param name="itemAmount">Item amount.</param>
        public void compareSorting(int itemAmount = 1000) 
        {
            Random random = new Random();
            List<int> listBubble = new List<int>();
            List<int> listQuick = new List<int>();
            for (int i = 0; i < itemAmount; i++) {
                int randomNumber = random.Next ();
                listBubble.Add (randomNumber);
                listQuick.Add (randomNumber);
            }
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start ();
            Sorting.bubbleSort (listBubble);
            stopwatch.Stop ();
            Console.WriteLine("Bubble sort: " + stopwatch.ElapsedMilliseconds);
            stopwatch.Restart ();
            stopwatch.Start ();
            Sorting.quickSort (listQuick);
            stopwatch.Stop ();
            Console.WriteLine("Quick sort: " + stopwatch.ElapsedMilliseconds);
        }
    }
}