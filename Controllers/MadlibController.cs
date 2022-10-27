//Lerissa Lazar
//10-26-22
//madlib
//user inputs words into the url and the comupter will output a story with the words inserted
//Peer Reveiwed By: Kenneth Fujimura -- Everything works as intended. The story was short and sweet. All of the variables in the API and the URL pointed to the right places. Great job! Just don't forget to add the rest of the comments to the top of this .cs file and I think you're good!

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LazarL_MiniChMadlibEndPoint.Controllers
{
    [Route("[controller]")]
    public class MadlibController : Controller
    {
        [HttpGet]
        [Route("Mad/{location}/{animal}/{celebrity1}/{celebrity2}/{adjective1}/{adjective2}/{verb1}/{verb2}/{car}/{food}")]
        public string Lib(string location, string animal, string celebrity1, string celebrity2, string adjective1, string adjective2, string verb1, string verb2, string car, string food)
        {
           return $"I was in the middle of {location} when I caught the smell of a {animal} roasting. I looked into the distance, and saw {celebrity1} staring at me. {celebrity2} called me {adjective1} and {adjective2}, so I started to {verb1} and {verb2}. I then saw a {car} and stole it to go to {food}.";
        }
    }
}