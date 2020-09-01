using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMachine.Models
{
    public class Result
    {
        
        public List<char> nextCharacters { get; set; }
        public List<string> stations { get; set; }


        public Result(List<SearchTrainStationResult> searchResults)
        {
            stations = new List<string>();
            nextCharacters = new List<char>();

            foreach (SearchTrainStationResult s in searchResults)
            {
                stations.Add(s.station);
                nextCharacters.Add(s.nextCharacter);
            }

            nextCharacters.Remove(nextCharacters.Where(c => c == (char)0).FirstOrDefault());
        }
    }
}

