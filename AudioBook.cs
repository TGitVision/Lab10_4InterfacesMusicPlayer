using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_4InterfacesMusicPlayer
{

    // Step 5: Creating an AudioBook class and implement the IAudioPlayer interface.
    //          The beauty of interfaces is that these classes can be very different, 
    //          so long as they use the interface. Our Audiobook has a bookTitle and Author.
    //          Its version of Play() simply prints out the book title and author info.
    class AudioBook : IAudioPlayer
    {

        #region Fields and Properties

        public string bookTitle { get; }
        public string author { get; }

        #endregion
        
        public AudioBook(string bookTitle, string author) 
        {
            this.bookTitle = bookTitle;
            this.author = author;
        }        
        
        // Iterface Method Implementation 
        public void Play()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("Now Playing: ");
            sb.Append(bookTitle);
            sb.Append(" by: ");
            sb.Append(author);
            Console.WriteLine(sb.ToString());

        }


    }
}
