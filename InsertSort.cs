int[] arr = new int[5] { 5, 3, 1, 2, 4 };
insertSort();
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
void insertSort()
{
    for (int i = 1; i < arr.Length; i++)
    {
        int j = i;
        while (j > 0 && arr[j - 1] > arr[j])
        {
            swap(arr, j - 1, j);
            j--;
        }
    }
}

void swap(int[] arr, int k, int m)
{
    int temp = arr[k];
    arr[k] = arr[m];
    arr[m] = temp;
}