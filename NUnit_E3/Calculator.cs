using System;

namespace NUnit_E3
{
    class Calculator
    {
        public int CalculateSum(int[] numbers)
        {
            if(numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
