using System;
using IOUtils;
using UnitTests;

//5. According to the score, decide the grade.(use if or switch)
//1) score >= 80: grade A;
//2) score >= 60 && score < 80: grade B;
//3) score < 60: grade C;
public class Grade : Application
{

    public Grade(string title) : base(title) { }

    public override void main()
    {
        //Test
        Test.assertTrue(getGrade(90), "Grade A");

        Console.WriteLine("Enter score:");
        string input = Console.ReadLine();
        int n = InputUtil.parseInt(input);
        if (n == -1 || n > 100)
        {
            Console.WriteLine("Sorry! Wrong input.");
            return;
        }

        Console.WriteLine(getGrade(n));
    }

    private string getGrade(int n)
    {
        if (n >= 80)
            return "Grade A";
        else if (n >= 60 && n < 80)
            return "Grade B";
        else
            return "Grade C";
    }
}