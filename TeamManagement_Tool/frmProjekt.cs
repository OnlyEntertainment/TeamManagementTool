using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamManagement_Tool
{
    public partial class frmProjekt : Form
    {
        public frmProjekt()
        {
            InitializeComponent();
        }
        public bool shouldSave = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            shouldSave = true;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbNotiz_TextChanged(object sender, EventArgs e)
        {
           lblCharCount.Text = tbNotiz.Text.Length.ToString() + " / " + tbNotiz.MaxLength.ToString();
        }

       
    }
}
