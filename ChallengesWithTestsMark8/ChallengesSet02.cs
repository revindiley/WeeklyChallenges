using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var alpha = "abcdefghijklmnopqrstuvwxyz";
            return alpha.Contains(char.ToLower(c));
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
         // return vals.Length % 2 == 0; <----  you could also write it like this 
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
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            double min = 0;
            double max = 0;

            foreach(var num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }

                if (numbers.Count() <= 1)
                {
                    min = num;
                }
            }
            return min + max;
            // could also be written as ---> return numbers?.Any() ??false ? numbers.Min() + numbers.Max() : new double {};
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
            //could also be written as ----> return (str1.Length < str2.Length) ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            var sum = 0;

            for(var i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
            //could also be written as ----> return (numbers == null) ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            var evenSum = 0;

            for (int i = 0; i < numbers.Length;i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
            }
            return evenSum;
            //could also be written as -----> return numbers?.Where(x => x % 2 == 0).Sum() ?? 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null )
            {
                return false;
            }

            var sum = 0;

            for(int i = 0; i < numbers.Count ; i++)
            {
                sum += numbers[i];
            }
            return (sum %2 != 0);
            //could also be written as ----> return (numbers == null) ? false : numbers.Sum() % 2 != 0
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
            //could also be written as -----> retrurn(number <=0) ? 0 : number / 2; 
        }
    }
}
