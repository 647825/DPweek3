using System.Collections.Generic;

namespace assignment1
{
    public interface ITrainJourney
    {
        void NextStation();
        public List<TrainStation> Stations { get; }
        TrainStation CurrentStation { get; }
        int StationCount { get; }

        void AddObserver(ITrainDisplay trainDisplay);
        void RemoveObserver(ITrainDisplay trainDisplay);
    }
}
