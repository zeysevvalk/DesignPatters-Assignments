using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.MODEL
{
    internal class TrainJourney : ITrainJourney
    {
        private List<ITrainDisplay> observers = new();
        private List<TrainStation> stations;
        private int currentIndex = 0;

        public TrainJourney()
        {
            stations = new List<TrainStation>
        {
            new TrainStation("Den Helder", "1", "08:00", "08:05"),
            new TrainStation("Alkmaar", "3", "08:30", "08:32"),
            new TrainStation("Amsterdam", "7", "09:00", "09:05"),
            new TrainStation("Utrecht", "2", "09:45", "09:50"),
            new TrainStation("Nijmegen", "4", "10:30", "10:35")
        };
        }

        public void NextStation()
        {
            if (currentIndex < stations.Count - 1)
            {
                currentIndex++;
                NotifyObservers();
            }
        }

        public void ReverseJourney()
        {
            stations.Reverse();
            currentIndex = 0;
            NotifyObservers();
        }

        public TrainStation GetCurrentStation() => stations[currentIndex];

        public void AddObserver(ITrainDisplay observer)
        {
            observers.Add(observer);
            observer.Update(GetCurrentStation());
        }

        public void RemoveObserver(ITrainDisplay observer) => observers.Remove(observer);

        private void NotifyObservers()
        {
            foreach (var observer in observers)
                observer.Update(GetCurrentStation());
        }

    }
}
