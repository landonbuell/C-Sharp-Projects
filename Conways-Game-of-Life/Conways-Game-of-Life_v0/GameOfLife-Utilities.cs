/*
 * Landon Buell
 * Conways' Game of Life
 * Main Executable
 * 22 July 2020
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conways_Game_of_Life_v0
{
    public class GameBoard
    {
        public int n_rows;
        public int n_cols;
        public int n_gens;
        public bool[,] board;

        public GameBoard (int rows,int cols,int gens,)
        {
            // Constructor for Game Board Object
        }

        public void runGame()
        {
            // Run the game
        }


    }

    public class Cell
    {
        public bool alive;
        public int xloc;
        public int yloc;
        public int n_neighbors;

        public Cell(bool live,int x,int y)
        {
            // Constructor for cell object
            alive = live;
            xloc = x;
            yloc = y;
        }

        public int getLivingNeigbors(GameBoard board)
        {
            // Check surrounding cells for life
            int life_cntr = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2, j++)
                {
                    if (i == j)
                        continue;
                    
                    
                }
            }
            return life_cntr;
        }
    }
}
