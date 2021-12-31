int[] arr = new int[8] { 2, 8, 5, 3, 9, 4, 1, 7 };
mergeSort(arr);
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
void mergeSort(int[] inputArray)
{
    int inputLength = inputArray.Length;
    if (inputLength < 2) return;
    int midIndex = inputLength / 2;
    int[] leftHalf = new int[midIndex];
    int[] rightHalf = new int[inputLength - midIndex];
    for (int i = 0; i < midIndex; i++)
    {
        leftHalf[i] = inputArray[i];
    }
    for (int i = midIndex; i < inputLength; i++)
    {
        rightHalf[i - midIndex] = inputArray[i];
    }
    mergeSort(leftHalf);
    mergeSort(rightHalf);
    merge(inputArray, leftHalf, rightHalf);
}
void merge(int[] inputArray, int[] leftHalf, int[] rightHalf)
{
    int leftSize = leftHalf.Length;
    int rightSize = rightHalf.Length;
    int i = 0, j = 0, k = 0;
    while (i < leftSize && j < rightSize)
    {
        if (leftHalf[i] < rightHalf[j])
        {
            inputArray[k] = leftHalf[i];
            i++;
        } 
        else
        {
            inputArray[k] = rightHalf[j];
            j++;
        }
        k++;
    }
    while(i < leftSize)
    {
        inputArray[k] = leftHalf[i];
        i++;
        k++;
    }
    while(j < rightSize)
    {
        inputArray[k] = rightHalf[j];
        j++;
        k++;
    }
}
