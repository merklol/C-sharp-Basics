using System;
using UnitTests;

//7. Read in 10 integers, and find out the maximum and the minumum and the average.(use array)
public class Arrays : Application
{
    public Arrays(string title) : base(title) { }

    public override void main()
    {
        //Tests
        Test.assertTrue(max(new int[] { 2, 3, 5 }), 5);
        Test.assertTrue(min(new int[] { 2, 3, 5 }), 2);
        Test.assertTrue(average(new int[] { 2, 3, 5 }), 3);

        Console.WriteLine("Enter numbers: ");
        string input = Console.ReadLine();
        if (input == "" || !input.Contains(",") || input.Length < 2)
        {
            Console.WriteLine("Sorry! Wrong input.");
            return;
        }

        string[] temp = input.Split(",");
        int[] numbs = new int[temp.Length];
        for (int i = 0; i < temp.Length; i++) numbs[i] = Int32.Parse(temp[i]);




        Console.WriteLine("The min value in the array is " + min(numbs));
        Console.WriteLine("The maximum value in the array is " + max(numbs));
        Console.WriteLine("The average of the array elements is " + average(numbs));
    }

    private int max(int[] numbs)
    {
        int maxValue = numbs[0];
        for (int i = 0; i < numbs.Length; i++)
        {
            if (numbs[i] > maxValue) maxValue = numbs[i];
        }

        return maxValue;
    }

    private int min(int[] numbs)
    {
        int minValue = numbs[0];
        for (int i = 0; i < numbs.Length; i++)
        {
            if (numbs[i] < minValue) minValue = numbs[i];
        }
        return minValue;
    }

    private int average(int[] numbs)
    {
        int sum = 0;
        for (int i = 0; i < numbs.Length; i++) sum += numbs[i];
        return sum / numbs.Length;
    }
}