using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketMachine.Models;

namespace TicketMachine.Contracts
{
   public interface IStation
    {
        
        string[] GetAllStations();

       
        List<SearchTrainStationResult> GetAllStartsWithName(string input);

        
        char GetNextCharacter(string str, string input);
    }
}
