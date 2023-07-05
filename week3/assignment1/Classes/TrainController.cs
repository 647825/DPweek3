using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class TrainController : ITrainController
    {
        private ITrainJourney trainJourney;

        public TrainController(ITrainJourney trainJourney)
        {
            this.trainJourney = trainJourney;
        }

        public void NextStation()
        {
            trainJourney.NextStation();
        }
    }
}
