using System;

//11. Write a program to reverse the characters of a string.
public class StringReverse : Application
{
    public StringReverse(string title) : base(title) { }

    public override void main()
    {
        Console.WriteLine("Enter string:");
        string input = Console.ReadLine();
        if (input == "" || input.Length < 1)
        {
            Console.WriteLine("Sorry! Wrong input.");
            return;
        }

        Console.WriteLine(reverse(input));

    }

    private string reverse(string str)
    {
        char[] arr = str.ToCharArray();
        for (int i = 0; i < arr.Length / 2; i++)
        {
            char temp = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = temp;
        }

        return string.Join("", arr);
    }
}