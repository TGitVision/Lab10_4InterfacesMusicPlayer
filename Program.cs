using System;

namespace Lab10_4InterfacesMusicPlayer
{
    class Program
    {
        #region Program Steps

        // Step 1: IAudioPlayer: Create an interface for playing audio media. We'll create a new interface that has 
        //          one method Play().

        // Step 2: MediaPlayer: Create a class for playing any kind of media. The media player will have a 
        //          method called PlayMedia, that accepts anything that uses the interface.

        // Step 3: Artist: Create a Music Artist class and implement the IAudioPlayer interface.

        // Step 4: Program: Test that our media player and artist is working.
        //          Create a MediaPlayer and Artist.
        //          Create a Playlist for the Artist and play a song. The song will be randomly picked.

        // Step 5: Creating an AudioBook class and implement the IAudioPlayer interface.
        //          The beauty of interfaces is that these classes can be very different, 
        //          so long as they use the interface. Our Audiobook has a bookTitle and Author.
        //          Its version of Play() simply prints out the book title and author info.

        // Step 6: Create a Movie Soundtrack and implement the IAudioPlayer interface.

        // Step 7: Test the other kinds of media.

        #endregion Region

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World from Lab10_4InterfacesMusicPlayer!");

            Artist prince = new Artist("Prince");
            prince.AddToPlaylist("Purple Rain");
            prince.AddToPlaylist("Little Red Corvette");
            prince.AddToPlaylist("Kiss");
            prince.AddToPlaylist("When Doves Cry");

            MediaPlayer player = new MediaPlayer();
            player.PlayMedia(prince);

            AudioBook howto = new AudioBook("How to Win Friends & Influence People", "Dale Carnegie");
            player.PlayMedia(howto);

            MovieSoundtrack starWars = new MovieSoundtrack("Star Wars");
            starWars.SelectTrack("Opening Credits Theme");
            player.PlayMedia(starWars);

        }



    }
}
