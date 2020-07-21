using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_4InterfacesMusicPlayer
{
    // Step 3: Create a Music Artist class, and implement the IAudioPlayer interface.

    //          We’ve created an Artist class that uses our interface. We have two properties, an artist name 
    //          and a playlist.  We are using a new data type here called Dictionary, which holds an integer 
    //          and a string value together.
    //
    //          We’ve created a constructor for giving the artist a name and building a new, empty playlist.
    //
    //          We’ve created a method called AddToPlaylist, which takes in the title of a song, 
    //          and adds it to our playlist dictionary. The song ID is automatically added.
    // 
    //          Finally, we implement Play(), which generates a random number between 0 and 
    //          the number of items in our playlist.  It then writes out the console the artist’s 
    //          name and the random song picked from the playlist.

    class Artist : IAudioPlayer
    {
        #region Fields and Properties

        public Dictionary<int, string> playlist;
        public string artistName { get; }        

        #endregion


        #region Constructors
        public Artist(string artistName)
        {

            this.artistName = artistName;
            playlist = new Dictionary<int, string>();

        }
        #endregion

        #region Methods

        public void AddToPlaylist(string songTitle) 
        {

            int id = playlist.Count;
            playlist.Add(id, songTitle);
            
        }

        // Interface Method Implementation
        public void Play()
        {

            Random random = new Random();
            int songId = random.Next(0, playlist.Count);
            StringBuilder sb = new StringBuilder();
            sb.Append("Now Playing Artist: ");
            sb.Append(artistName);
            sb.Append($" Song {songId}: ");  // {songId} added by th 07212020
            sb.Append(playlist[songId]);
            Console.WriteLine(sb.ToString());

        }
        #endregion

    }
}
