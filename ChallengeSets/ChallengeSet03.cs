using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool containsFalse = false;
                for(int i = 0; i < vals.Length; i++)
            {

                if (vals[i] == false)
                {
                    return true;
                }                
            }
            return containsFalse;
            
            
            
        }


        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var sum = 0;            
            if(numbers == null)
            {
                return false;
            }
            foreach(var num in numbers)
            {
                if(num % 2 != 0)
                {
                    sum = sum + num;
                }
                               
            }
            return (sum % 2 != 0); 
        }         

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var containsUpper = false;
            var containsLower = false;
            var containsNumber = false;
            for(int i =0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    containsUpper = true;
                }
                if (char.IsLower(password[i]))
                {
                    containsLower = true; 
                }
                if (char.IsNumber(password[i]))
                {
                    containsNumber = true;
                }
            }
                if(containsNumber && containsLower && containsUpper)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }

        public char GetFirstLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {

            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }
        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
