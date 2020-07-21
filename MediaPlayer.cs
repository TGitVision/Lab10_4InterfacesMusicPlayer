using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_4InterfacesMusicPlayer
{
    // Step 2: Create a class for playing any kind of media. The media player will have a 
    //          method called PlayMedia, that accepts anything that uses the interface.
    class MediaPlayer
    {
        public void PlayMedia(IAudioPlayer media)
        {
            media.Play();
        }
    }
}
