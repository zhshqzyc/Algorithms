using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectSort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7] { 64, 34, 25, 12, 22, 11, 90 };
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[minIndex] > arr[j])
                        Swap(arr, minIndex, j);
                }
            }
            foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }

                Console.ReadKey();
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
