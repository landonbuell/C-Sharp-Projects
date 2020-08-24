/*
 * Landon Buell 
 * Audio Reader
 * Reader utils
 * 23 August 2020
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
using System.IO;

namespace AudioReaderTest
{
    class WavFile
    {
        private string filename;
        private byte[] L;
        private byte[] R;
        private byte[] X;
        private int sampleRate;

        public WavFile (string fname)
        {
            // Constructor for WaveFile Class Instance
            this.X = File.ReadAllBytes(fname);
        }

    }
}
