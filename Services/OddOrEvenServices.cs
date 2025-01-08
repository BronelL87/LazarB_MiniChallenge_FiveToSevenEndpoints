using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_MiniChallenge_FiveToSevenEndpoints.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEvens(string numberInput)
        {
            int realNum;

            if (int.TryParse(numberInput, out realNum) && (realNum % 2 == 0))
            {
                return $"{realNum} is an Even number";
            }
            else if (int.TryParse(numberInput, out realNum) && (realNum % 2 != 0))
            {
                return $"{realNum} is an Odd number";
            }
            else
            {
                return "Invalid Data Type, input needs to be an integer";
            }
        }
    }
}