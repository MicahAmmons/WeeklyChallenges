using System;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers) 
            {
                if (num % 2 == 0)
                {
                    total += num;
                }
                if (num % 2 != 0) 
                { 
                    total -= num;
                }
            }
            return total;

            }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {

           return (Math.Min(Math.Min(Math.Min(str1.Length, str2.Length),str3.Length),str4.Length));
                   
         //   string lead;
         //   if (str1.Length <= str2.Length) 
         //   {
         //      lead = str1;
         //   }
         //   else
         //   {
         //       lead = str2;
         //   }
         //   if (str3.Length <= lead.Length)
         //   {
         //       lead = str3;
         //   }
         //   if (str4.Length <= lead.Length)
         //   {
         //       lead = str4;
         //   }return lead.Length;
         }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(Math.Min(number1, number2),number3), number4);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return ((sideLength1 + sideLength2) > sideLength3 && ((sideLength1 + sideLength3) > sideLength2 && ((sideLength2 + sideLength3) > sideLength1))) ? true : false;

            //if ((sideLength1 + sideLength2) > sideLength3 && ((sideLength1 + sideLength3) > sideLength2 && ((sideLength2 + sideLength3) > sideLength1)))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public bool IsStringANumber(string input)
        {
            double result;
            return double.TryParse(input, out result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int nonNullCount = 0;
            foreach (object obj in objs) 
            {
               if (obj == null)
                {
                    nullCount++;
                }
               else if (obj != null) 
                {
                    nonNullCount++;
                }
            }return nonNullCount < nullCount;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0.0;
            }
            double evens = 0;
            double countEvens = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens += num;
                    countEvens++;
                }
                
            }
            if (countEvens == 0)
            {
                return 0;
            }
            return (evens / countEvens);
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("TRY AGAIN NERD MAKE IT A POSITIVE NUMBER OR I'M POSITIVE YOU A DUMB DUMB");
            }
            int final = 1;
            for (int i = 2; i <= number; i++)
            {
                final *= i;
            }return final;
        } 
    }
}
