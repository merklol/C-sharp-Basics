using System;

//12. Calculate the average score of the 10 students. (use function)
//1) Read 10 scores into float array score.
//2) Write a function named average() that accepts an integers array as input, which
//calculates and average value of them, and return the result to it's caller function.
//3) test this function in a program. Make sure your function is called from main() 
//and correctly returns a value to main(). Display the value returned by average()
//in main();
public class Functions : Application
{
    public Functions(string title) : base(title) { }

    public override void main()
    {
        //my input
        float[] scores = { 99.2f, 99.2f, 59.1f, 42.7f, 29.1f, 19.0f, 74.4f, 43.5f, 33.3f, 99.9f };

        //test that the average function return expected value;
        Console.WriteLine("Test: " + assertTrue(average(scores), 59.940002f));

        Console.WriteLine(average(scores));
    }

    private float average(float[] scores)
    {
        float sum = 0;
        for (int i = 0; i < scores.Length; i++) sum += scores[i];

        return sum / scores.Length;
    }

    private bool assertTrue(float actual, float expected)
    {
        return actual == expected;
    }
}
