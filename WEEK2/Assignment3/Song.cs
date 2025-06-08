using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Song
    {
        public string Title { get; }
        public string Artist { get; }

        public Song(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }

    }
}
