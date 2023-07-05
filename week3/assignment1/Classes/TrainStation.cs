using System;

namespace assignment1
{
    public class TrainStation
    {
        public string Name { get; set; }
        public string Track { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public TimeSpan DepartureTime { get; set; }

        public TrainStation(string name, string track, TimeSpan arrivalTime, TimeSpan departureTime)
        {
            Name = name;
            Track = track;
            ArrivalTime = arrivalTime;
            DepartureTime = departureTime;
        }
    }
}
