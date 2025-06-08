using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.CONTROLLERS
{
    internal class TrainController : ITrainController
    {
        private readonly ITrainJourney journey;

        public TrainController(ITrainJourney journey)
        {
            this.journey = journey;
        }

        public void GoToNextStation() => journey.NextStation();

        public void ReverseTrain() => journey.ReverseJourney();
    }
}
