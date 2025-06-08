using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.MODEL
{
    public class TrainStation
    {
        public string Name { get; }
        public string ArrivalTrack { get; }
        public string ArrivalTime { get; }
        public string DepartureTime { get; }

        public TrainStation(string name, string track, string arrival, string departure)
        {
            Name = name;
            ArrivalTrack = track;
            ArrivalTime = arrival;
            DepartureTime = departure;
        }
    }
}
