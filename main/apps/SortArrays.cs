using System;

//8. Read in 20 integers into an array, then arrange elements in 
//the list according to their values, in ascending order.(use looping)
public class SortArrays : Application
{
    public SortArrays(string title) : base(title) { }
    public override void main()
    {

        Console.WriteLine("Rearanging the elements in the list according to their values");
        //my input
        int[] arr = { 20, 108, 303, 100, 500, 321, 200, 10, 85, 91, 102, 103, 13, 15, 21, 24, 27, 22, 19, 3000 };
        qsort(arr);
        printArray(arr);
    }

    private void qsort(int[] arr)
    {
        int temp;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }

    private void printArray(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
            if (i != 0)
                Console.Write(arr[i] + " ");
            else
                Console.WriteLine(arr[i]);
    }
}