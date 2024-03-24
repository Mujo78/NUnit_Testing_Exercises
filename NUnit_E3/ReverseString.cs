using System;

namespace NUnit_E3
{
    public class ReverseString
    {
        public string ReverseStringMethod(string text)
        {
            if(text.Length == 0)
            {
                return "";
            }
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
