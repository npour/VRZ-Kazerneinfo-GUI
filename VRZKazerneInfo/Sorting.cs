using System;
using System.Collections.Generic;

namespace VRZKazerneInfo
{
    
    public class Sorting
    {
        public static void bubbleSort<T>(List<T> sortList) where T: IComparable<T>
        {
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

