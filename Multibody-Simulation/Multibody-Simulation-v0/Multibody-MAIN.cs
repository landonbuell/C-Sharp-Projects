/*
 * Landon Buell
 * Multibody Simulation
 * Main Script
 * 16 July 2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Units are Non-SI
 * G = 4.3009 e-3 (parsecs/solar mass)(km/s)^2
 */

namespace Multibody_Simulation_v0
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // System Pre-Processing
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create Multibody System Object
            Multibody_System currentSystem = new Multibody_System("Stellata");
            FormMain mainForm = new FormMain(currentSystem);
            Application.Run(mainForm);

            

        }
    }
}
