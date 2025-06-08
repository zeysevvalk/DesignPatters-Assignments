using Assignment1.CONTROLLERS;
using Assignment1.MODEL;

namespace Assignment1
{
    public partial class Form1 : Form
    {

        private ITrainJourney journey;
        private ITrainController controller;
        public Form1()
        {
            InitializeComponent();

            journey = new TrainJourney();
            controller = new TrainController(journey);

            // 2 farkl? display aç
            var display1 = new TrainDisplayForm(journey) { Text = "Display 1" };
            display1.Show();

            var display2 = new TrainDisplayForm(journey) { Text = "Display 2" };
            display2.Show();


        }

        private void btnNextStation_Click(object sender, EventArgs e)
        {
            controller.GoToNextStation();
        }

        private void btnReverseJourney_Click(object sender, EventArgs e)
        {
            controller.ReverseTrain();
        }
    }
}
