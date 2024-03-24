using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    class Program
    {

        public double GetAverage(int[] array)
        {
            if(array.Length == 0)
            {
                return 0;
            }
         
            double sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum / array.Length;
        }

        public bool IsPrime(int number)
        {
            if(number < 2)
            {
                return false;
            }

            if(number == 2)
            {
                return true;
            }

            if(number %2 == 0)
            {
                return false;
            }

            int sqrt = (int)Math.Sqrt(number);

            for (int i = 3; i <= sqrt; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int GetLargest(int[] array)
        {
            if(array.Length == 0)
            {
                return -1;
            }
            int largest = array[0];

            for(var i = 0; i < array.Length; i++)
            {
                if (array[i] > largest)
                {
                    largest = array[i];
                }
            }

            return largest;
        }
    }

}
