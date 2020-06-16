using System;

//10. Read a sting into an array from keyboard，count the number of the given character a in the string.
public class Arrays2 : Application
{
    public Arrays2(string title) : base(title) { }

    public override void main()
    {
        Console.WriteLine("Enter string:");
        string input = Console.ReadLine();
        if (input == "" || input.Length < 1)
        {
            Console.WriteLine("Sorry! Wrong input.");
            return;
        }

        int counter = 0;
        input = input.ToLower();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Equals('a')) counter++;
        }

        Console.WriteLine("The number of the character a in the string is {0}", counter);
    }
}