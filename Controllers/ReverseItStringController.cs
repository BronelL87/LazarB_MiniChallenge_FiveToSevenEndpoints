using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LazarB_MiniChallenge_FiveToSevenEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace LazarB_MiniChallenge_FiveToSevenEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItStringController : ControllerBase
    {
        private readonly ReverseItStringServices _reverseItStringServices;

        public ReverseItStringController(ReverseItStringServices reverseItStringServices)
        {
            _reverseItStringServices = reverseItStringServices;
        }

        [HttpPost]
        [Route("ReverseString/{userString}")]

        public string ReverseString(string userString)
        {
            return _reverseItStringServices.ReverseStrings(userString);
        }
    }
}