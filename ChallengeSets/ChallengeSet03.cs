using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var item in vals)
            {
                if (item == false) return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers == null) return false;
            foreach (var item in numbers)
            {
                if (item % 2 != 0) sum += item;
            }
            if (sum % 2 != 0) return true;
            return false;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {

            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }
        public int[] GetOddsBelow100()
        {
            List<int> nums = new List<int>();
            for (int i = 1; i < 100; i += 2)
            {
                nums.Add(i);
            }
            return nums.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
