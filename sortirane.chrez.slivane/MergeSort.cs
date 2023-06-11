using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortirane.chrez.slivane
{
    public class MergeSort
    {

        public static void Mergesort(int[] arr)
        {
            if (arr.Length <= 1)
                return;

            int mid = arr.Length / 2;
            int[] leftHalf = new int[mid];
            int[] rightHalf = new int[arr.Length - mid];

            Array.Copy(arr, 0, leftHalf, 0, mid);
            Array.Copy(arr, mid, rightHalf, 0, arr.Length - mid);

            Mergesort(leftHalf);
            Mergesort(rightHalf);

            Merge(arr, leftHalf, rightHalf);
        }

        public static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < left.Length)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Length)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }

    }

}
