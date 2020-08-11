/*
 * Landon Buell
 * Engima Machine v1
 * Rotors
 * 11 August 2020
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Engima_Machine_v1
{

    namespace Rotors
    {

        public class Conversions
        {
            // Class to Convert Letters to Ints & ints to Letter

            public static List<string> letters = new List<string> 
                { "A", "B", "C", "D", "E", "F",
                    "G", "H", "I", "J", "K", "L",
                    "M", "N", "O", "P", "Q", "R",
                    "S", "T", "U", "V", "W", "X", "Y" , "Z"};

            public static Dictionary<string,int> LetterToNumber()
            {
                // Convert Letter Entry to Integer Entry
                Dictionary<string, int> letterToNum = new Dictionary<string, int>();
                for (int i = 0; i < 27 ; i++)
                    letterToNum.Add(letters[i], i + 1);
                return letterToNum;
            }

            public static Dictionary<int,string> NumberToLetter()
            {
                // Convert Integer Entry to Letter Entry
                Dictionary<int, string> numToLetter = new Dictionary<int, string>();
                for (int i = 0; i < 27; i++)
                    numToLetter.Add(i + 1, letters[i]);
                return numToLetter;

            }
        }


        class Rotor
        {
            protected int rotorNum;

            protected Dictionary<int,int> Map
            {
                // Get or Ser Rotor Mapping Scheme
                get; set;
            }

            protected Dictionary<int, int> ReverseMap()
            {
                // Reverse Forward Pass Dictionary
                Dictionary<int, int> rotorMap = Map;
                Dictionary<int, int> reverseMap = new Dictionary<int, int>();
                foreach (var pair in rotorMap)
                {
                    int key = pair.Key, val = pair.Value;
                    reverseMap.Add(val, key);
                }
                return reverseMap;
            }



        }

        class Rotor_1 : Rotor
        {
            private Rotor_1()
            {
                // Constructor for Rotor 1
                this.rotorNum = 1;
                
            }
        }

        


    }
}
