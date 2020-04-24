using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum -= i;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestLength = 100000;
            if (str1.Length < shortestLength)
            {
                shortestLength = str1.Length;
            }
            if (str2.Length < shortestLength)
            {
                shortestLength = str2.Length;
            }
            if (str3.Length < shortestLength)
            {
                shortestLength = str3.Length;
            }
            if (str4.Length < shortestLength)
            {
                shortestLength = str4.Length;
            }
            return shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int lowestValue = 100000;
            if (number1 < lowestValue)
            {
                lowestValue = number1;
            }
            if (number2 < lowestValue)
            {
                lowestValue = number2;
            }
            if (number3 < lowestValue)
            {
                lowestValue = number3;
            }
            if (number4 < lowestValue)
            {
                lowestValue = number4;
            }
            return lowestValue;

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3
                && sideLength1 + sideLength3 > sideLength2
                && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            if(double.TryParse(input, out double value))
            {
                return true;
            }
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int itemCount = objs.Length;
            int nullCount = 0;
            foreach (object obj in objs)
            {
                if (obj == null) nullCount++;
            }
            if (nullCount > itemCount / 2)
            {
                return true;
            }
            return false;

        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int evenSum = 0;
            int evenCount = 0;
            foreach (int i in numbers)
            {
                if (i % 2 ==0)
                {
                    evenSum += i;
                    evenCount++;
                }
            }
            if (evenCount == 0)
            {
                return 0;
            }
            return (double)evenSum / evenCount;
        }

        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException();
            if (number == 0) return 1;
            if (number > 1)
            {
                return number * Factorial(number - 1);
            }
            else
            {
                return number;
            }
        }
    }
}
