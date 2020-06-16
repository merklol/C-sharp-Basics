using System;
using IOUtils;

//1.Write a program，read an integer number from keyboard，
//tell whether the given number is 'odd' or 'even' and print 
//the message”NUMBER IS EVEN” or “NUMBER IS ODD”
public class Odd : Application
{
    public Odd(string title) : base(title) { }

    public override void main()
    {
        Console.WriteLine("Enter number:");

        string input = Console.ReadLine();
        int n = InputUtil.parseInt(input);
        if (n == -1)
        {
            Console.WriteLine("Sorry! Wrong input.");
        }
        else
        {
            string output = n % 2 == 0 ? "Number is even." : "Number is odd.";
            Console.WriteLine(output);
        }
    }
}