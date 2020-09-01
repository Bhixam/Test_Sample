using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicketMachine.Contracts;



namespace TicketMachine.Controllers
{
    [Route("api/[controller]")]
    public class TrainStationController : Controller
    {
        IStation _Istation;

        public TrainStationController(IStation Istation)
        {
            _Istation = Istation;

        }

        [HttpGet]
        public ActionResult<char> GetNextChar(string str, string input)
        {
            return _Istation.GetNextCharacter(str, input);

        }
        [HttpGet]
        public ActionResult<string> GetAllStartsWithName(string input)
        {
            return _Istation.GetAllStartsWithName(input).ToString();
        }



    }
}
