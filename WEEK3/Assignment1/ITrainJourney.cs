using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.MODEL;

namespace Assignment1
{
    public interface ITrainJourney
    {
        void NextStation();
        void ReverseJourney();
        void AddObserver(ITrainDisplay observer);
        void RemoveObserver(ITrainDisplay observer);
        TrainStation GetCurrentStation();
    }
}
