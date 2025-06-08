using Assignment1.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class TrainDisplayForm : Form, ITrainDisplay
    {

        public TrainDisplayForm(ITrainJourney journey)
        {
            InitializeComponent();
            journey.AddObserver(this);
        }

        public void Update(TrainStation station)
        {
            lblStation.Text = $"Next station: {station.Name}";
            lblTrack.Text = $"Track: {station.ArrivalTrack}";
            lblTime.Text = $"Arrival: {station.ArrivalTime}";
        }
    }
}
