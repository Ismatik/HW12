using System;

namespace HW12
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Play(player, "\"I got Love.\"");


            Record(player, "podcast.");
        }

        static void Play(IPlayable player, in string songTitle) {
            player.Play();
            System.Console.WriteLine(" " + songTitle);

            player.PausePlaying();
            System.Console.WriteLine(" " + songTitle);

            player.StopPlaying();
            System.Console.WriteLine(" " + songTitle);
        }

        static void Record(IRecordable recorder, in string soundTitle) {
            recorder.Record();
            System.Console.WriteLine(" " + soundTitle);

            recorder.PauseRecording();
            System.Console.WriteLine(" " + soundTitle);

            recorder.StopRecording();
            System.Console.WriteLine(" " + soundTitle);
        }
    }


    interface IPlayable {
        void Play();
        void PausePlaying();
        void StopPlaying();
    }

    interface IRecordable {
        void Record();
        void PauseRecording();
        void StopRecording(); 
    }

    class Player : IPlayable, IRecordable {
        public void Play() {
            System.Console.Write("Playing music");
        }
        public void PausePlaying() {
            System.Console.Write("Paused playing music");
        }

        public void StopPlaying() {
            System.Console.Write("Stoped playing music");
        }
        
        public void Record() {
            System.Console.Write("Recording sound");
        }
        public void PauseRecording() {
            System.Console.Write("Paused recording sound");
        }
        public void StopRecording() {
            System.Console.Write("Stoped recording sound");
        }
    }
}
