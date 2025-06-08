using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class MP3Player : IObservable
    {
        private List<IObserver> observers;
        private List<Song> songs;
        private Random random;

        public Song CurrentSong { get; private set; }

        public MP3Player()
        {
            observers = new List<IObserver>();
            random = new Random();
            songs = new List<Song>
        {
            new Song("Bohemian Rhapsody", "Queen"),
            new Song("Imagine", "John Lennon"),
            new Song("Billie Jean", "Michael Jackson"),
            new Song("Smells Like Teen Spirit", "Nirvana"),
            new Song("Shape of You", "Ed Sheeran")
        };
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NextSong()
        {
            CurrentSong = songs[random.Next(songs.Count)];
            Console.WriteLine($"\n[MP3Player] New song selected: {CurrentSong.Title} by {CurrentSong.Artist}");
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(CurrentSong);
            }
        }

    }
}
