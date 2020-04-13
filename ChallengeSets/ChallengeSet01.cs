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
            else return false; 
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double sum = (minuend - subtrahend);
            return sum;
        }

        public int Add(int number1, int number2)
        {
           var sum = number1 + number2;
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if(number1 <= number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            var sum = factor1 * factor2;
            return sum;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if(nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                var name = "Hello" + ", " + nameOfPerson + "!";
                return name;
            }
                        
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
