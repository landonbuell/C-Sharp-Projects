using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multibody_Simulation_v0
{
    public partial class FormMain : Form
    {

        public Multibody_System currentSystem;

        public FormMain(Multibody_System _system)
        {
            // Constructor for Main Form Object
            InitializeComponent();
            InitSubMenus();
            currentSystem = _system;

        }

        private List<Body> GetBodies()
        {
            // Get List of Bodies from currentSystem
            var bodies = currentSystem.__getBodies__();
            return bodies;
        }

        private void InitSubMenus()
        {
            // Close All Submenu Objects
            panelSystemDetails.Visible = false;
            panelUnitSystems.Visible = false;
        }

        private void CloseSubMenus()
        {
            // Close all open submenu objects
            if (panelSystemDetails.Visible == true)
                panelSystemDetails.Visible = false;
            if (panelUnitSystems.Visible == true)
                panelUnitSystems.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            // Show Submenu Action, called if clicked
            if (subMenu.Visible == false)
                subMenu.Visible = true;
            else
                subMenu.Visible = false;
        }

        private void btnSystemDetails_Click(object sender, EventArgs e)
        {
            // Show System Details Submenu
            ShowSubMenu(panelSystemDetails);
        }

        private void btnUnitSystems_Click(object sender, EventArgs e)
        {
            // Show Unit Systems Submenu
            ShowSubMenu(panelUnitSystems);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAddToSystem_Click(object sender, EventArgs e)
        {
            // Add Body Object to System
            string _name = Convert.ToString(textAddName.Text);
            double _mass = Convert.ToDouble(textAddMass.Text);
            double _radius = Convert.ToDouble(textAddRadius.Text);
            
        }

    }
}
