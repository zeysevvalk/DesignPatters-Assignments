using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class FancyMP3Display : IObserver
    {
        public FancyMP3Display(IObservable player)
        {
            player.AddObserver(this);
        }

        public void Update(Song song)
        {
            Console.WriteLine($"Fancy Display ♪♫ Artist: {song.Artist} | Title: \"{song.Title}\" ♫♪");
        }
    }
}
