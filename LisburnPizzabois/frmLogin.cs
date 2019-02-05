using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LisburnPizzabois
{
    public partial class frmLogin : Form
    {
        //variables 
        public static String sname = "";
        public frmLogin()
        {
             
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDetails();
        }

        public void ClearDetails()
        {
            //local variable to store result
            DialogResult dr;
            //accept response
            dr = MessageBox.Show("Are you sure you want to exit",
                "Confirm exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if yes then close program
            if (dr == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //frmPizza sw = new frmPizza(); Remove comment when frmPizza Load
            this.Hide();
            // sw.Show();
        }

        public void Halt()
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "Pa$$w0rd")
            {
                 //frmPizza sw = new frmPizza(); Remove comment when frmPizza load
                this.Hide();
                //sw.Show();                  Remove comment when frmPizza load
            }
            else
            {
                MessageBox.Show("Incorrect Details", "Please re-enter Details",
                MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                ClearDetails();

            }

            //code to check the username and password

          
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //local variable to store result
            DialogResult dr;
            //accept response
            dr = MessageBox.Show("Are you sure you want to exit?",
                "Confirm Exit",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if yes then close program
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
