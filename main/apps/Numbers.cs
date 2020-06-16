using System;

//2. Output the nubmers, between 100 and 200, which can't be diveded exactly by 3.
public class Numbers : Application
{
    public Numbers(string title) : base(title) { }

    public override void main()
    {
        string str = "";
        Console.WriteLine("The nubmers between 100 and 200, which can't be diveded exactly by 3");
        for (int i = 100; i <= 200; i++)
        {
            if (i % 3 == 0 && i != 200) str += i + ",";
        }
        Console.WriteLine(str);
    }
}