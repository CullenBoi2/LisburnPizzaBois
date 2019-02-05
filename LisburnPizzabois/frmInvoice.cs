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
    public partial class frmInvoice : Form
    {
        private PrintDocument printDocument1 = new PrintDocument();
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            Application.Exit();
        }

        private void frmInvoice_Activated(object sender, EventArgs e)
        {
            //code to read variables in other forms

            lblName.text = frmLogin.sname + " Please see below invoice";
            //make sure variables in previous forms are global
            lblDiscountD.text = FrmPizza.dDiscount.ToString("#0.00");
            lblTotalD.Text = FrmPizza.dSubTotal.ToString("#0.00");
            lblSubtotalD.Text = FrmPizza.dTotal.ToString("#0.00");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //open frmPizza
            FrmPizza ThePizzaForm;
            ThePizzaForm = new FrmPizza();
            ThePizzaForm.ShowDialog();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            DialogResult userresponse;
            PrintDialog.Document = printDocument1;
            userresponse = printDialog1.ShowDialog();
            if (userresponse == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        private void PrintPreviewControl()
        {
            //print preview control
            Form previewForm = new Form();
            PrintPreviewControl previewControl = new PrintPreviewControl();

            previewControl.Document = printDocument1;
            previewControl.Zoom = 0.5;
            previewControl.Dock = DockStyle.Fill;
            previewForm.Controls.Add(previewControl);
            previewForm.ShowDialog();
            previewForm.Dispose();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult userresponse;
            printDialog1.Document = printDocument1;
            userresponse = printDialog1.ShowDialog();
            if (userresponse == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.Print();
            }

        }
         private void myPrintPage(object sender, PrintPageEventsArgs e)
        {
            Single vPos = 0;
            Single hPos = 0;

            //font
            Font fontMedium = new Font("Arial", 14);
            Font fontLargeBold = new
                   Font("Arial", 36, FontStyle.Bold);

            //Brush
            Brush brushBlue = new SolidBrush(Color.Blue);
            Brush brushBlack = Brushes.Black;

        }

    }
}
