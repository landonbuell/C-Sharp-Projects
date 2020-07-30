/*
 * Landon Buell
 * Multibody Simulation
 * Utilities
 * 16 July 2020
 */

using System;
using System.Collections.Generic;
using System.Drawing;
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

    class HelpMsgs
    {
        // Class to Hold Data for Help Messeges

        public static void GeneralHelp(string _hdr, string _txt, string _ftr)
        {
            // General Help Form Messege
            var helpForm = new FormHelp(_hdr,_txt,_ftr);
            helpForm.Show();
        }

        public static void TextBoxEntryHelp (string _hdr, string _type )
        {
            // Help messege for Adding Attributes to new Body object
            string hdr = "Help for " + _hdr.ToUpper() + " attribute";
            string txt = "Enter a value for the " + _hdr.ToLower();
            txt += " attribute for a new body object to add the system.\n";
            txt += "Data should be of type: " + _type;
            string ftr = "Press 'Add Body to System' button \nwhen all parameters are entered";
            var helpForm = new FormHelp(hdr, txt, ftr);
            helpForm.Show();
        }
    }
}
