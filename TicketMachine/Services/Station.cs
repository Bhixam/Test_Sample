using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketMachine.Contracts;
using TicketMachine.Models;

namespace TicketMachine.Services
{
    public class Station : IStation
    {
         
       
       
        public List<SearchTrainStationResult> GetAllStartsWithName(string input)
        {
            try
            {
                string[] arraystations = GetAllStations();
                List<SearchTrainStationResult> searchResultList = new List<SearchTrainStationResult>();

                 for (int i = 0; i < Stations.stations.Length; i++)
                {
                    if (arraystations[i].StartsWith(input))
                    {
                        searchResultList.Add(new SearchTrainStationResult
                        {
                            station = arraystations[i],
                            nextCharacter = GetNextCharacter(arraystations[i], input)
                        });
                    }
                }

                return searchResultList;
            }

            catch
            {
                return Enumerable.Empty<SearchTrainStationResult>().ToList();
            }
        }
        public char GetNextCharacter(string reference, string input)
        {
            try
            {
                return reference.Replace(input, String.Empty).ToCharArray().ToList()[0];
            }

            catch
            {
                return (char)0;
            }
        }


        
        public string[] GetAllStations()
        {
            return Stations.stations;
        }
    }
}
