using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || word == null || words.Contains(null))
            {
                return false;
            }
            if (ignoreCase)
            {
                word = word.ToLower();
            }
            foreach (var item in words)
            {
                string comparisonItem = item;
                if (ignoreCase)
                {
                    comparisonItem = item.ToLower();
                }
                if (comparisonItem == word)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 2) { return true; }
            if (num <= 1 || num % 2 == 0)
            {
                return false;
            }

            int squarRoot = (int)Math.Sqrt(num);
            for (int i = 3; i <= squarRoot; i += 2)
            {
                if (num % i == 0) 
                {
                    return false;
                }
             }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                char currentChar = str[i];
                bool isUnique = true;
                for (int j = 0; j < str.Length; j++)
                {
                    if (i != j && currentChar == str[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int maxCount = 1;
            int currentCount = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
            {
                return new double[] { };
            }
            List<double> result = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }
    }
    }

