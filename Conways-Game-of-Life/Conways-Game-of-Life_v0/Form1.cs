using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conways_Game_of_Life_v0
{
    public partial class Form1 : Form
    {
        public int n_rows;
        public int n_cols;
        public int n_gens;

        public Form1()
        {
            // Constructor Method
            InitializeComponent();
            hideSubMenus();
            n_rows = 10;
            n_cols = 10;
            n_gens = 1;
        }

        private void hideSubMenus()
        {
            // Hide All SubMenus upon start-up
            panelMenuSettings.Visible = false;
            panelSeedPresets.Visible = false;
            panelRandomSeed.Visible = false;
            panelSaveLoad.Visible = false;
        }

        private void OpenClose(Panel menu)
        {
            // Open or close specifiec panel
            if (menu.Visible == true)
                menu.Visible = false;
            else
                menu.Visible = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Open or Close the Setting menu
            OpenClose(panelMenuSettings);
        }

        private void btnSeedPresets_Click(object sender, EventArgs e)
        {
            // Open or Close the Seed Presets menu
            OpenClose(panelSeedPresets);
        }

        private void btnRandomSeed_Click(object sender, EventArgs e)
        {
            // Open or Close the Random Seed menu
            OpenClose(panelRandomSeed);
        }

        private void btnSaveLoad_Click(object sender, EventArgs e)
        {
            // Open or Close the Save/Load menu
            OpenClose(panelSaveLoad);
        }

        private void btnSetRows_Click(object sender, EventArgs e)
        {
            // Get Number of Rows from numeric counter
            n_rows = Convert.ToInt32(numericNrows.Value);
        }

        private void btnSetCols_Click(object sender, EventArgs e)
        {
            // Get Number of Columns from numeric counter
            n_cols = Convert.ToInt32(numericNcols.Value);
        }

        private void btnSetGens_Click(object sender, EventArgs e)
        {
            // Get Number of generations from numeric counter
            n_gens = Convert.ToInt32(numericNgens.Value);
        }

        
    }
}
