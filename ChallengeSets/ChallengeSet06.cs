using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) return false;
            foreach (var str in words)
            {
                if (str == null) continue;
                if (ignoreCase && word.ToLower() == str.ToLower())
                {
                    return true;
                }
                else if (!ignoreCase && word == str)
                {
                    return true;
                }
            
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if(num <= 1) return false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int counter = 0;
            int last = 0;
            if (str == "")
            {
                return -1;
            }

            int[] counts = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                foreach (var letter in str)
                {
                    if (str[i] == letter)
                    {
                        counts[i]++;
                    }
                }
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] == 1)
                {
                    last = i;
                }
                else if (counts[i] > 1)
                {
                    counter++;
                }
            }
            if (counter == str.Length)
            {
                return -1;
            }
            return last;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            int previousNumber = numbers[0];
            int currentConsecutive = 1;
            int currentMaxConsecutive = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == previousNumber)
                {
                    currentConsecutive++;
                }
                if (currentConsecutive > currentMaxConsecutive)
                {
                    currentMaxConsecutive = currentConsecutive;
                }
                if(numbers[i] != previousNumber)
                {
                    currentConsecutive = 1;
                }
                previousNumber = numbers[i];
            }
            return currentMaxConsecutive;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if(elements == null || n < 0) return new double[0];
            List<double> everyNthElement = new List<double>();
            for (int i = 1; i <= elements.Count; i++)
            {
                if (i % n == 0)
                {
                    everyNthElement.Add(elements[i - 1]);
                }
            }
            return everyNthElement.ToArray();
        }
    }
}
