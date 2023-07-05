using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class TrainJourneyDisplay : Form, ITrainDisplay
    {
        private ITrainJourney trainJourney;
        public TrainJourneyDisplay(ITrainJourney trainJourney)
        {
            InitializeComponent();

            this.trainJourney = trainJourney;

            this.trainJourney.AddObserver(this);
        }

        public void Update(TrainStation trainStation)
        {
            List<TrainStation> stations = trainJourney.Stations;
            lstBoxStations.Items.Clear();
            for (int i = stations.IndexOf(trainStation); i < stations.Count; i++)
            {
                lstBoxStations.Items.Add(stations[i].Name);
            }
        }

        private void TrainJourneyDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            trainJourney.RemoveObserver(this);
        }
    }
}
