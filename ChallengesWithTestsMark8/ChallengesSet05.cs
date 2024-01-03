using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            for (int i = startNumber ; ; i++)
            {
                if (startNumber % n == 0)
                {
                    i++;
                }
                if (i % n == 0)
                {
                    return i;
                }
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business bus in businesses)
            {
                if (bus.TotalRevenue == 0)
                {
                    bus.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {

            if (words == null || words.Length == 0 || words[0] == " ")
            {
                return ""; 
            }
            List<string> cleanedWords = words
                .Select(word => word.Trim())
                .Where(word => !string.IsNullOrWhiteSpace(word))
                .ToList();
            string sentence = string.Join(" ", cleanedWords);
            sentence += ".";
            sentence = char.ToUpper(sentence[0]) + sentence.Substring(1);

            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> doubles = new List<double>();
            if (elements == null || elements.Count == 0)
            {
                return doubles.ToArray();
            }
            for (int i = 3; i < elements.Count; i += 4)
            {
                doubles.Add(elements[i]);
            }
            return doubles.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums.Length < 2)
            {
                return false;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int num = targetNumber - nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != i && nums[j] == num)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
