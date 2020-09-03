/*
 * Landon Buell
 * Pandemic Modeling
 * Individals Objects
 * 1 September 2020
 */

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace PandemicModel
{
    public class BaseCarrier
    {
        // Class represents a Vector - a disease carrying organism: can be S/I/R
        // Suceptible = 0
        // Infected = 1
        // Recovered = 2

        public BaseCarrier(string id)
        {
            // Constructor Method for Individual Object
            Condition = 0;
            ID = id;
        }

        /// <summary>
        /// Get or Set Current Condition Statu S/I/R
        /// </summary>
        public int Condition { get; set; }

        /// <summary>
        /// Get or Set ID value for particular vector
        /// </summary>
        public string ID { get; set; }
        
    }
}
