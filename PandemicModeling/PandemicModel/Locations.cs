/*
 * Landon Buell
 * Pandemic Modeling
 * Location Based Objects
 * 1 September 2020
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace PandemicModel
{

    public class WorldBoard
    {
        // World Board Instance Holds all People, Locations, etc.

        public string name;

        private List<BaseVector> vectors;
        private List<Location> locations;

        public int totalVectors;
        public int totalLocations;

        public WorldBoard(string name)
        {
            // Constructor Method for World Board
            this.name = name;

            this.vectors = new List<BaseVector>();
            this.locations = new List<Location>();

            this.totalVectors = 0;
            this.totalLocations = 0;
        }

        public void AddLocation (Location newLocation)
        {
            // Add New Location to World
            locations.Add(newLocation);
            totalLocations += 1;
        }

        public void AddVector (BaseVector newVector)
        {
            // Add new Vector to World
            vectors.Add(newVector);
            totalVectors += 1;
        }

        public void AddnVectors (int nVectors)
        {
            // Add A integer number of vectors into the World
            for (int i = 0; i < nVectors; i++)
            {
                AddVector(new BaseVector(Convert.ToString(totalVectors)));
            }   
        }

        public List<Location> WorldLocations
        {
            // Get or Set Method of Locations in the world
            get { return locations; }
            set { locations = value; }
        }

        public List<BaseVector> WorldVectors
        {
            // Get or Set Method of all vecotors in the world
            get { return vectors; }
            set { vectors = value; }
        }
    }

    public class Location
    {
        // Parent Location Class
        public string name;
        public string locationType;

        private List<BaseVector> vectors;

        public int totalVectors;
        public int totalLocations;

        public int height, width;
        public int xpos, ypos;


        public Location(string name, int[] position, int[] size)
        {
            // Constructor Method for Location Parent Object
            this.name = name;
            this.locationType = "Generic";

            this.vectors = new List<BaseVector>();

            // Set Size of Location Object
            this.width = size[0];
            this.height = size[1];

            // Set position of Location Object
            this.xpos = position[0];
            this.ypos = position[1];
            
        }

        public List<BaseVector> LocationVectors
        {
            // Get or Set Method of all vecotors in the world
            get { return vectors; }
            set { vectors = value; }
        }

    }
}
