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
    public partial class TrainDisplay : Form, ITrainDisplay
    {
        private ITrainJourney trainJourney;
        public TrainDisplay(ITrainJourney trainJourney)
        {
            InitializeComponent();

            this.trainJourney = trainJourney;

            this.trainJourney.AddObserver(this);
        }

        public void Update(TrainStation trainStation)
        {
            lblStation.Text = trainStation.Name;
            lblTrack.Text = trainStation.Track;
        }

        private void TrainDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            trainJourney.RemoveObserver(this);
        }
    }
}
