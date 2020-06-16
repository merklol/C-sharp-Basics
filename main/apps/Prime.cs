using System;
using IOUtils;

//4. Write a program，read an integer number form keyboard，tell whether the given number is 'Prime' 
//or 'not prime' and print the message”NUMBER IS Prime” or “NUMBER IS Not Prime”
public class Prime : Application
{
    private string msg1 = "The number is not prime";
    private string msg2 = "The number is prime";
    private string output = "";

    public Prime(string title) : base(title) { }

    public override void main()
    {
        Console.WriteLine("Enter number:");

        string input = Console.ReadLine();
        int n = InputUtil.parseInt(input);
        if (n == -1)
        {
            Console.WriteLine("Sorry! Wrong input.");
            return;
        }
        if (n == 0 || n == 1) output = msg1;

        output = isPrime(n) ? msg2 : msg1;
        Console.WriteLine(output);
    }

    private bool isPrime(int n)
    {
        for (int i = 2; i <= Math.Sqrt(n); i++) if (n % i == 0) return false;
        return true;
    }
}