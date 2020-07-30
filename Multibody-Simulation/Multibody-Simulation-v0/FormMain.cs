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
        
        // Init MultiBody System Object Variable
        public Multibody_System MultibodySystem;

        public FormMain(Multibody_System _system)
        {
            // Constructor for Main Form Object
            InitializeComponent();
            InitSubMenus();
            MultibodySystem = _system;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void RefreshSystemDetails()
        {
            // Gather System Details Attrb and Display in Menu
            var data = MultibodySystem.__getSystemDetails__();
        }

        private void InitSubMenus()
        {
            // Close All Submenu Objects
            panelMenuSystemDetails.Visible = false;
            panelMenuUnitSystems.Visible = false;
            panelMenuSaveLoad.Visible = false;
            panelMenuAddBody.Visible = false;

        }

        private void CloseSubMenus()
        {
            // Close all open submenu objects
            if (panelMenuSystemDetails.Visible == true)
                panelMenuSystemDetails.Visible = false;
            if (panelMenuUnitSystems.Visible == true)
                panelMenuUnitSystems.Visible = false;
            if (panelMenuSaveLoad.Visible == true)
                panelMenuSaveLoad.Visible = false;
            if (panelMenuAddBody.Visible == true)
                panelMenuAddBody.Visible = false;
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
            ShowSubMenu(panelMenuSystemDetails);
        }

        private void btnUnitSystems_Click(object sender, EventArgs e)
        {
            // Show Unit Systems Submenu
            ShowSubMenu(panelMenuUnitSystems);
        }

        private void btnSaveLoad_Click(object sender, EventArgs e)
        {
            // Show Save/Load Submenu
            ShowSubMenu(panelMenuSaveLoad);
        }

        private void btnShowAdd_Click(object sender, EventArgs e)
        {
            // Show Add Body Submenu
            ShowSubMenu(panelMenuAddBody);
        }

        private void btnAddBodyObj_Click(object sender, EventArgs e)
        {
            // Add Body to System list
            AddBody();
            // Update System Details
        }

        private void AddBody()
        {
            // Parse Form and Add Body to System
            double[] _pos = new double[3];
            double[] _vel = new double[3];
            try
            {
                // Attempt to Parse basic params
                string _name = Convert.ToString(txtAddName.Text);
                double _mass = Convert.ToDouble(txtAddMass.Text);
                double _radius = Convert.ToDouble(txtAddRadius.Text);
                // Attempt to Parse Position Arguments
                _pos[0] = Convert.ToDouble(txtAddPosX.Text);
                _pos[1] = Convert.ToDouble(txtAddPosY.Text);
                _pos[2] = Convert.ToDouble(txtAddPosZ.Text);
                // Attempt to Parse Velocity Arguments
                _vel[0] = Convert.ToDouble(txtAddVelX.Text);
                _vel[1] = Convert.ToDouble(txtAddVelY.Text);
                _vel[2] = Convert.ToDouble(txtAddVelZ.Text);
                // Create New Body Object From Data & Add to System
                Body newBody = new Body(_name, _mass, _radius, _pos, _vel);
                MultibodySystem.AddBody(newBody);
            }
            catch
            {
                FormError warningForm = new FormError();
                warningForm.Show();
            }
        }

        // HELP MENU BUTTONS
        private void btnHelpName_Click(object sender, EventArgs e)
        {
            // Display Help Window for Name attribute      
            HelpMsgs.TextBoxEntryHelp(btnHelpName.Text, "string");
        }

        private void btnHelpMass_Click(object sender, EventArgs e)
        {
            // Display Help Window for Mass attribute        
            HelpMsgs.TextBoxEntryHelp(btnHelpMass.Text, "double");
        }

        private void btnHelpRadius_Click(object sender, EventArgs e)
        {
            // Display Help Window for Radius attribute           
            HelpMsgs.TextBoxEntryHelp(btnHelpRadius.Text, "double");
        }

        private void btnHelpPosX_Click(object sender, EventArgs e)
        {
            // Display Help Windows for X-position attribute
            HelpMsgs.TextBoxEntryHelp(btnHelpPosX.Text, "double");
        }

        private void btnHelpPosY_Click(object sender, EventArgs e)
        {
            // Display Help Windows for Y-position attribute
            HelpMsgs.TextBoxEntryHelp(btnHelpPosY.Text, "double");
        }

        private void btnHelpPosZ_Click(object sender, EventArgs e)
        {
            // Display Help Windows for Z-position attribute
            HelpMsgs.TextBoxEntryHelp(btnHelpPosZ.Text, "double");
        }

        private void btnHelpVelX_Click(object sender, EventArgs e)
        {
            // Display Help Windows for X-velocity attribute
            HelpMsgs.TextBoxEntryHelp(btnHelpVelX.Text, "double");
        }

        private void btnHelpVelY_Click(object sender, EventArgs e)
        {
            // Display Help Windows for Y-velocity attribute
            HelpMsgs.TextBoxEntryHelp(btnHelpVelY.Text, "double");
        }

        private void btnHelpVelZ_Click(object sender, EventArgs e)
        {
            // Display Help Windows for Z-velocity attribute
            HelpMsgs.TextBoxEntryHelp(btnHelpVelZ.Text, "double");
        }
    } 
}
