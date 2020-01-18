using System;
using System.Linq;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int even = 0;
            int odd = 0;
            int result = 0;
            foreach(var num in numbers)
            {
                if (num % 2 == 0)
                {
                    even += num;
                }
                if (num % 2 != 0)
                {
                    odd -= num;
                }
                result = even + odd; 
            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            if (str2.Length > str3.Length)
            {
                return str3.Length;
            }
            if (str3.Length > str4.Length)
            {
                return str4.Length;
            }
            return str1.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestNum = number1;

            if (smallestNum >= number2)
            {
                smallestNum = number2;
            }

            if (smallestNum >= number3)
            {
                smallestNum = number3;
            }

            if (smallestNum >= number4)
            {
                smallestNum = number4;
            }

            return smallestNum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            Business business = new Business();
            {
                biz.Name = "TrueCoders";
            }
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int a = sideLength1;
            int b = sideLength2;
            int c = sideLength3;
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            double result;
            if (Double.TryParse(input, out result)) return true;
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null) nullCount++;
            }
            if (nullCount > objs.Length / 2) return true;
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            double sum = 0;
            double count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                    count++;
                }
            }

            if ((int)count == 0) return 0;
            return sum / count;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 0) return 1;

            return number * Factorial(number - 1);
        }
    }
}
