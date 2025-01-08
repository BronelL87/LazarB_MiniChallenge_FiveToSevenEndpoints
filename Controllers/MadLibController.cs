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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;

        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }

        [HttpPost]
        [Route("MadLib/{name}/{place}/{adjective}/{animal}/{verb}/{color}/{noun}/{number}/{vehicle}/{profession}")]

        public string MadLib(string name, string place, string adjective, string animal, string verb, string color, string noun, string number, string vehicle, string profession)
        {
            return _madLibServices.MadLibs(name, place, adjective, animal, verb, color, noun, number, vehicle, profession);
        }
    }
}