using System;

//6. Write a program, the running result of following program is as follows(using looping)
//     5
//    666
//   77777
//  8888888
public class Loops : Application
{
    private string line1 = "";
    private string line2 = "";
    private string line3 = "";
    private string line4 = "";
    public Loops(string title) : base(title) { }

    public override void main()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i != 5) line1 += " "; else line1 += "5";

            if (i == 4)
                for (int j = 0; j < 3; j++) line2 += "6";
            else
                line2 += " ";

            if (i == 3)
                for (int k = 0; k < 5; k++) line3 += "7";
            else
                line3 += " ";

            if (i == 2)
                for (int k = 0; k < 7; k++) line4 += "8";
            else
                line4 += " ";

        }

        Console.WriteLine(line1);
        Console.WriteLine(line2);
        Console.WriteLine(line3);
        Console.WriteLine(line4);
    }
}