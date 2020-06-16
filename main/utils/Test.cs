using System;

namespace UnitTests
{
    public class Test
    {
        public static void assertTrue(float actual, float expected)
        {
            string res = actual == expected ? "Test completed." : "Test failed.";
            Console.WriteLine("Actual:{0}, Expected:{1}. {2}", actual, expected, res);
        }

        public static void assertTrue(int actual, int expected)
        {
            string res = actual == expected ? "Test completed." : "Test failed.";
            Console.WriteLine("Actual:{0}, Expected:{1}. {2}", actual, expected, res);
        }

        public static void assertTrue(string actual, string expected)
        {
            string res = actual.Equals(expected) ? "Test completed." : "Test failed.";
            Console.WriteLine("Actual:{0}, Expected:{1}. {2}", actual, expected, res);
        }
    }
}