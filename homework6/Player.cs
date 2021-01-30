using System;

namespace homework6
{
    public interface IPlayable
    {
        public void Play();
        public void Pause();
        public void Stop();
    }

    public interface IRecordable
    {
        public void Record();
        public void Pause();
        public void Stop();
    }

    public class Player : IPlayable, IRecordable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("playing started");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("playing paused");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("playing stopped");
        }

        void IRecordable.Record()
        {
            Console.WriteLine("recording started");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("recording paused");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("recording stopped");
        }
    }
}