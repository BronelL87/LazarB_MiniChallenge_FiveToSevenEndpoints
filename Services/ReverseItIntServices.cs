using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_MiniChallenge_FiveToSevenEndpoints.Services
{
    public class ReverseItIntServices
    {

        public string ReverseInts(string userInt)
        {

            if (int.TryParse(userInt, out _))
            {

                char[] userNumbers = userInt.ToCharArray();
                Array.Reverse(userNumbers);


                string reverseNumbers = new string(userNumbers);

                return $"Your numbers in reverse is: {reverseNumbers}";
            }
            else
            {
                return $"Invalid Data Type. Your numbers must be valid integers";
            }

        }
    }
}