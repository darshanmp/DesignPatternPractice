using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Structural
{
    //Playing music in MP3, mp4 ,windows media format. we need the mp3 format music to also be played in other 2 formats hence we    
    interface IMediaPlayer
    {
        void play(string audioFormat, string songName);
    }
    class AudioPlayer : IMediaPlayer
    {
        MediaAdapter adapter = null;
        public void play(string audioFormat, string songName)
        {
            if (audioFormat == "mp3")
            {
                Console.WriteLine("MP3 song being payed " + songName);
            }
            else if (audioFormat == "wm" || audioFormat == "mp4")
            {
                adapter = new MediaAdapter();
                adapter.Play(audioFormat, songName);
            }
            else
            {
                Console.WriteLine("Invalid format");
            }
        }
    }
    interface IAdvancedMediaPlayer
    {
        void playMP4(string songName);
        void playWM(string songName);
    }
    class MP4MediaPlayer : IAdvancedMediaPlayer
    {
        public void playMP4(string songName)
        {
            Console.WriteLine("Playing MP4" + songName);
        }

        public void playWM(string songName)
        {
            Console.WriteLine();
        }
    }
    class WindowsAudioMediaPlayer : IAdvancedMediaPlayer
    {
        public void playMP4(string songName)
        {
            Console.WriteLine( );
        }

        public void playWM(string songName)
        {
            Console.WriteLine("Playing windows audio song" + songName);
        }
    }
    class MediaAdapter
    {
        IAdvancedMediaPlayer amedia;
        public void Play(string audioFormat, string songName)
        {
            if(audioFormat == "mp4")
            {
                amedia = new MP4MediaPlayer();
                amedia.playMP4(songName);
            }
            else if(audioFormat == "wm")
            {
                amedia = new WindowsAudioMediaPlayer();
                amedia.playWM(songName);
            }
        }
    }

    class AdapterDP
    {
        //public static void Main()
        //{
        //    AudioPlayer ap = new AudioPlayer();
        //    ap.play("mp3", "Metallica mp3");
        //    ap.play("mp4", "Metallica mp4");
        //    ap.play("wm", "Metallica wm");
        //    ap.play("vlc", "Metallica vlc");
        //}
    }
}
