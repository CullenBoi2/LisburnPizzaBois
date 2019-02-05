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
            dr = MessageBox.Show("Are you sure",
                "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if yes then close program
            if (dr == DialogResult.Yes)
            {
                txtUsername.Text = String.Empty;
                txtPassword.Text = String.Empty;

            }
            if (dr == DialogResult.No)
            {
                return;
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
            dr = MessageBox.Show("Confirm Username & Password?", "Enter Lisburn Pizza bois",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if yes then close program
            if (dr == DialogResult.Yes)
            {
                frmPizza ThePizzaForm;
                ThePizzaForm = new frmPizza();
                ThePizzaForm.ShowDialog(); 
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
