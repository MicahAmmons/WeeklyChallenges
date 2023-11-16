using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool val in vals)
            {
                if (val == false)
                {
                    return true;
                }
            }
            return false;

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                if (i % 2 != 0)
                {
                    sum += sum;
                }
            }
            return sum % 2 != 0 ? true : false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool lower = false;
            bool upper = false;
            bool number = false;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    number = true;
                }
                if (char.IsUpper(c))
                {
                    upper = true;
                }
                if (char.IsLower(c))
                {
                    lower = true;
                }
            }
            return number == true && lower == true && upper == true ? true : false;
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
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddNumbersUnder100 = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (1 % 2 != 0)
                {
                    oddNumbersUnder100.Add(i);
                }

            }
            return oddNumbersUnder100.ToArray();

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