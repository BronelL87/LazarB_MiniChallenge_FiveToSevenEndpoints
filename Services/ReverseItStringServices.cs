using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_MiniChallenge_FiveToSevenEndpoints.Services
{
    public class ReverseItStringServices
    {
        public string ReverseStrings(string userString)
        {
            string reverseString = "";
            for (int i = userString!.Length - 1; i >= 0; i--)
            {
                reverseString += userString[i];
            }
            return $"Your String in Reverse is: {reverseString}";
        }
    }
}