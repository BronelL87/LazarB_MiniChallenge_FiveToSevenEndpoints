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
    public class ReverseItIntController : ControllerBase
    {
        private readonly ReverseItIntServices _reverseItIntServices;

        public ReverseItIntController(ReverseItIntServices reverseItIntServices)
        {
            _reverseItIntServices = reverseItIntServices;
        }

        [HttpPost]
        [Route("ReverseInt/{userNumbers}")]

        public string ReverseInt(string userNumbers)
        {
            return _reverseItIntServices.ReverseInts(userNumbers);
        }
    }
}