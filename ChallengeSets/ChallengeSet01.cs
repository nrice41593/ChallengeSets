using System;
namespace ChallengeSets
{
    public class ChallengeSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            return false;
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double answer = minuend - subtrahend;
            return answer;
        }

        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            int smallestnumber = Math.Min(number1, number2);
            return smallestnumber;
        }

        public long Multiply(long factor1, long factor2)
        {
            long c = factor1 * factor2;
            return (c);
        }

        public string GetGreeting(string nameOfPerson)
        {
           if (nameOfPerson == "")
            {
                return "Hello!";
            }

           else
            {
                return $"Hello, {nameOfPerson}!";
            }
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
