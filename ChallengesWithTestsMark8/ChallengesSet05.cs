using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        private object buisness;

        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            do
            { startNumber++; } while (startNumber % 2 != 0);

            return startNumber;


        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue <= 0)
                {
                    business.Name = "CLOSED";
                }

            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return false;

            var orderNums = numbers.OrderBy(num => num).ToArray();

            return (orderNums.SequenceEqual(numbers));





        }

        public int SumElementsThatFollowAnEven(int[] numbers)

        {
            int sum = 0;

            if (numbers == null || numbers.Length == 0)

                return 0;


            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] % 2 == 0)

                {
                    sum += numbers[i];


                }
         

            }

            return sum;



        }
        public string TurnWordsIntoSentence(string[] words)
        {

            string sentence = "";
            if (words == null || words.Length == 0)
            {
                return "";
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Trim().Length > 0)

                {
                    sentence += words[i].Trim() + " ";

                }
                

            }

            if (sentence.Length == 0)
            {
                return "";
            }
            sentence = sentence.Trim();

            sentence += ".";

            return sentence;

        }

            public double[] GetEveryFourthElement(List<double> elements)
            {

            var numList = new List<double>();
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            for (var i = 3; i < elements.Count; i += 4)
            {
                numList.Add(elements[i]);


            }
            return numList.ToArray();

            }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int b = i + 1; b < nums.Length; b++)
                {
                    if (nums[i] + nums[b] == targetNumber)
                    {
                        return true;
                    }

                }
               

            }
            return false;

            
            

            

            }
        }
    }
