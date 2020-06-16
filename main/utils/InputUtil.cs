using System;

namespace IOUtils
{
    public class InputUtil
    {
        public static int parseInt(string input)
        {
            if (input == "")
                return -1;

            int n = Int32.Parse(input);
            if (n == 0 || n < 0) return -1;

            return n;
        }
    }
}