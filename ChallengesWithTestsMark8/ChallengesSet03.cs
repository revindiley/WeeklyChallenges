using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for(var i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
            //throw new NotImplementedException();
            //way to do it using LINQ vvvvv
            //return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //if (numbers == null)
            //{
            //    return false;
            //}


            //var odds = new List<int>();
            //foreach (var num in numbers) 
            //{
            //    if(num %2 != 0)
            //    {
            //        odds.Add(num);
            //    }
            //}

            //var sumOdds = odds.Sum();

            //return (sumOdds % 2 != 0);

            return (numbers == null) ? false : (numbers.Where(x => x % 2 != 0).Sum() % 2 != 0);
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLower = false;
            var isUpper = false;
            var isNumber = false;

            for(var i = 0; i < password.Length;i++)
            {
                if (char.IsLower(password[i]))
                {
                    isLower= true;
                }
                if (char.IsUpper(password[i]))
                {
                    isUpper= true;
                }
                if (char.IsNumber(password[i]))
                {
                    isNumber= true;
                }             
            }

            if (isLower == true && isUpper == true && isNumber == true)
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
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor== 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();

            for (var i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
                for(var i = 0; i <words.Length;i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
