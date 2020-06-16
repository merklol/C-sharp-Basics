using System;
using UnitTests;
using IOUtils;

//13. Calculate the difference between the largest number and the smallest number of 3 numbers.
//1) Read 3 numbers into int variables a, b, c.
//2) Call the function dif(a, b, c) to calculate the difference between the largest number and the smallest number.
//3)The function dif(a, b, c) calls the function max(a, b, c) to calculate the largest number.
//and call the function min(a, b, c) to calculate the smallest number.
public class Functions2 : Application
{
    public Functions2(string title) : base(title) { }

    public override void main()
    {
        //Tests
        Test.assertTrue(max(100, 20, 50), 100);
        Test.assertTrue(min(100, 20, 50), 20);
        Test.assertTrue(dif(100, 20, 50), 80);

        Console.WriteLine("Enter first number:");

        string input = Console.ReadLine();
        int n1 = InputUtil.parseInt(input);
        if (n1 == -1)
        {
            Console.WriteLine("Sorry! Wrong input.");
            return;
        }

        Console.WriteLine("Enter second number:");
        int n2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter three number:");
        int n3 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("The difference between the largest number and the smallest number " + dif(n1, n2, n3));
    }

    private int dif(int a, int b, int c)
    {
        int largest = max(a, b, c);
        int smallest = min(a, b, c);

        return largest - smallest;
    }

    private int max(int a, int b, int c)
    {
        int max = c;
        if (a >= b && a >= c)
            max = a;
        else if (b >= a && b >= c)
            max = b;

        return max;
    }

    private int min(int a, int b, int c)
    {
        int min = c;
        if (a <= b && a <= c)
            min = a;
        else if (b <= a && b <= c)
            min = b;

        return min;
    }
}