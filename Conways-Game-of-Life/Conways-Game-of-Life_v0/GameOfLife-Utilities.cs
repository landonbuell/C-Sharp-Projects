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
        public int livingCells;
        public int currentGen;
        public List<int> cellCountHistory;
        public bool[,] grid;

        public GameBoard (int rows,int cols,int gens)
        {
            // Constructor for Game Board Object
            n_rows = rows;
            n_cols = cols;
            n_gens = gens;

            currentGen = 0;
        }

        public void runGame()
        {
            // Run the game
        }

       

    }

    public class Cell
    {
        public bool alive;
        public int x;
        public int y;

        public Cell(bool live,int xloc,int yloc)
        {
            // Constructor for cell object
            alive = live;
            x = xloc;
            y = yloc;
        }

        public int liveNeigbors(GameBoard gameboard)
        {
            // Check surrounding cells for life
            int life_cntr = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (i == j)
                        continue;
                    // This Cell = gameboard.rid[x, y];
                    if (gameboard.grid[x + i, y + j] == true)
                        life_cntr++;
                }
            }
            return life_cntr;
        }
    }
}
