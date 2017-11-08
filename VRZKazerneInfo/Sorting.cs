using System;
using System.Collections.Generic;

namespace VRZKazerneInfo
{
    
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
    }
}

