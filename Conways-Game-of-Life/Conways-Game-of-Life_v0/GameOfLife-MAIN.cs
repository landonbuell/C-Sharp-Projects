﻿/*
 * Landon Buell
 * Conways' Game of Life
 * Main Executable
 * 22 July 2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conways_Game_of_Life_v0
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 MainForm = new Form1();
            Application.Run(MainForm);


            

            
        }
    }
}
