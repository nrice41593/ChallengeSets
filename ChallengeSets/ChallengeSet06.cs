using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) return false;
            foreach (var item in words)
            {
                if (item == null) continue;
                if (ignoreCase)
                {
                    if (item.ToLower() == word.ToLower()) return true;
                }
                else if (item == word) return true;
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
                if (num % i == 0)
                    return false;

            return true;

        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            string substring = "";

            if (str.Length == 0) return index;

            for (int i = 0; i < str.Length; i++)
            {
                substring = str.Substring(i, 1);
                if (str.IndexOf(substring) == str.LastIndexOf(substring)) index = i;
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int startNum = 1, count = 1; 
            for (int i = 0; i < (numbers.Length - 1); i++)
            {
                if (numbers[i + 1] == numbers[i]) count++;
                else count = 1;
                if (count > startNum) startNum = count; 
            }
            return startNum;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n < 1) return new double[0];

            List<double> newList = new List<double>();
            for (int i = n - 1; i < elements.Count; i += n)
            {
                newList.Add(elements[i]);
            }
            return newList.ToArray();
        }
    }
}
