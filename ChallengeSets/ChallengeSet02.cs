using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0 ? true : false);
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double max = Double.MinValue;
            double min = Double.MaxValue;
            if (numbers == null)
            {
                return 0;
            }
            foreach (double value in numbers)
            {
                if (max < value)
                {
                    max = value;
                }
            }
            foreach (double value in numbers)
            {
                if (min > value)
                {
                    min = value;
                }
            }
            return min + max;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            return sum;
        }


        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sumOfEvens = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    sumOfEvens += i;
                }
            }
            return sumOfEvens;

        }



        public bool IsSumOdd(List<int> numbers)
        {
            var sums = 0;
            if (numbers == null)
            {
                return false;
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    sums += numbers[i];
                }
            }
            if (sums % 2 == 0)
            {
                return false;
            }
            return true;
        }



        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int oddsCounter = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    oddsCounter++;
                }
            }
            return oddsCounter;

        }
        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;
        }
    }

}



