namespace Conways_Game_of_Life_v0
{
    partial class Form1
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
            this.panelMenuLeft = new System.Windows.Forms.Panel();
            this.panelSeedPresets = new System.Windows.Forms.Panel();
            this.btnSeed4 = new System.Windows.Forms.Button();
            this.btnSeed3 = new System.Windows.Forms.Button();
            this.btnSeed2 = new System.Windows.Forms.Button();
            this.btnSeed1 = new System.Windows.Forms.Button();
            this.btnSeedPresets = new System.Windows.Forms.Button();
            this.panelMenuSettings = new System.Windows.Forms.Panel();
            this.splitMenuSettings = new System.Windows.Forms.SplitContainer();
            this.btnSetGens = new System.Windows.Forms.Button();
            this.btnSetCols = new System.Windows.Forms.Button();
            this.btnSetRows = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelMainLogo = new System.Windows.Forms.Panel();
            this.panelMenuRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenuTop = new System.Windows.Forms.Panel();
            this.panelMenuBottom = new System.Windows.Forms.Panel();
            this.panelMainGameBoard = new System.Windows.Forms.Panel();
            this.dataGameBoard = new System.Windows.Forms.DataGridView();
            this.numericNrows = new System.Windows.Forms.NumericUpDown();
            this.numericNcols = new System.Windows.Forms.NumericUpDown();
            this.numericNgens = new System.Windows.Forms.NumericUpDown();
            this.btnRandomSeed = new System.Windows.Forms.Button();
            this.panelRandomSeed = new System.Windows.Forms.Panel();
            this.splitRandomSeed = new System.Windows.Forms.SplitContainer();
            this.btnNcells = new System.Windows.Forms.Button();
            this.numericRandomCellCnt = new System.Windows.Forms.NumericUpDown();
            this.btnGenRandomCells = new System.Windows.Forms.Button();
            this.btnSaveLoad = new System.Windows.Forms.Button();
            this.panelSaveLoad = new System.Windows.Forms.Panel();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelMenuLeft.SuspendLayout();
            this.panelSeedPresets.SuspendLayout();
            this.panelMenuSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMenuSettings)).BeginInit();
            this.splitMenuSettings.Panel1.SuspendLayout();
            this.splitMenuSettings.Panel2.SuspendLayout();
            this.splitMenuSettings.SuspendLayout();
            this.panelMenuRight.SuspendLayout();
            this.panelMainGameBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGameBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNrows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNcols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNgens)).BeginInit();
            this.panelRandomSeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRandomSeed)).BeginInit();
            this.splitRandomSeed.Panel1.SuspendLayout();
            this.splitRandomSeed.Panel2.SuspendLayout();
            this.splitRandomSeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRandomCellCnt)).BeginInit();
            this.panelSaveLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLeft
            // 
            this.panelMenuLeft.AutoScroll = true;
            this.panelMenuLeft.Controls.Add(this.panelSaveLoad);
            this.panelMenuLeft.Controls.Add(this.btnSaveLoad);
            this.panelMenuLeft.Controls.Add(this.panelRandomSeed);
            this.panelMenuLeft.Controls.Add(this.btnRandomSeed);
            this.panelMenuLeft.Controls.Add(this.panelSeedPresets);
            this.panelMenuLeft.Controls.Add(this.btnSeedPresets);
            this.panelMenuLeft.Controls.Add(this.panelMenuSettings);
            this.panelMenuLeft.Controls.Add(this.btnSettings);
            this.panelMenuLeft.Controls.Add(this.panelMainLogo);
            this.panelMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLeft.Name = "panelMenuLeft";
            this.panelMenuLeft.Size = new System.Drawing.Size(300, 1144);
            this.panelMenuLeft.TabIndex = 0;
            // 
            // panelSeedPresets
            // 
            this.panelSeedPresets.Controls.Add(this.btnSeed4);
            this.panelSeedPresets.Controls.Add(this.btnSeed3);
            this.panelSeedPresets.Controls.Add(this.btnSeed2);
            this.panelSeedPresets.Controls.Add(this.btnSeed1);
            this.panelSeedPresets.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeedPresets.Location = new System.Drawing.Point(0, 520);
            this.panelSeedPresets.Name = "panelSeedPresets";
            this.panelSeedPresets.Size = new System.Drawing.Size(300, 200);
            this.panelSeedPresets.TabIndex = 4;
            // 
            // btnSeed4
            // 
            this.btnSeed4.BackColor = System.Drawing.Color.Gray;
            this.btnSeed4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeed4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeed4.Location = new System.Drawing.Point(0, 150);
            this.btnSeed4.Name = "btnSeed4";
            this.btnSeed4.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnSeed4.Size = new System.Drawing.Size(300, 50);
            this.btnSeed4.TabIndex = 3;
            this.btnSeed4.Text = "Seed 4";
            this.btnSeed4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeed4.UseVisualStyleBackColor = false;
            // 
            // btnSeed3
            // 
            this.btnSeed3.BackColor = System.Drawing.Color.Gray;
            this.btnSeed3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeed3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeed3.Location = new System.Drawing.Point(0, 100);
            this.btnSeed3.Name = "btnSeed3";
            this.btnSeed3.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnSeed3.Size = new System.Drawing.Size(300, 50);
            this.btnSeed3.TabIndex = 2;
            this.btnSeed3.Text = "Seed 3";
            this.btnSeed3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeed3.UseVisualStyleBackColor = false;
            // 
            // btnSeed2
            // 
            this.btnSeed2.BackColor = System.Drawing.Color.Gray;
            this.btnSeed2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeed2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeed2.Location = new System.Drawing.Point(0, 50);
            this.btnSeed2.Name = "btnSeed2";
            this.btnSeed2.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnSeed2.Size = new System.Drawing.Size(300, 50);
            this.btnSeed2.TabIndex = 1;
            this.btnSeed2.Text = "Seed 2";
            this.btnSeed2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeed2.UseVisualStyleBackColor = false;
            // 
            // btnSeed1
            // 
            this.btnSeed1.BackColor = System.Drawing.Color.Gray;
            this.btnSeed1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeed1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeed1.Location = new System.Drawing.Point(0, 0);
            this.btnSeed1.Name = "btnSeed1";
            this.btnSeed1.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnSeed1.Size = new System.Drawing.Size(300, 50);
            this.btnSeed1.TabIndex = 0;
            this.btnSeed1.Text = "Seed 1";
            this.btnSeed1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeed1.UseVisualStyleBackColor = false;
            // 
            // btnSeedPresets
            // 
            this.btnSeedPresets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeedPresets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeedPresets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeedPresets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSeedPresets.Location = new System.Drawing.Point(0, 460);
            this.btnSeedPresets.Name = "btnSeedPresets";
            this.btnSeedPresets.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSeedPresets.Size = new System.Drawing.Size(300, 60);
            this.btnSeedPresets.TabIndex = 3;
            this.btnSeedPresets.Text = "Seed Presets";
            this.btnSeedPresets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeedPresets.UseVisualStyleBackColor = false;
            this.btnSeedPresets.Click += new System.EventHandler(this.btnSeedPresets_Click);
            // 
            // panelMenuSettings
            // 
            this.panelMenuSettings.Controls.Add(this.splitMenuSettings);
            this.panelMenuSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuSettings.Location = new System.Drawing.Point(0, 310);
            this.panelMenuSettings.Name = "panelMenuSettings";
            this.panelMenuSettings.Size = new System.Drawing.Size(300, 150);
            this.panelMenuSettings.TabIndex = 2;
            // 
            // splitMenuSettings
            // 
            this.splitMenuSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitMenuSettings.Location = new System.Drawing.Point(0, 0);
            this.splitMenuSettings.Name = "splitMenuSettings";
            // 
            // splitMenuSettings.Panel1
            // 
            this.splitMenuSettings.Panel1.Controls.Add(this.btnSetGens);
            this.splitMenuSettings.Panel1.Controls.Add(this.btnSetCols);
            this.splitMenuSettings.Panel1.Controls.Add(this.btnSetRows);
            // 
            // splitMenuSettings.Panel2
            // 
            this.splitMenuSettings.Panel2.Controls.Add(this.numericNgens);
            this.splitMenuSettings.Panel2.Controls.Add(this.numericNcols);
            this.splitMenuSettings.Panel2.Controls.Add(this.numericNrows);
            this.splitMenuSettings.Size = new System.Drawing.Size(300, 150);
            this.splitMenuSettings.SplitterDistance = 225;
            this.splitMenuSettings.TabIndex = 0;
            // 
            // btnSetGens
            // 
            this.btnSetGens.BackColor = System.Drawing.Color.Gray;
            this.btnSetGens.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetGens.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetGens.ForeColor = System.Drawing.Color.Black;
            this.btnSetGens.Location = new System.Drawing.Point(0, 100);
            this.btnSetGens.Name = "btnSetGens";
            this.btnSetGens.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSetGens.Size = new System.Drawing.Size(225, 50);
            this.btnSetGens.TabIndex = 2;
            this.btnSetGens.Text = "Set Generations";
            this.btnSetGens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetGens.UseVisualStyleBackColor = false;
            this.btnSetGens.Click += new System.EventHandler(this.btnSetGens_Click);
            // 
            // btnSetCols
            // 
            this.btnSetCols.BackColor = System.Drawing.Color.Gray;
            this.btnSetCols.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetCols.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetCols.ForeColor = System.Drawing.Color.Black;
            this.btnSetCols.Location = new System.Drawing.Point(0, 50);
            this.btnSetCols.Name = "btnSetCols";
            this.btnSetCols.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSetCols.Size = new System.Drawing.Size(225, 50);
            this.btnSetCols.TabIndex = 1;
            this.btnSetCols.Text = "Set Columns";
            this.btnSetCols.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetCols.UseVisualStyleBackColor = false;
            this.btnSetCols.Click += new System.EventHandler(this.btnSetCols_Click);
            // 
            // btnSetRows
            // 
            this.btnSetRows.BackColor = System.Drawing.Color.Gray;
            this.btnSetRows.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetRows.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetRows.ForeColor = System.Drawing.Color.Black;
            this.btnSetRows.Location = new System.Drawing.Point(0, 0);
            this.btnSetRows.Name = "btnSetRows";
            this.btnSetRows.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSetRows.Size = new System.Drawing.Size(225, 50);
            this.btnSetRows.TabIndex = 0;
            this.btnSetRows.Text = "Set Rows";
            this.btnSetRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetRows.UseVisualStyleBackColor = false;
            this.btnSetRows.Click += new System.EventHandler(this.btnSetRows_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSettings.Location = new System.Drawing.Point(0, 250);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(300, 60);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panelMainLogo
            // 
            this.panelMainLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainLogo.Location = new System.Drawing.Point(0, 0);
            this.panelMainLogo.Name = "panelMainLogo";
            this.panelMainLogo.Size = new System.Drawing.Size(300, 250);
            this.panelMainLogo.TabIndex = 0;
            // 
            // panelMenuRight
            // 
            this.panelMenuRight.Controls.Add(this.panel1);
            this.panelMenuRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuRight.Location = new System.Drawing.Point(1378, 0);
            this.panelMenuRight.Name = "panelMenuRight";
            this.panelMenuRight.Size = new System.Drawing.Size(200, 1144);
            this.panelMenuRight.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 250);
            this.panel1.TabIndex = 0;
            // 
            // panelMenuTop
            // 
            this.panelMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuTop.Location = new System.Drawing.Point(300, 0);
            this.panelMenuTop.Name = "panelMenuTop";
            this.panelMenuTop.Size = new System.Drawing.Size(1078, 100);
            this.panelMenuTop.TabIndex = 2;
            // 
            // panelMenuBottom
            // 
            this.panelMenuBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenuBottom.Location = new System.Drawing.Point(300, 1044);
            this.panelMenuBottom.Name = "panelMenuBottom";
            this.panelMenuBottom.Size = new System.Drawing.Size(1078, 100);
            this.panelMenuBottom.TabIndex = 3;
            // 
            // panelMainGameBoard
            // 
            this.panelMainGameBoard.Controls.Add(this.dataGameBoard);
            this.panelMainGameBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainGameBoard.Location = new System.Drawing.Point(300, 100);
            this.panelMainGameBoard.Name = "panelMainGameBoard";
            this.panelMainGameBoard.Size = new System.Drawing.Size(1078, 944);
            this.panelMainGameBoard.TabIndex = 4;
            // 
            // dataGameBoard
            // 
            this.dataGameBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGameBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGameBoard.Location = new System.Drawing.Point(0, 0);
            this.dataGameBoard.Name = "dataGameBoard";
            this.dataGameBoard.RowHeadersWidth = 62;
            this.dataGameBoard.RowTemplate.Height = 28;
            this.dataGameBoard.Size = new System.Drawing.Size(1078, 944);
            this.dataGameBoard.TabIndex = 0;
            // 
            // numericNrows
            // 
            this.numericNrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNrows.Location = new System.Drawing.Point(0, 2);
            this.numericNrows.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericNrows.Name = "numericNrows";
            this.numericNrows.Size = new System.Drawing.Size(70, 48);
            this.numericNrows.TabIndex = 0;
            this.numericNrows.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericNcols
            // 
            this.numericNcols.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNcols.Location = new System.Drawing.Point(0, 52);
            this.numericNcols.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericNcols.Name = "numericNcols";
            this.numericNcols.Size = new System.Drawing.Size(70, 48);
            this.numericNcols.TabIndex = 1;
            this.numericNcols.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericNgens
            // 
            this.numericNgens.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNgens.Location = new System.Drawing.Point(0, 102);
            this.numericNgens.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericNgens.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNgens.Name = "numericNgens";
            this.numericNgens.Size = new System.Drawing.Size(70, 48);
            this.numericNgens.TabIndex = 2;
            this.numericNgens.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnRandomSeed
            // 
            this.btnRandomSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRandomSeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRandomSeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRandomSeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRandomSeed.Location = new System.Drawing.Point(0, 720);
            this.btnRandomSeed.Name = "btnRandomSeed";
            this.btnRandomSeed.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnRandomSeed.Size = new System.Drawing.Size(300, 60);
            this.btnRandomSeed.TabIndex = 7;
            this.btnRandomSeed.Text = "Random Seed !";
            this.btnRandomSeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandomSeed.UseVisualStyleBackColor = false;
            this.btnRandomSeed.Click += new System.EventHandler(this.btnRandomSeed_Click);
            // 
            // panelRandomSeed
            // 
            this.panelRandomSeed.Controls.Add(this.btnGenRandomCells);
            this.panelRandomSeed.Controls.Add(this.splitRandomSeed);
            this.panelRandomSeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRandomSeed.Location = new System.Drawing.Point(0, 780);
            this.panelRandomSeed.Name = "panelRandomSeed";
            this.panelRandomSeed.Size = new System.Drawing.Size(300, 100);
            this.panelRandomSeed.TabIndex = 8;
            // 
            // splitRandomSeed
            // 
            this.splitRandomSeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitRandomSeed.Location = new System.Drawing.Point(0, 0);
            this.splitRandomSeed.Name = "splitRandomSeed";
            // 
            // splitRandomSeed.Panel1
            // 
            this.splitRandomSeed.Panel1.Controls.Add(this.btnNcells);
            // 
            // splitRandomSeed.Panel2
            // 
            this.splitRandomSeed.Panel2.Controls.Add(this.numericRandomCellCnt);
            this.splitRandomSeed.Size = new System.Drawing.Size(300, 50);
            this.splitRandomSeed.SplitterDistance = 225;
            this.splitRandomSeed.TabIndex = 0;
            // 
            // btnNcells
            // 
            this.btnNcells.BackColor = System.Drawing.Color.Gray;
            this.btnNcells.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNcells.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNcells.ForeColor = System.Drawing.Color.Black;
            this.btnNcells.Location = new System.Drawing.Point(0, 0);
            this.btnNcells.Name = "btnNcells";
            this.btnNcells.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNcells.Size = new System.Drawing.Size(225, 50);
            this.btnNcells.TabIndex = 1;
            this.btnNcells.Text = "Set Cell Num.";
            this.btnNcells.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNcells.UseVisualStyleBackColor = false;
            // 
            // numericRandomCellCnt
            // 
            this.numericRandomCellCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericRandomCellCnt.Location = new System.Drawing.Point(0, 1);
            this.numericRandomCellCnt.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericRandomCellCnt.Name = "numericRandomCellCnt";
            this.numericRandomCellCnt.Size = new System.Drawing.Size(70, 48);
            this.numericRandomCellCnt.TabIndex = 1;
            this.numericRandomCellCnt.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnGenRandomCells
            // 
            this.btnGenRandomCells.BackColor = System.Drawing.Color.Gray;
            this.btnGenRandomCells.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenRandomCells.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenRandomCells.Location = new System.Drawing.Point(0, 50);
            this.btnGenRandomCells.Name = "btnGenRandomCells";
            this.btnGenRandomCells.Size = new System.Drawing.Size(300, 50);
            this.btnGenRandomCells.TabIndex = 4;
            this.btnGenRandomCells.Text = "Generate";
            this.btnGenRandomCells.UseVisualStyleBackColor = false;
            // 
            // btnSaveLoad
            // 
            this.btnSaveLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveLoad.Location = new System.Drawing.Point(0, 880);
            this.btnSaveLoad.Name = "btnSaveLoad";
            this.btnSaveLoad.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSaveLoad.Size = new System.Drawing.Size(300, 60);
            this.btnSaveLoad.TabIndex = 9;
            this.btnSaveLoad.Text = "Save/Load Settings";
            this.btnSaveLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveLoad.UseVisualStyleBackColor = false;
            this.btnSaveLoad.Click += new System.EventHandler(this.btnSaveLoad_Click);
            // 
            // panelSaveLoad
            // 
            this.panelSaveLoad.Controls.Add(this.btnLoadSettings);
            this.panelSaveLoad.Controls.Add(this.btnSaveSettings);
            this.panelSaveLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSaveLoad.Location = new System.Drawing.Point(0, 940);
            this.panelSaveLoad.Name = "panelSaveLoad";
            this.panelSaveLoad.Size = new System.Drawing.Size(300, 100);
            this.panelSaveLoad.TabIndex = 10;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.Gray;
            this.btnSaveSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveSettings.Location = new System.Drawing.Point(0, 0);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnSaveSettings.Size = new System.Drawing.Size(300, 50);
            this.btnSaveSettings.TabIndex = 1;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.BackColor = System.Drawing.Color.Gray;
            this.btnLoadSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoadSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadSettings.Location = new System.Drawing.Point(0, 50);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnLoadSettings.Size = new System.Drawing.Size(300, 50);
            this.btnLoadSettings.TabIndex = 2;
            this.btnLoadSettings.Text = "Load Settings";
            this.btnLoadSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadSettings.UseVisualStyleBackColor = false;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Conways_Game_of_Life_v0.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1578, 1144);
            this.Controls.Add(this.panelMainGameBoard);
            this.Controls.Add(this.panelMenuBottom);
            this.Controls.Add(this.panelMenuTop);
            this.Controls.Add(this.panelMenuRight);
            this.Controls.Add(this.panelMenuLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenuLeft.ResumeLayout(false);
            this.panelSeedPresets.ResumeLayout(false);
            this.panelMenuSettings.ResumeLayout(false);
            this.splitMenuSettings.Panel1.ResumeLayout(false);
            this.splitMenuSettings.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMenuSettings)).EndInit();
            this.splitMenuSettings.ResumeLayout(false);
            this.panelMenuRight.ResumeLayout(false);
            this.panelMainGameBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGameBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNrows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNcols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNgens)).EndInit();
            this.panelRandomSeed.ResumeLayout(false);
            this.splitRandomSeed.Panel1.ResumeLayout(false);
            this.splitRandomSeed.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRandomSeed)).EndInit();
            this.splitRandomSeed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericRandomCellCnt)).EndInit();
            this.panelSaveLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLeft;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelMainLogo;
        private System.Windows.Forms.Panel panelMenuRight;
        private System.Windows.Forms.Panel panelMenuTop;
        private System.Windows.Forms.Panel panelMenuBottom;
        private System.Windows.Forms.Button btnSeedPresets;
        private System.Windows.Forms.Panel panelMenuSettings;
        private System.Windows.Forms.SplitContainer splitMenuSettings;
        private System.Windows.Forms.Button btnSetGens;
        private System.Windows.Forms.Button btnSetCols;
        private System.Windows.Forms.Button btnSetRows;
        private System.Windows.Forms.Panel panelSeedPresets;
        private System.Windows.Forms.Button btnSeed4;
        private System.Windows.Forms.Button btnSeed3;
        private System.Windows.Forms.Button btnSeed2;
        private System.Windows.Forms.Button btnSeed1;
        private System.Windows.Forms.Panel panelMainGameBoard;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridView dataGameBoard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericNgens;
        private System.Windows.Forms.NumericUpDown numericNcols;
        private System.Windows.Forms.NumericUpDown numericNrows;
        private System.Windows.Forms.Panel panelRandomSeed;
        private System.Windows.Forms.Button btnGenRandomCells;
        private System.Windows.Forms.SplitContainer splitRandomSeed;
        private System.Windows.Forms.Button btnNcells;
        private System.Windows.Forms.NumericUpDown numericRandomCellCnt;
        private System.Windows.Forms.Button btnRandomSeed;
        private System.Windows.Forms.Panel panelSaveLoad;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnSaveLoad;
    }
}

