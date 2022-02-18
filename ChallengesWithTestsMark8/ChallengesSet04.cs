using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        private double o;

        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;

            foreach (int i in numbers)
            {
                if (i % 2 == 0)

                {
                    sum += i;

                }
                else
                {
                    sum -= i;
                }

            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestLength = 10;

            if (str1.Length < shortestLength)
            {
                shortestLength = str1.Length;

            }

            if (str2.Length < shortestLength)
            {
                shortestLength = str2.Length;
            }
            if (str3.Length < shortestLength)
            {
                shortestLength = str3.Length;
            }
            if (str3.Length < shortestLength)
                shortestLength = str3.Length;

            if ( str4.Length < shortestLength)
            {
                shortestLength = str4.Length;
            }
            return shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>() { number1, number2, number3, number4 };
            return list.Min();

        }
             

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";



        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1&& sideLength3 + sideLength1 >sideLength2 )

            {
                return true;
            }
            return false;

        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;
            var count = 0;

            foreach (var obj  in objs)
            {
                if (obj == null)
                {
                    count++;
                }

            }

            if (count >= majority)
            {
                return true;


            }
            else
            {
                return false;
            }

        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)

            {
                return o;

            }

            var n = numbers.Where(num => num % 2 == 0);

            if (n.Count() == 0)

                return 0;

            return n.Average();

        }

            public int Factorial(int number)


            {
              var fact = 1;

            if (number < 0)
            {

                throw new ArgumentOutOfRangeException();
            }


            for ( int i = number; i > 0; i--)
            {
                fact *= i;

            }
            return fact;
           
            }
        
    }
}
