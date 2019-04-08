using System;

namespace MergeSort
{
    // https://www.youtube.com/watch?v=TzeBrDU-JaY
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 11, 13, 5, 6, 7 };
            MergeSort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }

        private static void MergeSort(int[] arr)
        {
            int n = arr.Length;
            if (n < 2)
                return;
            int mid = n / 2;
            // left  <-- array of size(mid);
            // right <-- array of size(n-mid);
            int[] left = new int[mid];
            int[] right = new int[n - mid];
            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }
            for (int i = mid; i < n; i++)
            {
                right[i - mid] = arr[i];
            }
            MergeSort(left);
            MergeSort(right);
            Merge(arr, left, right);
        }

        private static void Merge(int[] arr, int[] left, int[] right)
        {
            int nL = left.Length;
            int nR = right.Length;
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < nL && j < nR)
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
            while (i < nL)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < nR)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
