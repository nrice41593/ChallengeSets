﻿using System;
using System.Collections.Generic;
using System.Linq;

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
            if(vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if(num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null)
            {
                return 0;
            }

            if(numbers.Count() == 0) 
            {
                return 0;
            }
            
            return numbers.Min() + numbers.Max();
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            var evenSteven = new List<int>();
            if(numbers == null)
            {
                return 0;
            }
            foreach(var num in numbers)
            {
                if(num % 2 == 0)
                {
                    evenSteven.Add(num);
                }
            }            
           
            return evenSteven.Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {          
            if(numbers == null)
            {
                return false;
            }
            return numbers.Sum() % 2 != 0;           
            
        }


        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var counter = 0;
            for(int i = 0; i < number; i++)
            {
                if(i % 2 != 0)
                {
                    counter++;
                }
            }
                return counter;
            
            

        }
    }
}
