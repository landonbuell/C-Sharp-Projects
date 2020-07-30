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
            this.panelMenuUnitSystems = new System.Windows.Forms.Panel();
            this.radioSolarUnits = new System.Windows.Forms.RadioButton();
            this.radioAstroUnits = new System.Windows.Forms.RadioButton();
            this.radioNaturalUnits = new System.Windows.Forms.RadioButton();
            this.radioSiUnits = new System.Windows.Forms.RadioButton();
            this.btnUnitSystems = new System.Windows.Forms.Button();
            this.panelMenuSystemDetails = new System.Windows.Forms.Panel();
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
            this.dataMainViewer = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRadius = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVelX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVelY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVelZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBottomCenter = new System.Windows.Forms.Panel();
            this.btnSaveLoad = new System.Windows.Forms.Button();
            this.panelMenuSaveLoad = new System.Windows.Forms.Panel();
            this.btnSaveSystem = new System.Windows.Forms.Button();
            this.multibodySystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadSystem = new System.Windows.Forms.Button();
            this.panelMenuMain.SuspendLayout();
            this.panelMenuUnitSystems.SuspendLayout();
            this.panelMenuRight.SuspendLayout();
            this.panelMenuAddBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMenuAddBody)).BeginInit();
            this.splitMenuAddBody.Panel1.SuspendLayout();
            this.splitMenuAddBody.Panel2.SuspendLayout();
            this.splitMenuAddBody.SuspendLayout();
            this.panelMainViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMainViewer)).BeginInit();
            this.panelMenuSaveLoad.SuspendLayout();
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
            this.panelMenuMain.Size = new System.Drawing.Size(400, 1544);
            this.panelMenuMain.TabIndex = 0;
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
            this.panelMenuUnitSystems.Size = new System.Drawing.Size(400, 200);
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
            this.radioSolarUnits.Size = new System.Drawing.Size(400, 50);
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
            this.radioAstroUnits.Size = new System.Drawing.Size(400, 50);
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
            this.radioNaturalUnits.Size = new System.Drawing.Size(400, 50);
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
            this.radioSiUnits.Size = new System.Drawing.Size(400, 50);
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
            this.btnUnitSystems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUnitSystems.Location = new System.Drawing.Point(0, 760);
            this.btnUnitSystems.Name = "btnUnitSystems";
            this.btnUnitSystems.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUnitSystems.Size = new System.Drawing.Size(400, 60);
            this.btnUnitSystems.TabIndex = 3;
            this.btnUnitSystems.Text = "Unit Systems";
            this.btnUnitSystems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnitSystems.UseVisualStyleBackColor = false;
            this.btnUnitSystems.Click += new System.EventHandler(this.btnUnitSystems_Click);
            // 
            // panelMenuSystemDetails
            // 
            this.panelMenuSystemDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuSystemDetails.Location = new System.Drawing.Point(0, 360);
            this.panelMenuSystemDetails.Name = "panelMenuSystemDetails";
            this.panelMenuSystemDetails.Size = new System.Drawing.Size(400, 400);
            this.panelMenuSystemDetails.TabIndex = 2;
            // 
            // btnSystemDetails
            // 
            this.btnSystemDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSystemDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystemDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSystemDetails.Location = new System.Drawing.Point(0, 300);
            this.btnSystemDetails.Name = "btnSystemDetails";
            this.btnSystemDetails.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSystemDetails.Size = new System.Drawing.Size(400, 60);
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
            this.panelMainLogo.Size = new System.Drawing.Size(400, 300);
            this.panelMainLogo.TabIndex = 0;
            // 
            // panelMenuRight
            // 
            this.panelMenuRight.Controls.Add(this.panelMenuAddBody);
            this.panelMenuRight.Controls.Add(this.btnShowAdd);
            this.panelMenuRight.Controls.Add(this.panelTopRight);
            this.panelMenuRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuRight.Location = new System.Drawing.Point(1578, 0);
            this.panelMenuRight.Name = "panelMenuRight";
            this.panelMenuRight.Size = new System.Drawing.Size(400, 1544);
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
            this.panelMenuAddBody.Size = new System.Drawing.Size(400, 500);
            this.panelMenuAddBody.TabIndex = 3;
            // 
            // btnAddBodyObj
            // 
            this.btnAddBodyObj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddBodyObj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddBodyObj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBodyObj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddBodyObj.Location = new System.Drawing.Point(0, 440);
            this.btnAddBodyObj.Name = "btnAddBodyObj";
            this.btnAddBodyObj.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnAddBodyObj.Size = new System.Drawing.Size(400, 60);
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
            this.splitMenuAddBody.Size = new System.Drawing.Size(400, 440);
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
            this.btnHelpVelZ.Location = new System.Drawing.Point(0, 396);
            this.btnHelpVelZ.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpVelZ.Name = "btnHelpVelZ";
            this.btnHelpVelZ.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpVelZ.Size = new System.Drawing.Size(200, 44);
            this.btnHelpVelZ.TabIndex = 31;
            this.btnHelpVelZ.Text = "Z-Velocity";
            this.btnHelpVelZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpVelZ.UseVisualStyleBackColor = false;
            // 
            // btnHelpVelY
            // 
            this.btnHelpVelY.BackColor = System.Drawing.Color.Gray;
            this.btnHelpVelY.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpVelY.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpVelY.FlatAppearance.BorderSize = 0;
            this.btnHelpVelY.ForeColor = System.Drawing.Color.Black;
            this.btnHelpVelY.Location = new System.Drawing.Point(0, 352);
            this.btnHelpVelY.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpVelY.Name = "btnHelpVelY";
            this.btnHelpVelY.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpVelY.Size = new System.Drawing.Size(200, 44);
            this.btnHelpVelY.TabIndex = 30;
            this.btnHelpVelY.Text = "Y-Velocity";
            this.btnHelpVelY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpVelY.UseVisualStyleBackColor = false;
            // 
            // btnHelpVelX
            // 
            this.btnHelpVelX.BackColor = System.Drawing.Color.Gray;
            this.btnHelpVelX.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpVelX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpVelX.FlatAppearance.BorderSize = 0;
            this.btnHelpVelX.ForeColor = System.Drawing.Color.Black;
            this.btnHelpVelX.Location = new System.Drawing.Point(0, 308);
            this.btnHelpVelX.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpVelX.Name = "btnHelpVelX";
            this.btnHelpVelX.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpVelX.Size = new System.Drawing.Size(200, 44);
            this.btnHelpVelX.TabIndex = 29;
            this.btnHelpVelX.Text = "X-Velocity";
            this.btnHelpVelX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpVelX.UseVisualStyleBackColor = false;
            // 
            // btnHelpPosZ
            // 
            this.btnHelpPosZ.BackColor = System.Drawing.Color.Gray;
            this.btnHelpPosZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpPosZ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpPosZ.FlatAppearance.BorderSize = 0;
            this.btnHelpPosZ.ForeColor = System.Drawing.Color.Black;
            this.btnHelpPosZ.Location = new System.Drawing.Point(0, 264);
            this.btnHelpPosZ.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpPosZ.Name = "btnHelpPosZ";
            this.btnHelpPosZ.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpPosZ.Size = new System.Drawing.Size(200, 44);
            this.btnHelpPosZ.TabIndex = 28;
            this.btnHelpPosZ.Text = "Z-Position";
            this.btnHelpPosZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpPosZ.UseVisualStyleBackColor = false;
            // 
            // btnHelpPosY
            // 
            this.btnHelpPosY.BackColor = System.Drawing.Color.Gray;
            this.btnHelpPosY.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpPosY.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpPosY.FlatAppearance.BorderSize = 0;
            this.btnHelpPosY.ForeColor = System.Drawing.Color.Black;
            this.btnHelpPosY.Location = new System.Drawing.Point(0, 220);
            this.btnHelpPosY.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpPosY.Name = "btnHelpPosY";
            this.btnHelpPosY.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpPosY.Size = new System.Drawing.Size(200, 44);
            this.btnHelpPosY.TabIndex = 27;
            this.btnHelpPosY.Text = "Y-Position";
            this.btnHelpPosY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpPosY.UseVisualStyleBackColor = false;
            // 
            // btnHelpPosX
            // 
            this.btnHelpPosX.BackColor = System.Drawing.Color.Gray;
            this.btnHelpPosX.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpPosX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpPosX.FlatAppearance.BorderSize = 0;
            this.btnHelpPosX.ForeColor = System.Drawing.Color.Black;
            this.btnHelpPosX.Location = new System.Drawing.Point(0, 176);
            this.btnHelpPosX.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpPosX.Name = "btnHelpPosX";
            this.btnHelpPosX.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpPosX.Size = new System.Drawing.Size(200, 44);
            this.btnHelpPosX.TabIndex = 26;
            this.btnHelpPosX.Text = "X-Position";
            this.btnHelpPosX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpPosX.UseVisualStyleBackColor = false;
            // 
            // btnHelpRadius
            // 
            this.btnHelpRadius.BackColor = System.Drawing.Color.Gray;
            this.btnHelpRadius.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelpRadius.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelpRadius.FlatAppearance.BorderSize = 0;
            this.btnHelpRadius.ForeColor = System.Drawing.Color.Black;
            this.btnHelpRadius.Location = new System.Drawing.Point(0, 132);
            this.btnHelpRadius.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpRadius.Name = "btnHelpRadius";
            this.btnHelpRadius.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpRadius.Size = new System.Drawing.Size(200, 44);
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
            this.btnHelpMass.Location = new System.Drawing.Point(0, 88);
            this.btnHelpMass.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpMass.Name = "btnHelpMass";
            this.btnHelpMass.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpMass.Size = new System.Drawing.Size(200, 44);
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
            this.btnHelpName.Location = new System.Drawing.Point(0, 44);
            this.btnHelpName.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpName.Name = "btnHelpName";
            this.btnHelpName.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHelpName.Size = new System.Drawing.Size(200, 44);
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
            this.btnAddAttrbHelp.Size = new System.Drawing.Size(200, 44);
            this.btnAddAttrbHelp.TabIndex = 22;
            this.btnAddAttrbHelp.Text = "Attribute";
            this.btnAddAttrbHelp.UseVisualStyleBackColor = true;
            // 
            // txtAddVelZ
            // 
            this.txtAddVelZ.BackColor = System.Drawing.Color.White;
            this.txtAddVelZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddVelZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddVelZ.Location = new System.Drawing.Point(0, 396);
            this.txtAddVelZ.Multiline = true;
            this.txtAddVelZ.Name = "txtAddVelZ";
            this.txtAddVelZ.Size = new System.Drawing.Size(196, 44);
            this.txtAddVelZ.TabIndex = 28;
            this.txtAddVelZ.Text = "0";
            this.txtAddVelZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddVelY
            // 
            this.txtAddVelY.BackColor = System.Drawing.Color.White;
            this.txtAddVelY.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddVelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddVelY.Location = new System.Drawing.Point(0, 352);
            this.txtAddVelY.Multiline = true;
            this.txtAddVelY.Name = "txtAddVelY";
            this.txtAddVelY.Size = new System.Drawing.Size(196, 44);
            this.txtAddVelY.TabIndex = 27;
            this.txtAddVelY.Text = "0";
            this.txtAddVelY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddVelX
            // 
            this.txtAddVelX.BackColor = System.Drawing.Color.White;
            this.txtAddVelX.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddVelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddVelX.Location = new System.Drawing.Point(0, 308);
            this.txtAddVelX.Multiline = true;
            this.txtAddVelX.Name = "txtAddVelX";
            this.txtAddVelX.Size = new System.Drawing.Size(196, 44);
            this.txtAddVelX.TabIndex = 26;
            this.txtAddVelX.Text = "0";
            this.txtAddVelX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddPosZ
            // 
            this.txtAddPosZ.BackColor = System.Drawing.Color.White;
            this.txtAddPosZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddPosZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPosZ.Location = new System.Drawing.Point(0, 264);
            this.txtAddPosZ.Multiline = true;
            this.txtAddPosZ.Name = "txtAddPosZ";
            this.txtAddPosZ.Size = new System.Drawing.Size(196, 44);
            this.txtAddPosZ.TabIndex = 25;
            this.txtAddPosZ.Text = "0";
            this.txtAddPosZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddPosY
            // 
            this.txtAddPosY.BackColor = System.Drawing.Color.White;
            this.txtAddPosY.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPosY.Location = new System.Drawing.Point(0, 220);
            this.txtAddPosY.Multiline = true;
            this.txtAddPosY.Name = "txtAddPosY";
            this.txtAddPosY.Size = new System.Drawing.Size(196, 44);
            this.txtAddPosY.TabIndex = 24;
            this.txtAddPosY.Text = "0";
            this.txtAddPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddPosX
            // 
            this.txtAddPosX.BackColor = System.Drawing.Color.White;
            this.txtAddPosX.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPosX.Location = new System.Drawing.Point(0, 176);
            this.txtAddPosX.Multiline = true;
            this.txtAddPosX.Name = "txtAddPosX";
            this.txtAddPosX.Size = new System.Drawing.Size(196, 44);
            this.txtAddPosX.TabIndex = 23;
            this.txtAddPosX.Text = "0";
            this.txtAddPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddRadius
            // 
            this.txtAddRadius.BackColor = System.Drawing.Color.White;
            this.txtAddRadius.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddRadius.Location = new System.Drawing.Point(0, 132);
            this.txtAddRadius.Multiline = true;
            this.txtAddRadius.Name = "txtAddRadius";
            this.txtAddRadius.Size = new System.Drawing.Size(196, 44);
            this.txtAddRadius.TabIndex = 22;
            this.txtAddRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddMass
            // 
            this.txtAddMass.BackColor = System.Drawing.Color.White;
            this.txtAddMass.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddMass.Location = new System.Drawing.Point(0, 88);
            this.txtAddMass.Multiline = true;
            this.txtAddMass.Name = "txtAddMass";
            this.txtAddMass.Size = new System.Drawing.Size(196, 44);
            this.txtAddMass.TabIndex = 21;
            this.txtAddMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddName
            // 
            this.txtAddName.BackColor = System.Drawing.Color.White;
            this.txtAddName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddName.Location = new System.Drawing.Point(0, 44);
            this.txtAddName.MinimumSize = new System.Drawing.Size(196, 44);
            this.txtAddName.Multiline = true;
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(196, 44);
            this.txtAddName.TabIndex = 20;
            this.txtAddName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddValueHelp
            // 
            this.btnAddValueHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddValueHelp.Location = new System.Drawing.Point(0, 0);
            this.btnAddValueHelp.Name = "btnAddValueHelp";
            this.btnAddValueHelp.Size = new System.Drawing.Size(196, 44);
            this.btnAddValueHelp.TabIndex = 19;
            this.btnAddValueHelp.Text = "Value";
            this.btnAddValueHelp.UseVisualStyleBackColor = true;
            // 
            // btnShowAdd
            // 
            this.btnShowAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.panelMainViewer.Controls.Add(this.dataMainViewer);
            this.panelMainViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainViewer.Location = new System.Drawing.Point(400, 200);
            this.panelMainViewer.Name = "panelMainViewer";
            this.panelMainViewer.Size = new System.Drawing.Size(1178, 1344);
            this.panelMainViewer.TabIndex = 3;
            // 
            // dataMainViewer
            // 
            this.dataMainViewer.AutoGenerateColumns = false;
            this.dataMainViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMainViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMainViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colMass,
            this.colRadius,
            this.colPosX,
            this.colPosY,
            this.colPosZ,
            this.colVelX,
            this.colVelY,
            this.colVelZ});
            this.dataMainViewer.DataSource = this.multibodySystemBindingSource;
            this.dataMainViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMainViewer.Location = new System.Drawing.Point(0, 0);
            this.dataMainViewer.Name = "dataMainViewer";
            this.dataMainViewer.RowHeadersWidth = 20;
            this.dataMainViewer.RowTemplate.Height = 28;
            this.dataMainViewer.Size = new System.Drawing.Size(1178, 1344);
            this.dataMainViewer.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 120;
            this.colName.Name = "colName";
            // 
            // colMass
            // 
            this.colMass.HeaderText = "Mass";
            this.colMass.MinimumWidth = 100;
            this.colMass.Name = "colMass";
            // 
            // colRadius
            // 
            this.colRadius.HeaderText = "Radius";
            this.colRadius.MinimumWidth = 100;
            this.colRadius.Name = "colRadius";
            // 
            // colPosX
            // 
            this.colPosX.HeaderText = "X-Position";
            this.colPosX.MinimumWidth = 100;
            this.colPosX.Name = "colPosX";
            // 
            // colPosY
            // 
            this.colPosY.HeaderText = "Y-Position";
            this.colPosY.MinimumWidth = 100;
            this.colPosY.Name = "colPosY";
            // 
            // colPosZ
            // 
            this.colPosZ.HeaderText = "Z-Position";
            this.colPosZ.MinimumWidth = 100;
            this.colPosZ.Name = "colPosZ";
            // 
            // colVelX
            // 
            this.colVelX.HeaderText = "X-Velocity";
            this.colVelX.MinimumWidth = 100;
            this.colVelX.Name = "colVelX";
            // 
            // colVelY
            // 
            this.colVelY.HeaderText = "Y-Velocity";
            this.colVelY.MinimumWidth = 100;
            this.colVelY.Name = "colVelY";
            // 
            // colVelZ
            // 
            this.colVelZ.HeaderText = "Z-Velocity";
            this.colVelZ.MinimumWidth = 100;
            this.colVelZ.Name = "colVelZ";
            // 
            // panelBottomCenter
            // 
            this.panelBottomCenter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomCenter.Location = new System.Drawing.Point(400, 1444);
            this.panelBottomCenter.Name = "panelBottomCenter";
            this.panelBottomCenter.Size = new System.Drawing.Size(1178, 100);
            this.panelBottomCenter.TabIndex = 4;
            // 
            // btnSaveLoad
            // 
            this.btnSaveLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveLoad.Location = new System.Drawing.Point(0, 1020);
            this.btnSaveLoad.Name = "btnSaveLoad";
            this.btnSaveLoad.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSaveLoad.Size = new System.Drawing.Size(400, 60);
            this.btnSaveLoad.TabIndex = 5;
            this.btnSaveLoad.Text = "Save/Load Data";
            this.btnSaveLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveLoad.UseVisualStyleBackColor = false;
            this.btnSaveLoad.Click += new System.EventHandler(this.btnSaveLoad_Click);
            // 
            // panelMenuSaveLoad
            // 
            this.panelMenuSaveLoad.Controls.Add(this.btnLoadSystem);
            this.panelMenuSaveLoad.Controls.Add(this.btnSaveSystem);
            this.panelMenuSaveLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuSaveLoad.Location = new System.Drawing.Point(0, 1080);
            this.panelMenuSaveLoad.Name = "panelMenuSaveLoad";
            this.panelMenuSaveLoad.Size = new System.Drawing.Size(400, 400);
            this.panelMenuSaveLoad.TabIndex = 6;
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
            this.btnSaveSystem.Size = new System.Drawing.Size(400, 50);
            this.btnSaveSystem.TabIndex = 24;
            this.btnSaveSystem.Text = "Save System";
            this.btnSaveSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSystem.UseVisualStyleBackColor = false;
            // 
            // multibodySystemBindingSource
            // 
            this.multibodySystemBindingSource.DataSource = typeof(Multibody_Simulation_v0.Multibody_System);
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
            this.btnLoadSystem.Size = new System.Drawing.Size(400, 50);
            this.btnLoadSystem.TabIndex = 25;
            this.btnLoadSystem.Text = "Load System";
            this.btnLoadSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadSystem.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1978, 1544);
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
            this.panelMenuUnitSystems.ResumeLayout(false);
            this.panelMenuRight.ResumeLayout(false);
            this.panelMenuAddBody.ResumeLayout(false);
            this.splitMenuAddBody.Panel1.ResumeLayout(false);
            this.splitMenuAddBody.Panel2.ResumeLayout(false);
            this.splitMenuAddBody.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMenuAddBody)).EndInit();
            this.splitMenuAddBody.ResumeLayout(false);
            this.panelMainViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMainViewer)).EndInit();
            this.panelMenuSaveLoad.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataMainViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRadius;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVelX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVelY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVelZ;
        private System.Windows.Forms.Panel panelMenuSaveLoad;
        private System.Windows.Forms.Button btnSaveSystem;
        private System.Windows.Forms.Button btnSaveLoad;
        private System.Windows.Forms.Button btnLoadSystem;
    }
}