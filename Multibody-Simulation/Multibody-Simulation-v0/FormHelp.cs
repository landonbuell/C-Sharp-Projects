using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multibody_Simulation_v0
{
    public partial class FormHelp : Form
    {

        // Init Text Variables to go on Form
        string header, text, footer;

        public FormHelp(string _hdr, string _txt , string _ftr)
        {
            // Constructor for Help Form Object
            InitializeComponent();
            this.header = _hdr;
            this.text = _txt;
            this.footer = _ftr;
            FillLabelBoxes();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            // Hide Active Form Object
            this.Hide();
        }

        private void FormHelp_Load(object sender, EventArgs e)
        {

        }

        private void FillLabelBoxes()
        {
            // Fill Label Boxes with needed Text
            labelHeader.Text = header;
            labelMessageBody.Text = text;
            labelFooter.Text = footer;
        }
    }
}
