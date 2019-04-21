using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int index = BinarySearch(arr, 0, arr.Length - 1, 6);
            Console.WriteLine(@"result: {0}", index);
        }

        static int BinarySearch(int[] a, int low, int high, int x)
        {
            if (low > high) return -1;
            int mid = low + (high - low) / 2;
            if (x == a[mid])
                return mid;
            else if (x < a[mid])
                return BinarySearch(a, low, mid - 1, x);
            else
                return BinarySearch(a, mid + 1, high, x);
        }
    }
}
