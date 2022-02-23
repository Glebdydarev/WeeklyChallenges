using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {

            if (words == null || word == null)                return false;            foreach (var word2 in words)            {                if (word2 == null)                {                    return false;                }            }            if (ignoreCase == false)            {                if (words.Contains(word))                    return true;                else                    return false;            }

            foreach (string word2 in words)            {                if (word2.ToLower().Equals(word))                    return true;
            }            return false;


        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;            if (num == 2) return true;            if (num % 2 == 0) return false;            var maxb = (int)Math.Floor(Math.Sqrt(num));            for (int i = 3; i <= maxb; i += 2)                if (num % i == 0)                    return false;            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            return str.IndexOf(
                            str.Distinct()
                            .Reverse()
                            .Where(x =>
                         str.Where(y => y.Equals(x)).Count() == 1)
                            .FirstOrDefault()
                            );
        }

        public int MaxConsecutiveCount(int[] numbers)
        {

            var count = 0;            for (int i = 0; i < numbers.Length; i++)            {                var secondCount = 1;                for (int j = i + 1; j < numbers.Length; j++)                {                    if (numbers[i] != numbers[j])                    {                        break;                    }                    secondCount++;                }                if (secondCount > count)                    count = secondCount;            }            return count;


        }

        public double[] GetEveryNthElement(List<double> elements, int n)


        {

            var list = new List<double>();            if (n < 0)            {                return list.ToArray();            }            if (elements is null)            {                return list.ToArray();            }            for (int i = 0; i < elements.Count; i++)            {                if (elements[i] % n == 0)                {                    list.Add(elements[i]);                }

            }            return list.ToArray();        }

    }






        
    }
}
