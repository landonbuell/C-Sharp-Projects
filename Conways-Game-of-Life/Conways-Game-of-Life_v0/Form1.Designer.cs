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
            this.panelMenuLeft = new System.Windows.Forms.Panel();
            this.panelSaveLoad = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.panelSeedPresets = new System.Windows.Forms.Panel();
            this.btnSeed6 = new System.Windows.Forms.Button();
            this.btnSeed5 = new System.Windows.Forms.Button();
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
            this.numericNgens = new System.Windows.Forms.NumericUpDown();
            this.numericNcols = new System.Windows.Forms.NumericUpDown();
            this.numericNrows = new System.Windows.Forms.NumericUpDown();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelMainLogo = new System.Windows.Forms.Panel();
            this.panelMenuRight = new System.Windows.Forms.Panel();
            this.panelMenuTop = new System.Windows.Forms.Panel();
            this.panelMenuBottom = new System.Windows.Forms.Panel();
            this.panelMenuLeft.SuspendLayout();
            this.panelSaveLoad.SuspendLayout();
            this.panelSeedPresets.SuspendLayout();
            this.panelMenuSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMenuSettings)).BeginInit();
            this.splitMenuSettings.Panel1.SuspendLayout();
            this.splitMenuSettings.Panel2.SuspendLayout();
            this.splitMenuSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNgens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNcols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNrows)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLeft
            // 
            this.panelMenuLeft.AutoScroll = true;
            this.panelMenuLeft.Controls.Add(this.panelSaveLoad);
            this.panelMenuLeft.Controls.Add(this.btnLoadSettings);
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
            // panelSaveLoad
            // 
            this.panelSaveLoad.Controls.Add(this.btnLoad);
            this.panelSaveLoad.Controls.Add(this.btnSave);
            this.panelSaveLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSaveLoad.Location = new System.Drawing.Point(0, 880);
            this.panelSaveLoad.Name = "panelSaveLoad";
            this.panelSaveLoad.Size = new System.Drawing.Size(300, 100);
            this.panelSaveLoad.TabIndex = 6;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Gray;
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Location = new System.Drawing.Point(0, 50);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnLoad.Size = new System.Drawing.Size(300, 50);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Settings";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(300, 50);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Settings";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoadSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoadSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLoadSettings.Location = new System.Drawing.Point(0, 820);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnLoadSettings.Size = new System.Drawing.Size(300, 60);
            this.btnLoadSettings.TabIndex = 5;
            this.btnLoadSettings.Text = "Save/Load Settings";
            this.btnLoadSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadSettings.UseVisualStyleBackColor = false;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // panelSeedPresets
            // 
            this.panelSeedPresets.Controls.Add(this.btnSeed6);
            this.panelSeedPresets.Controls.Add(this.btnSeed5);
            this.panelSeedPresets.Controls.Add(this.btnSeed4);
            this.panelSeedPresets.Controls.Add(this.btnSeed3);
            this.panelSeedPresets.Controls.Add(this.btnSeed2);
            this.panelSeedPresets.Controls.Add(this.btnSeed1);
            this.panelSeedPresets.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeedPresets.Location = new System.Drawing.Point(0, 520);
            this.panelSeedPresets.Name = "panelSeedPresets";
            this.panelSeedPresets.Size = new System.Drawing.Size(300, 300);
            this.panelSeedPresets.TabIndex = 4;
            // 
            // btnSeed6
            // 
            this.btnSeed6.BackColor = System.Drawing.Color.Gray;
            this.btnSeed6.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeed6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeed6.Location = new System.Drawing.Point(0, 250);
            this.btnSeed6.Name = "btnSeed6";
            this.btnSeed6.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnSeed6.Size = new System.Drawing.Size(300, 50);
            this.btnSeed6.TabIndex = 5;
            this.btnSeed6.Text = "Seed 6";
            this.btnSeed6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeed6.UseVisualStyleBackColor = false;
            // 
            // btnSeed5
            // 
            this.btnSeed5.BackColor = System.Drawing.Color.Gray;
            this.btnSeed5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeed5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeed5.Location = new System.Drawing.Point(0, 200);
            this.btnSeed5.Name = "btnSeed5";
            this.btnSeed5.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnSeed5.Size = new System.Drawing.Size(300, 50);
            this.btnSeed5.TabIndex = 4;
            this.btnSeed5.Text = "Seed 5";
            this.btnSeed5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeed5.UseVisualStyleBackColor = false;
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
            // numericNgens
            // 
            this.numericNgens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericNgens.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.numericNgens.Size = new System.Drawing.Size(71, 48);
            this.numericNgens.TabIndex = 2;
            this.numericNgens.ThousandsSeparator = true;
            this.numericNgens.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericNcols
            // 
            this.numericNcols.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericNcols.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericNcols.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNcols.Location = new System.Drawing.Point(0, 48);
            this.numericNcols.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericNcols.Name = "numericNcols";
            this.numericNcols.Size = new System.Drawing.Size(71, 48);
            this.numericNcols.TabIndex = 1;
            this.numericNcols.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericNrows
            // 
            this.numericNrows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericNrows.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericNrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNrows.Location = new System.Drawing.Point(0, 0);
            this.numericNrows.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericNrows.Name = "numericNrows";
            this.numericNrows.Size = new System.Drawing.Size(71, 48);
            this.numericNrows.TabIndex = 0;
            this.numericNrows.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
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
            this.panelMenuRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuRight.Location = new System.Drawing.Point(1378, 0);
            this.panelMenuRight.Name = "panelMenuRight";
            this.panelMenuRight.Size = new System.Drawing.Size(200, 1144);
            this.panelMenuRight.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1578, 1144);
            this.Controls.Add(this.panelMenuBottom);
            this.Controls.Add(this.panelMenuTop);
            this.Controls.Add(this.panelMenuRight);
            this.Controls.Add(this.panelMenuLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenuLeft.ResumeLayout(false);
            this.panelSaveLoad.ResumeLayout(false);
            this.panelSeedPresets.ResumeLayout(false);
            this.panelMenuSettings.ResumeLayout(false);
            this.splitMenuSettings.Panel1.ResumeLayout(false);
            this.splitMenuSettings.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMenuSettings)).EndInit();
            this.splitMenuSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericNgens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNcols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNrows)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericNrows;
        private System.Windows.Forms.Panel panelSeedPresets;
        private System.Windows.Forms.Button btnSeed6;
        private System.Windows.Forms.Button btnSeed5;
        private System.Windows.Forms.Button btnSeed4;
        private System.Windows.Forms.Button btnSeed3;
        private System.Windows.Forms.Button btnSeed2;
        private System.Windows.Forms.Button btnSeed1;
        private System.Windows.Forms.Panel panelSaveLoad;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.NumericUpDown numericNgens;
        private System.Windows.Forms.NumericUpDown numericNcols;
    }
}

