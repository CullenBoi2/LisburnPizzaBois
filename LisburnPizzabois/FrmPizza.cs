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
    public partial class FrmPizza : Form
    {
        public FrmPizza()
        {
            InitializeComponent();
        }

        //Variable to hold the values
        public static double dPrice, dSubTotal, dDiscount = 0;
        public static int dTotal = 0;

        private void pichawaiian_mouseLeave(object sender, EventArgs e)
        {
            //code to clear the pizza name and price display
            Pizzalbl.Text = string.Empty; 
        }
        private void RegularCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
