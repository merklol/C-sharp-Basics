using System;

//9. Read 10 inteers into an array, and then rearange the elements 
//in the list according to their values, in ascending order.(use looping)
public class SortArrays2 : Application
{
    public SortArrays2(string title) : base(title) { }

    public override void main()
    {
        Console.WriteLine("Reversing the elements in the list");
        //my input
        int[] arr = { 20, 108, 303, 100, 500, 321, 200, 10, 85, 91 };
        reverse(arr);
        Console.WriteLine(string.Join(",", arr));
    }

    private void reverse(int[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = temp;
        }
    }
}