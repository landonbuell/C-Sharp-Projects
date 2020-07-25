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
            this.panelMenuMain = new System.Windows.Forms.Panel();
            this.panelUnitSystems = new System.Windows.Forms.Panel();
            this.radioSolarUnits = new System.Windows.Forms.RadioButton();
            this.radioAstroUnits = new System.Windows.Forms.RadioButton();
            this.radioNaturalUnits = new System.Windows.Forms.RadioButton();
            this.radioSiUnits = new System.Windows.Forms.RadioButton();
            this.btnUnitSystems = new System.Windows.Forms.Button();
            this.panelSystemDetails = new System.Windows.Forms.Panel();
            this.btnSystemDetails = new System.Windows.Forms.Button();
            this.panelMainLogo = new System.Windows.Forms.Panel();
            this.panelMenuRight = new System.Windows.Forms.Panel();
            this.panelTopCenter = new System.Windows.Forms.Panel();
            this.panelMainViewer = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelBottomCenter = new System.Windows.Forms.Panel();
            this.panelAddBody = new System.Windows.Forms.Panel();
            this.btnAddToSystem = new System.Windows.Forms.Button();
            this.panelAddVelocity = new System.Windows.Forms.Panel();
            this.textAddVelocity = new System.Windows.Forms.TextBox();
            this.panelAddPosition = new System.Windows.Forms.Panel();
            this.textAddPosition = new System.Windows.Forms.TextBox();
            this.panelAddRadius = new System.Windows.Forms.Panel();
            this.textAddRadius = new System.Windows.Forms.TextBox();
            this.panelAddMass = new System.Windows.Forms.Panel();
            this.textAddMass = new System.Windows.Forms.TextBox();
            this.panelAddName = new System.Windows.Forms.Panel();
            this.textAddName = new System.Windows.Forms.TextBox();
            this.panelMenuMain.SuspendLayout();
            this.panelUnitSystems.SuspendLayout();
            this.panelMainViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAddBody.SuspendLayout();
            this.panelAddVelocity.SuspendLayout();
            this.panelAddPosition.SuspendLayout();
            this.panelAddRadius.SuspendLayout();
            this.panelAddMass.SuspendLayout();
            this.panelAddName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuMain
            // 
            this.panelMenuMain.Controls.Add(this.panelUnitSystems);
            this.panelMenuMain.Controls.Add(this.btnUnitSystems);
            this.panelMenuMain.Controls.Add(this.panelSystemDetails);
            this.panelMenuMain.Controls.Add(this.btnSystemDetails);
            this.panelMenuMain.Controls.Add(this.panelMainLogo);
            this.panelMenuMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuMain.Location = new System.Drawing.Point(0, 0);
            this.panelMenuMain.Name = "panelMenuMain";
            this.panelMenuMain.Size = new System.Drawing.Size(400, 1327);
            this.panelMenuMain.TabIndex = 0;
            // 
            // panelUnitSystems
            // 
            this.panelUnitSystems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelUnitSystems.Controls.Add(this.radioSolarUnits);
            this.panelUnitSystems.Controls.Add(this.radioAstroUnits);
            this.panelUnitSystems.Controls.Add(this.radioNaturalUnits);
            this.panelUnitSystems.Controls.Add(this.radioSiUnits);
            this.panelUnitSystems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUnitSystems.Location = new System.Drawing.Point(0, 620);
            this.panelUnitSystems.Name = "panelUnitSystems";
            this.panelUnitSystems.Size = new System.Drawing.Size(400, 200);
            this.panelUnitSystems.TabIndex = 4;
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
            this.btnUnitSystems.Location = new System.Drawing.Point(0, 560);
            this.btnUnitSystems.Name = "btnUnitSystems";
            this.btnUnitSystems.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUnitSystems.Size = new System.Drawing.Size(400, 60);
            this.btnUnitSystems.TabIndex = 3;
            this.btnUnitSystems.Text = "Unit Systems";
            this.btnUnitSystems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnitSystems.UseVisualStyleBackColor = false;
            this.btnUnitSystems.Click += new System.EventHandler(this.btnUnitSystems_Click);
            // 
            // panelSystemDetails
            // 
            this.panelSystemDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSystemDetails.Location = new System.Drawing.Point(0, 360);
            this.panelSystemDetails.Name = "panelSystemDetails";
            this.panelSystemDetails.Size = new System.Drawing.Size(400, 200);
            this.panelSystemDetails.TabIndex = 2;
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
            this.panelMenuRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuRight.Location = new System.Drawing.Point(1641, 0);
            this.panelMenuRight.Name = "panelMenuRight";
            this.panelMenuRight.Size = new System.Drawing.Size(200, 1327);
            this.panelMenuRight.TabIndex = 1;
            // 
            // panelTopCenter
            // 
            this.panelTopCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopCenter.Location = new System.Drawing.Point(400, 0);
            this.panelTopCenter.Name = "panelTopCenter";
            this.panelTopCenter.Size = new System.Drawing.Size(1241, 200);
            this.panelTopCenter.TabIndex = 2;
            // 
            // panelMainViewer
            // 
            this.panelMainViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMainViewer.Controls.Add(this.dataGridView1);
            this.panelMainViewer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainViewer.Location = new System.Drawing.Point(400, 200);
            this.panelMainViewer.Name = "panelMainViewer";
            this.panelMainViewer.Size = new System.Drawing.Size(1241, 800);
            this.panelMainViewer.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1241, 800);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelBottomCenter
            // 
            this.panelBottomCenter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomCenter.Location = new System.Drawing.Point(400, 1077);
            this.panelBottomCenter.Name = "panelBottomCenter";
            this.panelBottomCenter.Size = new System.Drawing.Size(1241, 250);
            this.panelBottomCenter.TabIndex = 4;
            // 
            // panelAddBody
            // 
            this.panelAddBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelAddBody.Controls.Add(this.btnAddToSystem);
            this.panelAddBody.Controls.Add(this.panelAddVelocity);
            this.panelAddBody.Controls.Add(this.panelAddPosition);
            this.panelAddBody.Controls.Add(this.panelAddRadius);
            this.panelAddBody.Controls.Add(this.panelAddMass);
            this.panelAddBody.Controls.Add(this.panelAddName);
            this.panelAddBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddBody.Location = new System.Drawing.Point(400, 1000);
            this.panelAddBody.Name = "panelAddBody";
            this.panelAddBody.Size = new System.Drawing.Size(1241, 77);
            this.panelAddBody.TabIndex = 5;
            // 
            // btnAddToSystem
            // 
            this.btnAddToSystem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddToSystem.Location = new System.Drawing.Point(1001, 0);
            this.btnAddToSystem.Name = "btnAddToSystem";
            this.btnAddToSystem.Size = new System.Drawing.Size(240, 77);
            this.btnAddToSystem.TabIndex = 5;
            this.btnAddToSystem.Text = "Add to System";
            this.btnAddToSystem.UseVisualStyleBackColor = true;
            this.btnAddToSystem.Click += new System.EventHandler(this.btnAddToSystem_Click);
            // 
            // panelAddVelocity
            // 
            this.panelAddVelocity.Controls.Add(this.textAddVelocity);
            this.panelAddVelocity.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAddVelocity.Location = new System.Drawing.Point(800, 0);
            this.panelAddVelocity.Name = "panelAddVelocity";
            this.panelAddVelocity.Size = new System.Drawing.Size(200, 77);
            this.panelAddVelocity.TabIndex = 4;
            // 
            // textAddVelocity
            // 
            this.textAddVelocity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textAddVelocity.Location = new System.Drawing.Point(0, 42);
            this.textAddVelocity.MaxLength = 64;
            this.textAddVelocity.Name = "textAddVelocity";
            this.textAddVelocity.Size = new System.Drawing.Size(200, 35);
            this.textAddVelocity.TabIndex = 0;
            this.textAddVelocity.Text = "0,0,0";
            // 
            // panelAddPosition
            // 
            this.panelAddPosition.Controls.Add(this.textAddPosition);
            this.panelAddPosition.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAddPosition.Location = new System.Drawing.Point(600, 0);
            this.panelAddPosition.Name = "panelAddPosition";
            this.panelAddPosition.Size = new System.Drawing.Size(200, 77);
            this.panelAddPosition.TabIndex = 3;
            // 
            // textAddPosition
            // 
            this.textAddPosition.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textAddPosition.Location = new System.Drawing.Point(0, 42);
            this.textAddPosition.MaxLength = 64;
            this.textAddPosition.Name = "textAddPosition";
            this.textAddPosition.Size = new System.Drawing.Size(200, 35);
            this.textAddPosition.TabIndex = 0;
            this.textAddPosition.Text = "0,0,0";
            // 
            // panelAddRadius
            // 
            this.panelAddRadius.Controls.Add(this.textAddRadius);
            this.panelAddRadius.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAddRadius.Location = new System.Drawing.Point(400, 0);
            this.panelAddRadius.Name = "panelAddRadius";
            this.panelAddRadius.Size = new System.Drawing.Size(200, 77);
            this.panelAddRadius.TabIndex = 2;
            // 
            // textAddRadius
            // 
            this.textAddRadius.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textAddRadius.Location = new System.Drawing.Point(0, 42);
            this.textAddRadius.MaxLength = 64;
            this.textAddRadius.Name = "textAddRadius";
            this.textAddRadius.Size = new System.Drawing.Size(200, 35);
            this.textAddRadius.TabIndex = 0;
            this.textAddRadius.Text = "1";
            // 
            // panelAddMass
            // 
            this.panelAddMass.Controls.Add(this.textAddMass);
            this.panelAddMass.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAddMass.Location = new System.Drawing.Point(200, 0);
            this.panelAddMass.Name = "panelAddMass";
            this.panelAddMass.Size = new System.Drawing.Size(200, 77);
            this.panelAddMass.TabIndex = 1;
            // 
            // textAddMass
            // 
            this.textAddMass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textAddMass.Location = new System.Drawing.Point(0, 42);
            this.textAddMass.MaxLength = 64;
            this.textAddMass.Name = "textAddMass";
            this.textAddMass.Size = new System.Drawing.Size(200, 35);
            this.textAddMass.TabIndex = 0;
            this.textAddMass.Text = "1";
            // 
            // panelAddName
            // 
            this.panelAddName.Controls.Add(this.textAddName);
            this.panelAddName.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAddName.Location = new System.Drawing.Point(0, 0);
            this.panelAddName.Name = "panelAddName";
            this.panelAddName.Size = new System.Drawing.Size(200, 77);
            this.panelAddName.TabIndex = 0;
            // 
            // textAddName
            // 
            this.textAddName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textAddName.Location = new System.Drawing.Point(0, 42);
            this.textAddName.MaxLength = 64;
            this.textAddName.Name = "textAddName";
            this.textAddName.Size = new System.Drawing.Size(200, 35);
            this.textAddName.TabIndex = 0;
            this.textAddName.Text = "Alpha";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1841, 1327);
            this.Controls.Add(this.panelAddBody);
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
            this.panelUnitSystems.ResumeLayout(false);
            this.panelMainViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAddBody.ResumeLayout(false);
            this.panelAddVelocity.ResumeLayout(false);
            this.panelAddVelocity.PerformLayout();
            this.panelAddPosition.ResumeLayout(false);
            this.panelAddPosition.PerformLayout();
            this.panelAddRadius.ResumeLayout(false);
            this.panelAddRadius.PerformLayout();
            this.panelAddMass.ResumeLayout(false);
            this.panelAddMass.PerformLayout();
            this.panelAddName.ResumeLayout(false);
            this.panelAddName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuMain;
        private System.Windows.Forms.Button btnSystemDetails;
        private System.Windows.Forms.Panel panelMainLogo;
        private System.Windows.Forms.Panel panelSystemDetails;
        private System.Windows.Forms.Panel panelUnitSystems;
        private System.Windows.Forms.Button btnUnitSystems;
        private System.Windows.Forms.Panel panelMenuRight;
        private System.Windows.Forms.RadioButton radioSolarUnits;
        private System.Windows.Forms.RadioButton radioAstroUnits;
        private System.Windows.Forms.RadioButton radioNaturalUnits;
        private System.Windows.Forms.RadioButton radioSiUnits;
        private System.Windows.Forms.Panel panelTopCenter;
        private System.Windows.Forms.Panel panelMainViewer;
        private System.Windows.Forms.Panel panelBottomCenter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelAddBody;
        private System.Windows.Forms.Button btnAddToSystem;
        private System.Windows.Forms.Panel panelAddVelocity;
        private System.Windows.Forms.TextBox textAddVelocity;
        private System.Windows.Forms.Panel panelAddPosition;
        private System.Windows.Forms.TextBox textAddPosition;
        private System.Windows.Forms.Panel panelAddRadius;
        private System.Windows.Forms.TextBox textAddRadius;
        private System.Windows.Forms.Panel panelAddMass;
        private System.Windows.Forms.TextBox textAddMass;
        private System.Windows.Forms.Panel panelAddName;
        private System.Windows.Forms.TextBox textAddName;
    }
}