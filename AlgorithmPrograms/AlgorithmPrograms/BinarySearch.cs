using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BinarySearch
    {
       
        public int BinarySearching(int[] arr, int low, int high, int key)
        {
            if (high >= low)
            {
                int mid = low + (high - 1) / 2;

                // If the element is present at the
                // middle itself
                if (arr[mid] == key)
                    return mid;

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (key < arr[mid])
                    return BinarySearching(arr, low, mid - 1, key);

                // Else the element can only be present
                // in right subarray
                else
                {
                    return BinarySearching(arr, mid + 1, high, key);
                }
            }

            // We reach here when element is not present
            // in array
            return -1;
        }
    }
}
