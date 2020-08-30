using System;
using System.Media;
using System.Threading;

namespace AudioReadTest
{
    class ProgramMain
    {
        static void Main()
        {
            string path = @"C:\Users\Landon\Music\CantinaBand60.wav";

            SoundPlayer player1 = new SoundPlayer(path);
            player1.Play();

            Thread.Sleep(10000);

            SoundPlayer player2 = new SoundPlayer(path);
            player2.Play();

            Thread.Sleep(10000);

            

            Console.WriteLine("=)");
        }
    }
}
