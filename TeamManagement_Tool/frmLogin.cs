using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace TeamManagement_Tool
{
    public partial class frmLogin : Form
    {
        TextBox focusedTB = null;

        public frmLogin()
        {
           
           
            InitializeComponent();
        }

        public string textLogin { get { return this.tbLogin.Text; } set { this.tbLogin.Text = value; } }
        public string textPassword { get { return this.tbPassword.Text; } }
        


        public void SetWrongPassword()
        {
            this.tbPassword.Text = "";
            this.tbPassword.BackColor = Color.IndianRed;
            if (this.tbLogin.Text == "")
            { focusedTB = this.tbLogin; }
            else
            { focusedTB = this.tbPassword; }
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            
            if (focusedTB != null)
            {
                focusedTB.Focus();
            }
        }

        private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 || e.KeyChar == (char)10)
            //if (e.KeyChar.ToString() == Keys.Enter.ToString() || e.KeyChar.ToString() == Keys.Return.ToString())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 || e.KeyChar == (char)10)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        
    }
}
