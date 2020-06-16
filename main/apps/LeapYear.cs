using System;
using IOUtils;

//3. Read in one year, and judge whenever it is a leap year or not.
public class LeapYear : Application
{
    private string msg1 = "{0} is a leap year.";
    private string msg2 = "{0} is not a leap year.";
    public LeapYear(string title) : base(title) { }
    public override void main()
    {
        Console.WriteLine("Enter a year: ");

        string input = Console.ReadLine();
        int year = InputUtil.parseInt(input);
        if (year == -1)
        {
            Console.WriteLine("Sorry! Wrong input.");
            return;
        }

        if (year % 4 == 0)
        {
            string temp = year % 100 == 0 ? year % 400 == 0 ? msg1 : msg2 : msg1;
            Console.WriteLine(temp, year);
        }
        else
            Console.WriteLine(msg2, year);
    }
}