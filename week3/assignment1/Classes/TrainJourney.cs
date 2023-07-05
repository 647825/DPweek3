using System;
using System.Collections.Generic;

namespace assignment1
{
    public class TrainJourney : ITrainJourney
    {
        private List<ITrainDisplay> _displays;
        private int _stationCount;
        private List<TrainStation> stations;

        public List<TrainStation> Stations { get => stations; }
        public TrainStation CurrentStation { get => Stations[StationCount]; }
        public int StationCount { get => _stationCount; }

        public void NextStation()
        {
            _stationCount++;

            if (StationCount >= Stations.Count)
            {
                _stationCount = 1;
                Stations.Reverse();
            }

            UpdateDisplays();
        }

        private void UpdateDisplays()
        {
            foreach (ITrainDisplay display in _displays)
                display.Update(CurrentStation);
        }

        public void AddObserver(ITrainDisplay trainDisplay)
        {
            _displays.Add(trainDisplay);
            trainDisplay.Update(CurrentStation);
        }
        public void RemoveObserver(ITrainDisplay trainDisplay)
        {
            _displays.Remove(trainDisplay);
        }

        public TrainJourney()
        {
            _displays = new List<ITrainDisplay>();
            stations = new List<TrainStation>() {
                new TrainStation("Den Helder", "3", new TimeSpan(11, 34, 00), new TimeSpan(11, 26, 00)),
                new TrainStation("Den Helder Zuid", "1", new TimeSpan(11, 38, 00), new TimeSpan(11, 38, 00)),
                new TrainStation("Anna Paulowna", "1", new TimeSpan(11, 44, 00), new TimeSpan(11, 45, 00)),
                new TrainStation("Schagen", "1", new TimeSpan(11, 52, 00), new TimeSpan(11, 52, 00)),
                new TrainStation("Heerhugowaard", "1", new TimeSpan(12, 01, 00), new TimeSpan(12, 01, 00)),
                new TrainStation("Alkmaar Noord", "1", new TimeSpan(12, 07, 00), new TimeSpan(12, 07, 00)),
                new TrainStation("Alkmaar", "5", new TimeSpan(12, 11, 00), new TimeSpan(12, 14, 00)),
                new TrainStation("Heiloo", "2", new TimeSpan(12, 19, 00), new TimeSpan(12, 19, 00)),
                new TrainStation("Castricum", "2", new TimeSpan(12, 25, 00), new TimeSpan(12, 25, 00)),
                new TrainStation("Zaandam", "4", new TimeSpan(12, 38, 00), new TimeSpan(12, 38, 00)),
                new TrainStation("Amsterdam Sloterdijk", "5", new TimeSpan(12, 45, 00), new TimeSpan(12, 45, 00)),
                new TrainStation("Amsterdam Centraal", "4b", new TimeSpan(12, 51, 00), new TimeSpan(12, 54, 00)),
                new TrainStation("Amsterdam Amstel", "4", new TimeSpan(13, 02, 00), new TimeSpan(13, 03, 00)),
                new TrainStation("Utrecht Centraal", "19", new TimeSpan(13, 21, 00), new TimeSpan(13, 23, 00)),
                new TrainStation("Driebergen-Zeist", "2", new TimeSpan(13, 31, 00), new TimeSpan(13, 31, 00)),
                new TrainStation("Ede-Wageningen", "4", new TimeSpan(13, 47, 00), new TimeSpan(13, 49, 00)),
                new TrainStation("Arnhem Centraal", "8", new TimeSpan(13, 59, 00), new TimeSpan(14, 05, 00)),
                new TrainStation("Nijmegen", "3", new TimeSpan(14, 17, 00), new TimeSpan(14, 43, 00)),
            };
        }
    }
}
