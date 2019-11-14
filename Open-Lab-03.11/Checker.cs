using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            for (var i = 0; i < str.Length / 2; i++)
                if (str[i] != str[str.Length - 1 - i])
                    return false;

            return true;
        } 
    }
}
