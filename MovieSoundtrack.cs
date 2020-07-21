using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_4InterfacesMusicPlayer
{

    // Step 6: Create a Movie Soundtrack and implement the IAudioPlayer interface.

    class MovieSoundtrack : IAudioPlayer
    {

        #region Fields and Properties

        public string movieName { get; }
        public string trackName { get; private set; }

        #endregion

        #region Constructors

        public MovieSoundtrack(string movieName)
        {
            this.movieName = movieName;
        }

        #endregion

        #region Methods

        public void SelectTrack(string movieName)
        {
            this.trackName = movieName;
        }

        // Interface Method Implementation
        public void Play()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append("Now Playing: ");
            sb.Append(movieName);
            sb.Append(" Track Title: ");
            sb.Append(trackName);
            Console.WriteLine(sb.ToString());

        }

        #endregion

    }
}
