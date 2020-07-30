/*
 * Landon Buell
 * Multibody Simulation
 * Utilities
 * 16 July 2020
 */

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multibody_Simulation_v0
{
    static class Constants
    {
        // Initialize G in different Unit systems
        public const double G_siUnits = 6.673e-11;
        public const double G_naturalUnits = 1e0;
        public const double G_astroUnits = 4.3009e-3;
        public const double G_solarUnits = 1.90809e5;
    }

    class ErrorMsgs
    {
        // Class To hold error Messages

        public static string GeneralError()
        {
            return "You have Encoutered a General Error!";
        }
    }
}
