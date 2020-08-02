namespace Multibody_Simulation_v0
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenuMain = new System.Windows.Forms.Panel();
            this.panelMenuSaveLoad = new System.Windows.Forms.Panel();
            this.btnLoadSystem = new System.Windows.Forms.Button();
            this.btnSaveSystem = new System.Windows.Forms.Button();
            this.btnSaveLoad = new System.Windows.Forms.Button();
            this.panelMenuUnitSystems = new System.Windows.Forms.Panel();
            this.radioSolarUnits = new System.Windows.Forms.RadioButton();
            this.radioAstroUnits = new System.Windows.Forms.RadioButton();
            this.radioNaturalUnits = new System.Windows.Forms.RadioButton();
            this.radioSiUnits = new System.Windows.Forms.RadioButton();
            this.btnUnitSystems = new System.Windows.Forms.Button();
            this.panelMenuSystemDetails = new System.Windows.Forms.Panel();
            this.splitMenuSystemDetails = new System.Windows.Forms.SplitContainer();
            this.btnHelpNetVelZ = new System.Windows.Forms.Button();
            this.btnHelpNetVelY = new System.Windows.Forms.Button();
            this.btnHelpNetVelX = new System.Windows.Forms.Button();
            this.btnHelpCmZ = new System.Windows.Forms.Button();
            this.btnHelpCmY = new System.Windows.Forms.Button();
            this.btnHelpCmX = new System.Windows.Forms.Button();
            this.btnHelpAvgMass = new System.Windows.Forms.Button();
            this.btnHelpTotalMass = new System.Windows.Forms.Button();
            this.labelNetVelZ = new System.Windows.Forms.Label();
            this.labelNetVelY = new System.Windows.Forms.Label();
            this.labelNetVelX = new System.Windows.Forms.Label();
            this.labelCmZ = new System.Windows.Forms.Label();
            this.labelCmY = new System.Windows.Forms.Label();
            this.labelCmX = new System.Windows.Forms.Label();
            this.labelAvgMass = new System.Windows.Forms.Label();
            this.labelTotalMass = new System.Windows.Forms.Label();
            this.btnSystemDetails = new System.Windows.Forms.Button();
            this.panelMainLogo = new System.Windows.Forms.Panel();
            this.panelMenuRight = new System.Windows.Forms.Panel();
            this.panelMenuAddBody = new System.Windows.Forms.Panel();
            this.btnAddBodyObj = new System.Windows.Forms.Button();
            this.splitMenuAddBody = new System.Windows.Forms.SplitContainer();
            this.btnHelpVelZ = new System.Windows.Forms.Button();
            this.btnHelpVelY = new System.Windows.Forms.Button();
            this.btnHelpVelX = new System.Windows.Forms.Button();
            this.btnHelpPosZ = new System.Windows.Forms.Button();
            this.btnHelpPosY = new System.Windows.Forms.Button();
            this.btnHelpPosX = new System.Windows.Forms.Button();
            this.btnHelpRadius = new System.Windows.Forms.Button();
            this.btnHelpMass = new System.Windows.Forms.Button();
            this.btnHelpName = new System.Windows.Forms.Button();
            this.btnAddAttrbHelp = new System.Windows.Forms.Button();
            this.txtAddVelZ = new System.Windows.Forms.TextBox();
            this.txtAddVelY = new System.Windows.Forms.TextBox();
            this.txtAddVelX = new System.Windows.Forms.TextBox();
            this.txtAddPosZ = new System.Windows.Forms.TextBox();
            this.txtAddPosY = new System.Windows.Forms.TextBox();
            this.txtAddPosX = new System.Windows.Forms.TextBox();
            this.txtAddRadius = new System.Windows.Forms.TextBox();
            this.txtAddMass = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.btnAddValueHelp = new System.Windows.Forms.Button();
            this.btnShowAdd = new System.Windows.Forms.Button();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.panelTopCenter = new System.Windows.Forms.Panel();
            this.panelMainViewer = new System.Windows.Forms.Panel();
            this.multibodySystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelBottomCenter = new System.Windows.Forms.Panel();
            this.panelMenuMain.SuspendLayout();
            this.panelMenuSaveLoad.SuspendLayout();
            this.panelMenuUnitSystems.SuspendLayout();
            this.panelMenuSystemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMenuSystemDetails)).BeginInit();
            this.splitMenuSystemDetails.Panel1.SuspendLayout();
            this.splitMenuSystemDetails.Panel2.SuspendLayout();
            this.splitMenuSystemDetails.SuspendLayout();
            this.panelMenuRight.SuspendLayout();
            this.panelMenuAddBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMenuAddBody)).BeginInit();
            this.splitMenuAddBody.Panel1.SuspendLayout();
            this.splitMenuAddBody.Panel2.SuspendLayout();
            this.splitMenuAddBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.multibodySystemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuMain
            // 
            this.panelMenuMain.AutoScroll = true;
            this.panelMenuMain.Controls.Add(this.panelMenuSaveLoad);
            this.panelMenuMain.Controls.Add(this.btnSaveLoad);
            this.panelMenuMain.Controls.Add(this.panelMenuUnitSystems);
            this.panelMenuMain.Controls.Add(this.btnUnitSystems);
            this.panelMenuMain.Controls.Add(this.panelMenuSystemDetails);
            this.panelMenuMain.Controls.Add(this.btnSystemDetails);
            this.panelMenuMain.Controls.Add(this.panelMainLogo);
            this.panelMenuMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuMain.Location = new System.Drawing.Point(0, 0);
            this.panelMenuMain.Name = "panelMenuMain";
            this.panelMenuMain.Size = new System.Drawing.Size(400, 1344);
            this.panelMenuMain.TabIndex = 0;
            // 
            // panelMenuSaveLoad
            // 
            this.panelMenuSaveLoad.Controls.Add(this.btnLoadSystem);
            this.panelMenuSaveLoad.Controls.Add(this.btnSaveSystem);
            this.panelMenuSaveLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuSaveLoad.Location = new System.Drawing.Point(0, 1080);
            this.panelMenuSaveLoad.Name = "panelMenuSaveLoad";
            this.panelMenuSaveLoad.Size = new System.Drawing.Size(374, 400);
            this.panelMenuSaveLoad.TabIndex = 6;
            // 
            // btnLoadSystem
            // 
            this.btnLoadSystem.BackColor = System.Drawing.Color.Gray;
            this.btnLoadSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoadSystem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoadSystem.FlatAppearance.BorderSize = 0;
            this.btnLoadSystem.ForeColor = System.Drawing.Color.Black;
            this.btnLoadSystem.Location = new System.Drawing.Point(0, 50);
            this.btnLoadSystem.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoadSystem.Name = "btnLoadSystem";
            this.btnLoadSystem.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnLoadSystem.Size = new System.Drawing.Size(374, 50);
            this.btnLoadSystem.TabIndex = 25;
            this.btnLoadSystem.Text = "Load System";
            this.btnLoadSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadSystem.UseVisualStyleBackColor = false;
            // 
            // btnSaveSystem
            // 
            this.btnSaveSystem.BackColor = System.Drawing.Color.Gray;
            this.btnSaveSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveSystem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSaveSystem.FlatAppearance.BorderSize = 0;
            this.btnSaveSystem.ForeColor = System.Drawing.Color.Black;
            this.btnSaveSystem.Location = new System.Drawing.Point(0, 0);
            this.btnSaveSystem.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveSystem.Name = "btnSaveSystem";
            this.btnSaveSystem.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSaveSystem.Size = new System.Drawing.Size(374, 50);
            this.btnSaveSystem.TabIndex = 24;
            this.btnSaveSystem.Text = "Save System";
            this.btnSaveSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSystem.UseVisualStyleBackColor = false;
            // 
            // btnSaveLoad
            // 
            this.btnSaveLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveLoad.Location = new System.Drawing.Point(0, 1020);
            this.btnSaveLoad.Name = "btnSaveLoad";
            this.btnSaveLoad.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSaveLoad.Size = new System.Drawing.Size(374, 60);
            this.btnSaveLoad.TabIndex = 5;
            this.btnSaveLoad.Text = "Save/Load Data";
            this.btnSaveLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveLoad.UseVisualStyleBackColor = false;
            this.btnSaveLoad.Click += new System.EventHandler(this.btnSaveLoad_Click);
            // 
            // panelMenuUnitSystems
            // 
            this.panelMenuUnitSystems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenuUnitSystems.Controls.Add(this.radioSolarUnits);
            this.panelMenuUnitSystems.Controls.Add(this.radioAstroUnits);
            this.panelMenuUnitSystems.Controls.Add(this.radioNaturalUnits);
            this.panelMenuUnitSystems.Controls.Add(this.radioSiUnits);
            this.panelMenuUnitSystems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuUnitSystems.Location = new System.Drawing.Point(0, 820);
            this.panelMenuUnitSystems.Name = "panelMenuUnitSystems";
            this.panelMenuUnitSystems.Size = new System.Drawing.Size(374, 200);
            this.panelMenuUnitSystems.TabIndex = 4;
            // 
            // radioSolarUnits
            // 
            this.radioSolarUnits.BackColor = System.Drawing.Color.Gray;
            this.radioSolarUnits.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioSolarUnits.ForeColor = System.Drawing.Color.Black;
            this.radioSolarUnits.Location = new System.Drawing.Point(0, 150);
            this.radioSolarUnits.Name = "radioSolarUnits";
            this.radioSolarUnits.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.radioSolarUnits.Size = new System.Drawing.Size(374, 50);
            this.radioSolarUnits.TabIndex = 3;
            this.radioSolarUnits.TabStop = true;
            this.radioSolarUnits.Text = "Solar Units";
            this.radioSolarUnits.UseVisualStyleBackColor = false;
            // 
            // radioAstroUnits
            // 
            this.radioAstroUnits.BackColor = System.Drawing.Color.Gray;
            this.radioAstroUnits.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioAstroUnits.ForeColor = System.Drawing.Color.Black;
            this.radioAstroUnits.Location = new System.Drawing.Point(0, 100);
            this.radioAstroUnits.Name = "radioAstroUnits";
            this.radioAstroUnits.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.radioAstroUnits.Size = new System.Drawing.Size(374, 50);
            this.radioAstroUnits.TabIndex = 2;
            this.radioAstroUnits.TabStop = true;
            this.radioAstroUnits.Text = "Astrophysics";
            this.radioAstroUnits.UseVisualStyleBackColor = false;
            // 
            // radioNaturalUnits
            // 
            this.radioNaturalUnits.BackColor = System.Drawing.Color.Gray;
            this.radioNaturalUnits.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioNaturalUnits.ForeColor = System.Drawing.Color.Black;
            this.radioNaturalUnits.Location = new System.Drawing.Point(0, 50);
            this.radioNaturalUnits.Name = "radioNaturalUnits";
            this.radioNaturalUnits.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.radioNaturalUnits.Size = new System.Drawing.Size(374, 50);
            this.radioNaturalUnits.TabIndex = 1;
            this.radioNaturalUnits.TabStop = true;
            this.radioNaturalUnits.Text = "Naturalized";
            this.radioNaturalUnits.UseVisualStyleBackColor = false;
            // 
            // radioSiUnits
            // 
            this.radioSiUnits.BackColor = System.Drawing.Color.Gray;
            this.radioSiUnits.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioSiUnits.ForeColor = System.Drawing.Color.Black;
            this.radioSiUnits.Location = new System.Drawing.Point(0, 0);
            this.radioSiUnits.Name = "radioSiUnits";
            this.radioSiUnits.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.radioSiUnits.Size = new System.Drawing.Size(374, 50);
            this.radioSiUnits.TabIndex = 0;
            this.radioSiUnits.TabStop = true;
            this.radioSiUnits.Text = "Scientific International";
            this.radioSiUnits.UseVisualStyleBackColor = false;
            // 
            // btnUnitSystems
            // 
            this.btnUnitSystems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUnitSystems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnitSystems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitSystems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnitSystems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUnitSystems.Location = new System.Drawing.Point(0, 760);
            this.btnUnitSystems.Name = "btnUnitSystems";
            this.btnUnitSystems.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUnitSystems.Size = new System.Drawing.Size(374, 60);
            this.btnUnitSystems.TabIndex = 3;
            this.btnUnitSystems.Text = "Unit Systems";
            this.btnUnitSystems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnitSystems.UseVisualStyleBackColor = false;
            this.btnUnitSystems.Click += new System.EventHandler(this.btnUnitSystems_Click);
            // 
            // panelMenuSystemDetails
            // 
            this.panelMenuSystemDetails.Controls.Add(this.splitMenuSystemDetails);
            this.panelMenuSystemDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuSystemDetails.Location = new System.Drawing.Point(0, 360);
            this.panelMenuSystemDetails.Name = "panelMenuSystemDetails";
            this.panelMenuSystemDetails.Size = new System.Drawing.Size(374, 400);
            this.panelMenuSystemDetails.TabIndex = 2;
            // 
            // splitMenuSystemDetails
            // 
            this.splitMenuSystemDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMenuSystemDetails.Location = new System.Drawing.Point(0, 0);
            this.splitMenuSystemDetails.Name = "splitMenuSystemDetails";
            // 
            // splitMenuSystemDetails.Panel1
            // 
            this.splitMenuSystemDetails.Panel1.Controls.Add(this.btnHelpNetVelZ);
            this.splitMenuSystemDetails.Panel1.Controls.Add(this.btnHelpNetVelY);
            this.splitMenuSystemDetails.Panel1.Controls.Add(this.btnHelpNetVelX);
            this.splitMenuSystemDetails.Panel1.Controls.Add(this.btnHelpCmZ);
            this.splitMenuSystemDetails.Panel1.Controls.Add(this.btnHelpCmY);
            this.splitMenuSystemDetails.Panel1.Controls.Add(this.btnHelpCmX);
            this.splitMenuSystemDetails.Panel1.Controls.Add(this.btnHelpAvgMass);
            this.splitMenuSystemDetails.Panel1.Controls.Add(this.btnHelpTotalMass);
            // 
            // splitMenuSystemDetails.Panel2
            // 
            this.splitMenuSystemDetails.Panel2.Controls.Add(this.labelNetVelZ);
            this.splitMenuSystemDetails.Panel2.Controls.Add(this.labelNetVelY);
            this.splitMenuSystemDetails.Panel2.Controls.Add(this.labelNetVelX);
            this.splitMenuSystemDetails.Panel2.Controls.Add(this.labelCmZ);
            this.splitMenuSystemDetails.Panel2.Controls.Add(this.labelCmY);
            this.splitMenuSystemDetails.Panel2.Controls.Add(this.labelCmX);
            this.splitMenuSystemDetails.Panel2.Controls.Add(this.labelAvgMass);
            this.splitMenuSystemDetails.Panel2.Controls.Add(this.labelTotalMass);
            this.splitMenuSystemDetails.Size = new System.Drawing.Size(374, 400);
            this.splitMenuSystemDetails.SplitterDistance = 250;
            this.splitMenuSystemDetails.TabIndex = 0;
            // 
            // btnHelpNetVelZ
            // 
            this.btnHelpNetVelZ.BackColor = System.Drawing.Color.Gray;
            this.btnHelpNetVelZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpNetVelZ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpNetVelZ.FlatAppearance.BorderSize = 0;
            this.btnHelpNetVelZ.ForeColor = System.Drawing.Color.Black;
            this.btnHelpNetVelZ.Location = new System.Drawing.Point(0, 350);
            this.btnHelpNetVelZ.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpNetVelZ.Name = "btnHelpNetVelZ";
            this.btnHelpNetVelZ.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpNetVelZ.Size = new System.Drawing.Size(250, 50);
            this.btnHelpNetVelZ.TabIndex = 37;
            this.btnHelpNetVelZ.Text = "Z Net-Velocity";
            this.btnHelpNetVelZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpNetVelZ.UseVisualStyleBackColor = false;
            // 
            // btnHelpNetVelY
            // 
            this.btnHelpNetVelY.BackColor = System.Drawing.Color.Gray;
            this.btnHelpNetVelY.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpNetVelY.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpNetVelY.FlatAppearance.BorderSize = 0;
            this.btnHelpNetVelY.ForeColor = System.Drawing.Color.Black;
            this.btnHelpNetVelY.Location = new System.Drawing.Point(0, 300);
            this.btnHelpNetVelY.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpNetVelY.Name = "btnHelpNetVelY";
            this.btnHelpNetVelY.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpNetVelY.Size = new System.Drawing.Size(250, 50);
            this.btnHelpNetVelY.TabIndex = 36;
            this.btnHelpNetVelY.Text = "Y Net-Velocity";
            this.btnHelpNetVelY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpNetVelY.UseVisualStyleBackColor = false;
            // 
            // btnHelpNetVelX
            // 
            this.btnHelpNetVelX.BackColor = System.Drawing.Color.Gray;
            this.btnHelpNetVelX.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpNetVelX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpNetVelX.FlatAppearance.BorderSize = 0;
            this.btnHelpNetVelX.ForeColor = System.Drawing.Color.Black;
            this.btnHelpNetVelX.Location = new System.Drawing.Point(0, 250);
            this.btnHelpNetVelX.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpNetVelX.Name = "btnHelpNetVelX";
            this.btnHelpNetVelX.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpNetVelX.Size = new System.Drawing.Size(250, 50);
            this.btnHelpNetVelX.TabIndex = 35;
            this.btnHelpNetVelX.Text = "X Net-Velocity";
            this.btnHelpNetVelX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpNetVelX.UseVisualStyleBackColor = false;
            // 
            // btnHelpCmZ
            // 
            this.btnHelpCmZ.BackColor = System.Drawing.Color.Gray;
            this.btnHelpCmZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpCmZ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpCmZ.FlatAppearance.BorderSize = 0;
            this.btnHelpCmZ.ForeColor = System.Drawing.Color.Black;
            this.btnHelpCmZ.Location = new System.Drawing.Point(0, 200);
            this.btnHelpCmZ.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpCmZ.Name = "btnHelpCmZ";
            this.btnHelpCmZ.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpCmZ.Size = new System.Drawing.Size(250, 50);
            this.btnHelpCmZ.TabIndex = 34;
            this.btnHelpCmZ.Text = "Z-Center of Mass";
            this.btnHelpCmZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpCmZ.UseVisualStyleBackColor = false;
            // 
            // btnHelpCmY
            // 
            this.btnHelpCmY.BackColor = System.Drawing.Color.Gray;
            this.btnHelpCmY.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpCmY.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpCmY.FlatAppearance.BorderSize = 0;
            this.btnHelpCmY.ForeColor = System.Drawing.Color.Black;
            this.btnHelpCmY.Location = new System.Drawing.Point(0, 150);
            this.btnHelpCmY.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpCmY.Name = "btnHelpCmY";
            this.btnHelpCmY.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpCmY.Size = new System.Drawing.Size(250, 50);
            this.btnHelpCmY.TabIndex = 33;
            this.btnHelpCmY.Text = "Y-Center of Mass";
            this.btnHelpCmY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpCmY.UseVisualStyleBackColor = false;
            // 
            // btnHelpCmX
            // 
            this.btnHelpCmX.BackColor = System.Drawing.Color.Gray;
            this.btnHelpCmX.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpCmX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpCmX.FlatAppearance.BorderSize = 0;
            this.btnHelpCmX.ForeColor = System.Drawing.Color.Black;
            this.btnHelpCmX.Location = new System.Drawing.Point(0, 100);
            this.btnHelpCmX.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpCmX.Name = "btnHelpCmX";
            this.btnHelpCmX.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpCmX.Size = new System.Drawing.Size(250, 50);
            this.btnHelpCmX.TabIndex = 32;
            this.btnHelpCmX.Text = "X-Center of Mass";
            this.btnHelpCmX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpCmX.UseVisualStyleBackColor = false;
            // 
            // btnHelpAvgMass
            // 
            this.btnHelpAvgMass.BackColor = System.Drawing.Color.Gray;
            this.btnHelpAvgMass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpAvgMass.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpAvgMass.FlatAppearance.BorderSize = 0;
            this.btnHelpAvgMass.ForeColor = System.Drawing.Color.Black;
            this.btnHelpAvgMass.Location = new System.Drawing.Point(0, 50);
            this.btnHelpAvgMass.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpAvgMass.Name = "btnHelpAvgMass";
            this.btnHelpAvgMass.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpAvgMass.Size = new System.Drawing.Size(250, 50);
            this.btnHelpAvgMass.TabIndex = 30;
            this.btnHelpAvgMass.Text = "Average Mass";
            this.btnHelpAvgMass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpAvgMass.UseVisualStyleBackColor = false;
            // 
            // btnHelpTotalMass
            // 
            this.btnHelpTotalMass.BackColor = System.Drawing.Color.Gray;
            this.btnHelpTotalMass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpTotalMass.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpTotalMass.FlatAppearance.BorderSize = 0;
            this.btnHelpTotalMass.ForeColor = System.Drawing.Color.Black;
            this.btnHelpTotalMass.Location = new System.Drawing.Point(0, 0);
            this.btnHelpTotalMass.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpTotalMass.Name = "btnHelpTotalMass";
            this.btnHelpTotalMass.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpTotalMass.Size = new System.Drawing.Size(250, 50);
            this.btnHelpTotalMass.TabIndex = 29;
            this.btnHelpTotalMass.Text = "Total Mass";
            this.btnHelpTotalMass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpTotalMass.UseVisualStyleBackColor = false;
            // 
            // labelNetVelZ
            // 
            this.labelNetVelZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNetVelZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNetVelZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNetVelZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelNetVelZ.Location = new System.Drawing.Point(0, 350);
            this.labelNetVelZ.Name = "labelNetVelZ";
            this.labelNetVelZ.Size = new System.Drawing.Size(120, 50);
            this.labelNetVelZ.TabIndex = 7;
            this.labelNetVelZ.Text = "---";
            this.labelNetVelZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNetVelY
            // 
            this.labelNetVelY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNetVelY.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNetVelY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNetVelY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelNetVelY.Location = new System.Drawing.Point(0, 300);
            this.labelNetVelY.Name = "labelNetVelY";
            this.labelNetVelY.Size = new System.Drawing.Size(120, 50);
            this.labelNetVelY.TabIndex = 6;
            this.labelNetVelY.Text = "---";
            this.labelNetVelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNetVelX
            // 
            this.labelNetVelX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNetVelX.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNetVelX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNetVelX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelNetVelX.Location = new System.Drawing.Point(0, 250);
            this.labelNetVelX.Name = "labelNetVelX";
            this.labelNetVelX.Size = new System.Drawing.Size(120, 50);
            this.labelNetVelX.TabIndex = 5;
            this.labelNetVelX.Text = "---";
            this.labelNetVelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCmZ
            // 
            this.labelCmZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCmZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCmZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCmZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelCmZ.Location = new System.Drawing.Point(0, 200);
            this.labelCmZ.Name = "labelCmZ";
            this.labelCmZ.Size = new System.Drawing.Size(120, 50);
            this.labelCmZ.TabIndex = 4;
            this.labelCmZ.Text = "---";
            this.labelCmZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCmY
            // 
            this.labelCmY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCmY.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCmY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCmY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelCmY.Location = new System.Drawing.Point(0, 150);
            this.labelCmY.Name = "labelCmY";
            this.labelCmY.Size = new System.Drawing.Size(120, 50);
            this.labelCmY.TabIndex = 3;
            this.labelCmY.Text = "---";
            this.labelCmY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCmX
            // 
            this.labelCmX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCmX.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCmX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCmX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelCmX.Location = new System.Drawing.Point(0, 100);
            this.labelCmX.Name = "labelCmX";
            this.labelCmX.Size = new System.Drawing.Size(120, 50);
            this.labelCmX.TabIndex = 2;
            this.labelCmX.Text = "---";
            this.labelCmX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAvgMass
            // 
            this.labelAvgMass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAvgMass.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAvgMass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAvgMass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelAvgMass.Location = new System.Drawing.Point(0, 50);
            this.labelAvgMass.Name = "labelAvgMass";
            this.labelAvgMass.Size = new System.Drawing.Size(120, 50);
            this.labelAvgMass.TabIndex = 1;
            this.labelAvgMass.Text = "---";
            this.labelAvgMass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalMass
            // 
            this.labelTotalMass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalMass.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTotalMass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalMass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTotalMass.Location = new System.Drawing.Point(0, 0);
            this.labelTotalMass.Name = "labelTotalMass";
            this.labelTotalMass.Size = new System.Drawing.Size(120, 50);
            this.labelTotalMass.TabIndex = 0;
            this.labelTotalMass.Text = "---";
            this.labelTotalMass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSystemDetails
            // 
            this.btnSystemDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSystemDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystemDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSystemDetails.Location = new System.Drawing.Point(0, 300);
            this.btnSystemDetails.Name = "btnSystemDetails";
            this.btnSystemDetails.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSystemDetails.Size = new System.Drawing.Size(374, 60);
            this.btnSystemDetails.TabIndex = 1;
            this.btnSystemDetails.Text = "System Details";
            this.btnSystemDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystemDetails.UseVisualStyleBackColor = false;
            this.btnSystemDetails.Click += new System.EventHandler(this.btnSystemDetails_Click);
            // 
            // panelMainLogo
            // 
            this.panelMainLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainLogo.Location = new System.Drawing.Point(0, 0);
            this.panelMainLogo.Name = "panelMainLogo";
            this.panelMainLogo.Size = new System.Drawing.Size(374, 300);
            this.panelMainLogo.TabIndex = 0;
            // 
            // panelMenuRight
            // 
            this.panelMenuRight.AutoScroll = true;
            this.panelMenuRight.Controls.Add(this.panelMenuAddBody);
            this.panelMenuRight.Controls.Add(this.btnShowAdd);
            this.panelMenuRight.Controls.Add(this.panelTopRight);
            this.panelMenuRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuRight.Location = new System.Drawing.Point(1578, 0);
            this.panelMenuRight.Name = "panelMenuRight";
            this.panelMenuRight.Size = new System.Drawing.Size(400, 1344);
            this.panelMenuRight.TabIndex = 1;
            // 
            // panelMenuAddBody
            // 
            this.panelMenuAddBody.AutoScroll = true;
            this.panelMenuAddBody.Controls.Add(this.btnAddBodyObj);
            this.panelMenuAddBody.Controls.Add(this.splitMenuAddBody);
            this.panelMenuAddBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuAddBody.Location = new System.Drawing.Point(0, 360);
            this.panelMenuAddBody.Name = "panelMenuAddBody";
            this.panelMenuAddBody.Size = new System.Drawing.Size(400, 550);
            this.panelMenuAddBody.TabIndex = 3;
            // 
            // btnAddBodyObj
            // 
            this.btnAddBodyObj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddBodyObj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddBodyObj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBodyObj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddBodyObj.Location = new System.Drawing.Point(0, 500);
            this.btnAddBodyObj.Name = "btnAddBodyObj";
            this.btnAddBodyObj.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnAddBodyObj.Size = new System.Drawing.Size(400, 50);
            this.btnAddBodyObj.TabIndex = 3;
            this.btnAddBodyObj.Text = "Add Body To System";
            this.btnAddBodyObj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBodyObj.UseVisualStyleBackColor = false;
            this.btnAddBodyObj.Click += new System.EventHandler(this.btnAddBodyObj_Click);
            // 
            // splitMenuAddBody
            // 
            this.splitMenuAddBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitMenuAddBody.Location = new System.Drawing.Point(0, 0);
            this.splitMenuAddBody.Name = "splitMenuAddBody";
            // 
            // splitMenuAddBody.Panel1
            // 
            this.splitMenuAddBody.Panel1.Controls.Add(this.btnHelpVelZ);
            this.splitMenuAddBody.Panel1.Controls.Add(this.btnHelpVelY);
            this.splitMenuAddBody.Panel1.Controls.Add(this.btnHelpVelX);
            this.splitMenuAddBody.Panel1.Controls.Add(this.btnHelpPosZ);
            this.splitMenuAddBody.Panel1.Controls.Add(this.btnHelpPosY);
            this.splitMenuAddBody.Panel1.Controls.Add(this.btnHelpPosX);
            this.splitMenuAddBody.Panel1.Controls.Add(this.btnHelpRadius);
            this.splitMenuAddBody.Panel1.Controls.Add(this.btnHelpMass);
            this.splitMenuAddBody.Panel1.Controls.Add(this.btnHelpName);
            this.splitMenuAddBody.Panel1.Controls.Add(this.btnAddAttrbHelp);
            // 
            // splitMenuAddBody.Panel2
            // 
            this.splitMenuAddBody.Panel2.Controls.Add(this.txtAddVelZ);
            this.splitMenuAddBody.Panel2.Controls.Add(this.txtAddVelY);
            this.splitMenuAddBody.Panel2.Controls.Add(this.txtAddVelX);
            this.splitMenuAddBody.Panel2.Controls.Add(this.txtAddPosZ);
            this.splitMenuAddBody.Panel2.Controls.Add(this.txtAddPosY);
            this.splitMenuAddBody.Panel2.Controls.Add(this.txtAddPosX);
            this.splitMenuAddBody.Panel2.Controls.Add(this.txtAddRadius);
            this.splitMenuAddBody.Panel2.Controls.Add(this.txtAddMass);
            this.splitMenuAddBody.Panel2.Controls.Add(this.txtAddName);
            this.splitMenuAddBody.Panel2.Controls.Add(this.btnAddValueHelp);
            this.splitMenuAddBody.Size = new System.Drawing.Size(400, 500);
            this.splitMenuAddBody.SplitterDistance = 200;
            this.splitMenuAddBody.TabIndex = 0;
            // 
            // btnHelpVelZ
            // 
            this.btnHelpVelZ.BackColor = System.Drawing.Color.Gray;
            this.btnHelpVelZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpVelZ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpVelZ.FlatAppearance.BorderSize = 0;
            this.btnHelpVelZ.ForeColor = System.Drawing.Color.Black;
            this.btnHelpVelZ.Location = new System.Drawing.Point(0, 450);
            this.btnHelpVelZ.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpVelZ.Name = "btnHelpVelZ";
            this.btnHelpVelZ.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpVelZ.Size = new System.Drawing.Size(200, 50);
            this.btnHelpVelZ.TabIndex = 31;
            this.btnHelpVelZ.Text = "Z-Velocity";
            this.btnHelpVelZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpVelZ.UseVisualStyleBackColor = false;
            this.btnHelpVelZ.Click += new System.EventHandler(this.btnHelpVelZ_Click);
            // 
            // btnHelpVelY
            // 
            this.btnHelpVelY.BackColor = System.Drawing.Color.Gray;
            this.btnHelpVelY.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpVelY.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpVelY.FlatAppearance.BorderSize = 0;
            this.btnHelpVelY.ForeColor = System.Drawing.Color.Black;
            this.btnHelpVelY.Location = new System.Drawing.Point(0, 400);
            this.btnHelpVelY.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpVelY.Name = "btnHelpVelY";
            this.btnHelpVelY.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpVelY.Size = new System.Drawing.Size(200, 50);
            this.btnHelpVelY.TabIndex = 30;
            this.btnHelpVelY.Text = "Y-Velocity";
            this.btnHelpVelY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpVelY.UseVisualStyleBackColor = false;
            this.btnHelpVelY.Click += new System.EventHandler(this.btnHelpVelY_Click);
            // 
            // btnHelpVelX
            // 
            this.btnHelpVelX.BackColor = System.Drawing.Color.Gray;
            this.btnHelpVelX.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpVelX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpVelX.FlatAppearance.BorderSize = 0;
            this.btnHelpVelX.ForeColor = System.Drawing.Color.Black;
            this.btnHelpVelX.Location = new System.Drawing.Point(0, 350);
            this.btnHelpVelX.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpVelX.Name = "btnHelpVelX";
            this.btnHelpVelX.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpVelX.Size = new System.Drawing.Size(200, 50);
            this.btnHelpVelX.TabIndex = 29;
            this.btnHelpVelX.Text = "X-Velocity";
            this.btnHelpVelX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpVelX.UseVisualStyleBackColor = false;
            this.btnHelpVelX.Click += new System.EventHandler(this.btnHelpVelX_Click);
            // 
            // btnHelpPosZ
            // 
            this.btnHelpPosZ.BackColor = System.Drawing.Color.Gray;
            this.btnHelpPosZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpPosZ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpPosZ.FlatAppearance.BorderSize = 0;
            this.btnHelpPosZ.ForeColor = System.Drawing.Color.Black;
            this.btnHelpPosZ.Location = new System.Drawing.Point(0, 300);
            this.btnHelpPosZ.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpPosZ.Name = "btnHelpPosZ";
            this.btnHelpPosZ.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpPosZ.Size = new System.Drawing.Size(200, 50);
            this.btnHelpPosZ.TabIndex = 28;
            this.btnHelpPosZ.Text = "Z-Position";
            this.btnHelpPosZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpPosZ.UseVisualStyleBackColor = false;
            this.btnHelpPosZ.Click += new System.EventHandler(this.btnHelpPosZ_Click);
            // 
            // btnHelpPosY
            // 
            this.btnHelpPosY.BackColor = System.Drawing.Color.Gray;
            this.btnHelpPosY.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpPosY.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpPosY.FlatAppearance.BorderSize = 0;
            this.btnHelpPosY.ForeColor = System.Drawing.Color.Black;
            this.btnHelpPosY.Location = new System.Drawing.Point(0, 250);
            this.btnHelpPosY.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpPosY.Name = "btnHelpPosY";
            this.btnHelpPosY.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpPosY.Size = new System.Drawing.Size(200, 50);
            this.btnHelpPosY.TabIndex = 27;
            this.btnHelpPosY.Text = "Y-Position";
            this.btnHelpPosY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpPosY.UseVisualStyleBackColor = false;
            this.btnHelpPosY.Click += new System.EventHandler(this.btnHelpPosY_Click);
            // 
            // btnHelpPosX
            // 
            this.btnHelpPosX.BackColor = System.Drawing.Color.Gray;
            this.btnHelpPosX.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpPosX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpPosX.FlatAppearance.BorderSize = 0;
            this.btnHelpPosX.ForeColor = System.Drawing.Color.Black;
            this.btnHelpPosX.Location = new System.Drawing.Point(0, 200);
            this.btnHelpPosX.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpPosX.Name = "btnHelpPosX";
            this.btnHelpPosX.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpPosX.Size = new System.Drawing.Size(200, 50);
            this.btnHelpPosX.TabIndex = 26;
            this.btnHelpPosX.Text = "X-Position";
            this.btnHelpPosX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpPosX.UseVisualStyleBackColor = false;
            this.btnHelpPosX.Click += new System.EventHandler(this.btnHelpPosX_Click);
            // 
            // btnHelpRadius
            // 
            this.btnHelpRadius.BackColor = System.Drawing.Color.Gray;
            this.btnHelpRadius.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpRadius.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpRadius.FlatAppearance.BorderSize = 0;
            this.btnHelpRadius.ForeColor = System.Drawing.Color.Black;
            this.btnHelpRadius.Location = new System.Drawing.Point(0, 150);
            this.btnHelpRadius.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpRadius.Name = "btnHelpRadius";
            this.btnHelpRadius.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpRadius.Size = new System.Drawing.Size(200, 50);
            this.btnHelpRadius.TabIndex = 25;
            this.btnHelpRadius.Text = "Radius";
            this.btnHelpRadius.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpRadius.UseVisualStyleBackColor = false;
            this.btnHelpRadius.Click += new System.EventHandler(this.btnHelpRadius_Click);
            // 
            // btnHelpMass
            // 
            this.btnHelpMass.BackColor = System.Drawing.Color.Gray;
            this.btnHelpMass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpMass.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpMass.FlatAppearance.BorderSize = 0;
            this.btnHelpMass.ForeColor = System.Drawing.Color.Black;
            this.btnHelpMass.Location = new System.Drawing.Point(0, 100);
            this.btnHelpMass.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpMass.Name = "btnHelpMass";
            this.btnHelpMass.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpMass.Size = new System.Drawing.Size(200, 50);
            this.btnHelpMass.TabIndex = 24;
            this.btnHelpMass.Text = "Mass";
            this.btnHelpMass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpMass.UseVisualStyleBackColor = false;
            this.btnHelpMass.Click += new System.EventHandler(this.btnHelpMass_Click);
            // 
            // btnHelpName
            // 
            this.btnHelpName.BackColor = System.Drawing.Color.Gray;
            this.btnHelpName.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpName.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpName.FlatAppearance.BorderSize = 0;
            this.btnHelpName.ForeColor = System.Drawing.Color.Black;
            this.btnHelpName.Location = new System.Drawing.Point(0, 50);
            this.btnHelpName.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpName.Name = "btnHelpName";
            this.btnHelpName.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpName.Size = new System.Drawing.Size(200, 50);
            this.btnHelpName.TabIndex = 23;
            this.btnHelpName.Text = "Name";
            this.btnHelpName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpName.UseVisualStyleBackColor = false;
            this.btnHelpName.Click += new System.EventHandler(this.btnHelpName_Click);
            // 
            // btnAddAttrbHelp
            // 
            this.btnAddAttrbHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddAttrbHelp.Location = new System.Drawing.Point(0, 0);
            this.btnAddAttrbHelp.Name = "btnAddAttrbHelp";
            this.btnAddAttrbHelp.Size = new System.Drawing.Size(200, 50);
            this.btnAddAttrbHelp.TabIndex = 22;
            this.btnAddAttrbHelp.Text = "Attribute";
            this.btnAddAttrbHelp.UseVisualStyleBackColor = true;
            // 
            // txtAddVelZ
            // 
            this.txtAddVelZ.BackColor = System.Drawing.Color.White;
            this.txtAddVelZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddVelZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddVelZ.Location = new System.Drawing.Point(0, 450);
            this.txtAddVelZ.Multiline = true;
            this.txtAddVelZ.Name = "txtAddVelZ";
            this.txtAddVelZ.Size = new System.Drawing.Size(196, 50);
            this.txtAddVelZ.TabIndex = 28;
            this.txtAddVelZ.Text = "0";
            this.txtAddVelZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddVelY
            // 
            this.txtAddVelY.BackColor = System.Drawing.Color.White;
            this.txtAddVelY.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddVelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddVelY.Location = new System.Drawing.Point(0, 400);
            this.txtAddVelY.Multiline = true;
            this.txtAddVelY.Name = "txtAddVelY";
            this.txtAddVelY.Size = new System.Drawing.Size(196, 50);
            this.txtAddVelY.TabIndex = 27;
            this.txtAddVelY.Text = "0";
            this.txtAddVelY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddVelX
            // 
            this.txtAddVelX.BackColor = System.Drawing.Color.White;
            this.txtAddVelX.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddVelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddVelX.Location = new System.Drawing.Point(0, 350);
            this.txtAddVelX.Multiline = true;
            this.txtAddVelX.Name = "txtAddVelX";
            this.txtAddVelX.Size = new System.Drawing.Size(196, 50);
            this.txtAddVelX.TabIndex = 26;
            this.txtAddVelX.Text = "0";
            this.txtAddVelX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddPosZ
            // 
            this.txtAddPosZ.BackColor = System.Drawing.Color.White;
            this.txtAddPosZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddPosZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPosZ.Location = new System.Drawing.Point(0, 300);
            this.txtAddPosZ.Multiline = true;
            this.txtAddPosZ.Name = "txtAddPosZ";
            this.txtAddPosZ.Size = new System.Drawing.Size(196, 50);
            this.txtAddPosZ.TabIndex = 25;
            this.txtAddPosZ.Text = "0";
            this.txtAddPosZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddPosY
            // 
            this.txtAddPosY.BackColor = System.Drawing.Color.White;
            this.txtAddPosY.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPosY.Location = new System.Drawing.Point(0, 250);
            this.txtAddPosY.Multiline = true;
            this.txtAddPosY.Name = "txtAddPosY";
            this.txtAddPosY.Size = new System.Drawing.Size(196, 50);
            this.txtAddPosY.TabIndex = 24;
            this.txtAddPosY.Text = "0";
            this.txtAddPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddPosX
            // 
            this.txtAddPosX.BackColor = System.Drawing.Color.White;
            this.txtAddPosX.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPosX.Location = new System.Drawing.Point(0, 200);
            this.txtAddPosX.Multiline = true;
            this.txtAddPosX.Name = "txtAddPosX";
            this.txtAddPosX.Size = new System.Drawing.Size(196, 50);
            this.txtAddPosX.TabIndex = 23;
            this.txtAddPosX.Text = "0";
            this.txtAddPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddRadius
            // 
            this.txtAddRadius.BackColor = System.Drawing.Color.White;
            this.txtAddRadius.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddRadius.Location = new System.Drawing.Point(0, 150);
            this.txtAddRadius.Multiline = true;
            this.txtAddRadius.Name = "txtAddRadius";
            this.txtAddRadius.Size = new System.Drawing.Size(196, 50);
            this.txtAddRadius.TabIndex = 22;
            this.txtAddRadius.Text = "0";
            this.txtAddRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddMass
            // 
            this.txtAddMass.BackColor = System.Drawing.Color.White;
            this.txtAddMass.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddMass.Location = new System.Drawing.Point(0, 100);
            this.txtAddMass.Multiline = true;
            this.txtAddMass.Name = "txtAddMass";
            this.txtAddMass.Size = new System.Drawing.Size(196, 50);
            this.txtAddMass.TabIndex = 21;
            this.txtAddMass.Text = "0";
            this.txtAddMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddName
            // 
            this.txtAddName.BackColor = System.Drawing.Color.White;
            this.txtAddName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddName.Location = new System.Drawing.Point(0, 50);
            this.txtAddName.MinimumSize = new System.Drawing.Size(196, 44);
            this.txtAddName.Multiline = true;
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(196, 50);
            this.txtAddName.TabIndex = 20;
            this.txtAddName.Text = "0";
            this.txtAddName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddValueHelp
            // 
            this.btnAddValueHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddValueHelp.Location = new System.Drawing.Point(0, 0);
            this.btnAddValueHelp.Name = "btnAddValueHelp";
            this.btnAddValueHelp.Size = new System.Drawing.Size(196, 50);
            this.btnAddValueHelp.TabIndex = 19;
            this.btnAddValueHelp.Text = "Value";
            this.btnAddValueHelp.UseVisualStyleBackColor = true;
            // 
            // btnShowAdd
            // 
            this.btnShowAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowAdd.Location = new System.Drawing.Point(0, 300);
            this.btnShowAdd.Name = "btnShowAdd";
            this.btnShowAdd.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnShowAdd.Size = new System.Drawing.Size(400, 60);
            this.btnShowAdd.TabIndex = 2;
            this.btnShowAdd.Text = "Add Body Options";
            this.btnShowAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAdd.UseVisualStyleBackColor = false;
            this.btnShowAdd.Click += new System.EventHandler(this.btnShowAdd_Click);
            // 
            // panelTopRight
            // 
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopRight.Location = new System.Drawing.Point(0, 0);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(400, 300);
            this.panelTopRight.TabIndex = 1;
            // 
            // panelTopCenter
            // 
            this.panelTopCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopCenter.Location = new System.Drawing.Point(400, 0);
            this.panelTopCenter.Name = "panelTopCenter";
            this.panelTopCenter.Size = new System.Drawing.Size(1178, 200);
            this.panelTopCenter.TabIndex = 2;
            // 
            // panelMainViewer
            // 
            this.panelMainViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMainViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainViewer.Location = new System.Drawing.Point(400, 200);
            this.panelMainViewer.Name = "panelMainViewer";
            this.panelMainViewer.Size = new System.Drawing.Size(1178, 1144);
            this.panelMainViewer.TabIndex = 3;
            // 
            // multibodySystemBindingSource
            // 
            this.multibodySystemBindingSource.DataSource = typeof(Multibody_Simulation_v0.Multibody_System);
            // 
            // panelBottomCenter
            // 
            this.panelBottomCenter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomCenter.Location = new System.Drawing.Point(400, 1244);
            this.panelBottomCenter.Name = "panelBottomCenter";
            this.panelBottomCenter.Size = new System.Drawing.Size(1178, 100);
            this.panelBottomCenter.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1978, 1344);
            this.Controls.Add(this.panelBottomCenter);
            this.Controls.Add(this.panelMainViewer);
            this.Controls.Add(this.panelTopCenter);
            this.Controls.Add(this.panelMenuRight);
            this.Controls.Add(this.panelMenuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FormMain";
            this.Text = "Multibody Simulation";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMenuMain.ResumeLayout(false);
            this.panelMenuSaveLoad.ResumeLayout(false);
            this.panelMenuUnitSystems.ResumeLayout(false);
            this.panelMenuSystemDetails.ResumeLayout(false);
            this.splitMenuSystemDetails.Panel1.ResumeLayout(false);
            this.splitMenuSystemDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMenuSystemDetails)).EndInit();
            this.splitMenuSystemDetails.ResumeLayout(false);
            this.panelMenuRight.ResumeLayout(false);
            this.panelMenuAddBody.ResumeLayout(false);
            this.splitMenuAddBody.Panel1.ResumeLayout(false);
            this.splitMenuAddBody.Panel2.ResumeLayout(false);
            this.splitMenuAddBody.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMenuAddBody)).EndInit();
            this.splitMenuAddBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.multibodySystemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuMain;
        private System.Windows.Forms.Button btnSystemDetails;
        private System.Windows.Forms.Panel panelMainLogo;
        private System.Windows.Forms.Panel panelMenuSystemDetails;
        private System.Windows.Forms.Panel panelMenuUnitSystems;
        private System.Windows.Forms.Button btnUnitSystems;
        private System.Windows.Forms.Panel panelMenuRight;
        private System.Windows.Forms.RadioButton radioSolarUnits;
        private System.Windows.Forms.RadioButton radioAstroUnits;
        private System.Windows.Forms.RadioButton radioNaturalUnits;
        private System.Windows.Forms.RadioButton radioSiUnits;
        private System.Windows.Forms.Panel panelTopCenter;
        private System.Windows.Forms.Panel panelMainViewer;
        private System.Windows.Forms.Panel panelBottomCenter;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Panel panelMenuAddBody;
        private System.Windows.Forms.Button btnShowAdd;
        private System.Windows.Forms.SplitContainer splitMenuAddBody;
        private System.Windows.Forms.Button btnHelpVelZ;
        private System.Windows.Forms.Button btnHelpVelY;
        private System.Windows.Forms.Button btnHelpVelX;
        private System.Windows.Forms.Button btnHelpPosZ;
        private System.Windows.Forms.Button btnHelpPosY;
        private System.Windows.Forms.Button btnHelpPosX;
        private System.Windows.Forms.Button btnHelpRadius;
        private System.Windows.Forms.Button btnHelpMass;
        private System.Windows.Forms.Button btnHelpName;
        private System.Windows.Forms.Button btnAddAttrbHelp;
        private System.Windows.Forms.TextBox txtAddPosY;
        private System.Windows.Forms.TextBox txtAddPosX;
        private System.Windows.Forms.TextBox txtAddRadius;
        private System.Windows.Forms.TextBox txtAddMass;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Button btnAddValueHelp;
        private System.Windows.Forms.TextBox txtAddVelZ;
        private System.Windows.Forms.TextBox txtAddVelY;
        private System.Windows.Forms.TextBox txtAddVelX;
        private System.Windows.Forms.TextBox txtAddPosZ;
        private System.Windows.Forms.Button btnAddBodyObj;
        private System.Windows.Forms.BindingSource multibodySystemBindingSource;
        private System.Windows.Forms.Panel panelMenuSaveLoad;
        private System.Windows.Forms.Button btnSaveSystem;
        private System.Windows.Forms.Button btnSaveLoad;
        private System.Windows.Forms.Button btnLoadSystem;
        private System.Windows.Forms.SplitContainer splitMenuSystemDetails;
        private System.Windows.Forms.Button btnHelpCmZ;
        private System.Windows.Forms.Button btnHelpCmY;
        private System.Windows.Forms.Button btnHelpCmX;
        private System.Windows.Forms.Button btnHelpAvgMass;
        private System.Windows.Forms.Button btnHelpTotalMass;
        private System.Windows.Forms.Button btnHelpNetVelZ;
        private System.Windows.Forms.Button btnHelpNetVelY;
        private System.Windows.Forms.Button btnHelpNetVelX;
        private System.Windows.Forms.Label labelNetVelZ;
        private System.Windows.Forms.Label labelNetVelY;
        private System.Windows.Forms.Label labelNetVelX;
        private System.Windows.Forms.Label labelCmZ;
        private System.Windows.Forms.Label labelCmY;
        private System.Windows.Forms.Label labelCmX;
        private System.Windows.Forms.Label labelAvgMass;
        private System.Windows.Forms.Label labelTotalMass;
    }
}