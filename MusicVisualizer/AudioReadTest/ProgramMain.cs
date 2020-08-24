using System;
using System.Media;

namespace AudioReadTest
{
    class ProgramMain
    {
        static void Main()
        {
            string path = @"C:\Users\Landon\Music\CantinaBand60.wav";

            SoundPlayer player = new SoundPlayer(path);
            player.PlaySync();
        }
    }
}
