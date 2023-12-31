﻿using System;
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
    public partial class Form1 : Form
    {
        private ITrainController trainController;
        private ITrainJourney trainJourney;

        public Form1()
        {
            InitializeComponent();

            trainJourney = new TrainJourney();
            trainController = new TrainController(trainJourney);
        }

        private void btnNewDisplay_Click(object sender, EventArgs e)
        {
            TrainDisplay trainDisplay = new TrainDisplay(trainJourney);
            trainDisplay.Show();
        }

        private void btnNextStation_Click(object sender, EventArgs e)
        {
            trainController.NextStation();
        }

        private void btnNewJDisplay_Click(object sender, EventArgs e)
        {
            TrainJourneyDisplay journeyDisplay = new TrainJourneyDisplay(trainJourney);
            journeyDisplay.Show();
        }
    }
}
