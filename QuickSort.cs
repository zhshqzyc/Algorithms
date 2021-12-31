// quick sort has three steps.
// 1) pick any number as pivot
/* 2) move allnumbers in the array that are lower than the pivot to the left of it and all 
      numbers that are higher than the pivot to the right of it. (partitioning)
*/
// 3) reqursively quick sort all the values to the left of that pivot and all the values to the right of the pivot. 
// https://www.youtube.com/watch?v=h8eyY7dIiN4
int[] arr = new int[8] { 2, 8, 5, 3, 9, 4, 1, 7 };
quickSort(arr, 0, arr.Length - 1);
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
void quickSort(int[] array, int lowIndex, int highIndex)
{
    if (lowIndex >= highIndex){
        return;
    }
    // step 1 -- select pivot
    int pivot = array[highIndex];
    int leftPointer = lowIndex;
    int rightPointer = highIndex;
    // step 2 -- partitioning
    while (leftPointer < rightPointer)
    {
        while (array[leftPointer] <= pivot && leftPointer < rightPointer)
        {
            leftPointer++;
        }
        while (array[rightPointer] >= pivot && leftPointer < rightPointer)
        {
            rightPointer--;
        }
        swap(array, leftPointer, rightPointer);
    }
    swap(array, leftPointer, highIndex);
    // step 3 -- recursively quick sort
    quickSort(array, lowIndex, leftPointer - 1);
    quickSort(array, leftPointer + 1, highIndex);
}
void swap(int[] arr, int k, int m)
{
    int temp = arr[k];
    arr[k] = arr[m];
    arr[m] = temp;
}
