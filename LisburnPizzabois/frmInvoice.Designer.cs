namespace LisburnPizzabois
{
    partial class frmInvoice
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
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalID = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscountD = new System.Windows.Forms.Label();
            this.lblSubtotalD = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(12, 306);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 0;
            this.btnEnd.Text = "Exit";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(126, 306);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(227, 306);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(89, 23);
            this.btnPrintPreview.TabIndex = 2;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Discount";
            // 
            // lblTotalID
            // 
            this.lblTotalID.AutoSize = true;
            this.lblTotalID.Location = new System.Drawing.Point(126, 114);
            this.lblTotalID.Name = "lblTotalID";
            this.lblTotalID.Size = new System.Drawing.Size(31, 13);
            this.lblTotalID.TabIndex = 5;
            this.lblTotalID.Text = "Total";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(179, 80);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(0, 13);
            this.lblSubtotal.TabIndex = 6;
            // 
            // lblDiscountD
            // 
            this.lblDiscountD.AutoSize = true;
            this.lblDiscountD.Location = new System.Drawing.Point(182, 97);
            this.lblDiscountD.Name = "lblDiscountD";
            this.lblDiscountD.Size = new System.Drawing.Size(0, 13);
            this.lblDiscountD.TabIndex = 7;
            // 
            // lblSubtotalD
            // 
            this.lblSubtotalD.AutoSize = true;
            this.lblSubtotalD.Location = new System.Drawing.Point(182, 114);
            this.lblSubtotalD.Name = "lblSubtotalD";
            this.lblSubtotalD.Size = new System.Drawing.Size(0, 13);
            this.lblSubtotalD.TabIndex = 8;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(340, 306);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(207, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "CustomerName";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblSubtotalD);
            this.Controls.Add(this.lblDiscountD);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTotalID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnEnd);
            this.Name = "frmInvoice";
            this.Text = "frmInvoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalID;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscountD;
        private System.Windows.Forms.Label lblSubtotalD;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblName;
    }
}