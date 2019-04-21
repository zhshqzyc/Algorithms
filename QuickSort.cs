using System;

namespace QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 80, 30, 90, 40, 50, 70 };
            QSort(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int partitionIndex = start;
            for (int i = start; i < end; i++)
            {
                if (arr[i] <= pivot)
                {
                    Swap(ref arr[i], ref arr[partitionIndex]);
                    partitionIndex++;
                }
            }
            Swap(ref arr[partitionIndex], ref arr[end]);
            return partitionIndex++;
        }

        private static void Swap(ref int i,ref int j)
        {
            int temp;
            temp = i;
            i = j;
            j = temp;
        }

        static void QSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int partitionIndex = Partition(arr, start, end);
                QSort(arr, start, partitionIndex - 1);
                QSort(arr, partitionIndex + 1, end);
            }
        }
    }
}
