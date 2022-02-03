using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        private int i;
        private int lenght;

        public decimal Decimal { get; private set; }
        public string ToLowerNumber { get; private set; }

        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {

                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }


    

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers ==  null)
            {
                return false;
            }
            return numbers.Sum() % 2 != 0;


        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {



            bool IsUpper = false;
            bool IsLower = false;
            bool IsNumber = false;

            foreach (var ch in password)
            {
                if (char.IsLower(ch))
                {
                    IsLower = true;
                    
                      
                    
                }
                if (char.IsUpper(ch))
                {
                    IsUpper = true;
                }

                if (char.IsNumber (ch))
                {
                    IsNumber = true;
                }

            }

            if (IsLower && IsUpper && IsNumber)
            {
                return  true;



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
            if (divisor == 0)
                {
                return 0;
                }
            return dividend / divisor;
                

        }

        

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length -1 ] - nums[0];
        }



        public int[] GetOddsBelow100()
        {
            var list = new List<int>();


            

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    list.Add(i);
                }
                   
                
                    
            }

            return list.ToArray();


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
