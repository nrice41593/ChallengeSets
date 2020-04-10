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
            throw new NotImplementedException();
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
