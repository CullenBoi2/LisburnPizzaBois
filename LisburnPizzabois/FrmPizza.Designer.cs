namespace LisburnPizzabois
{
    partial class FrmPizza
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
            this.PizzaChoice = new System.Windows.Forms.GroupBox();
            this.pichawaiian = new System.Windows.Forms.PictureBox();
            this.picFourCheese = new System.Windows.Forms.PictureBox();
            this.picVeg = new System.Windows.Forms.PictureBox();
            this.picMeatFeast = new System.Windows.Forms.PictureBox();
            this.picPeperoni = new System.Windows.Forms.PictureBox();
            this.picMargherita = new System.Windows.Forms.PictureBox();
            this.lblPizza = new System.Windows.Forms.Label();
            this.PizzaList = new System.Windows.Forms.ListBox();
            this.RegularCust = new System.Windows.Forms.CheckBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.SubTotal = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.RegularCustomer = new System.Windows.Forms.Label();
            this.RCCheck = new System.Windows.Forms.CheckBox();
            this.Pizzalbl = new System.Windows.Forms.TextBox();
            this.PizzaChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pichawaiian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFourCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMeatFeast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeperoni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMargherita)).BeginInit();
            this.SuspendLayout();
            // 
            // PizzaChoice
            // 
            this.PizzaChoice.Controls.Add(this.picMargherita);
            this.PizzaChoice.Controls.Add(this.picPeperoni);
            this.PizzaChoice.Controls.Add(this.picMeatFeast);
            this.PizzaChoice.Controls.Add(this.picVeg);
            this.PizzaChoice.Controls.Add(this.picFourCheese);
            this.PizzaChoice.Controls.Add(this.pichawaiian);
            this.PizzaChoice.Location = new System.Drawing.Point(34, 64);
            this.PizzaChoice.Name = "PizzaChoice";
            this.PizzaChoice.Size = new System.Drawing.Size(236, 282);
            this.PizzaChoice.TabIndex = 0;
            this.PizzaChoice.TabStop = false;
            this.PizzaChoice.Text = "Choose Your Pizza";
            // 
            // pichawaiian
            // 
            this.pichawaiian.Location = new System.Drawing.Point(7, 48);
            this.pichawaiian.Name = "pichawaiian";
            this.pichawaiian.Size = new System.Drawing.Size(100, 50);
            this.pichawaiian.TabIndex = 0;
            this.pichawaiian.TabStop = false;
            // 
            // picFourCheese
            // 
            this.picFourCheese.Location = new System.Drawing.Point(125, 48);
            this.picFourCheese.Name = "picFourCheese";
            this.picFourCheese.Size = new System.Drawing.Size(100, 50);
            this.picFourCheese.TabIndex = 1;
            this.picFourCheese.TabStop = false;
            // 
            // picVeg
            // 
            this.picVeg.Location = new System.Drawing.Point(7, 126);
            this.picVeg.Name = "picVeg";
            this.picVeg.Size = new System.Drawing.Size(100, 50);
            this.picVeg.TabIndex = 2;
            this.picVeg.TabStop = false;
            // 
            // picMeatFeast
            // 
            this.picMeatFeast.Location = new System.Drawing.Point(125, 126);
            this.picMeatFeast.Name = "picMeatFeast";
            this.picMeatFeast.Size = new System.Drawing.Size(100, 50);
            this.picMeatFeast.TabIndex = 3;
            this.picMeatFeast.TabStop = false;
            // 
            // picPeperoni
            // 
            this.picPeperoni.Location = new System.Drawing.Point(7, 205);
            this.picPeperoni.Name = "picPeperoni";
            this.picPeperoni.Size = new System.Drawing.Size(100, 50);
            this.picPeperoni.TabIndex = 4;
            this.picPeperoni.TabStop = false;
            // 
            // picMargherita
            // 
            this.picMargherita.Location = new System.Drawing.Point(125, 205);
            this.picMargherita.Name = "picMargherita";
            this.picMargherita.Size = new System.Drawing.Size(100, 50);
            this.picMargherita.TabIndex = 5;
            this.picMargherita.TabStop = false;
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.Location = new System.Drawing.Point(374, 78);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(0, 13);
            this.lblPizza.TabIndex = 1;
            // 
            // PizzaList
            // 
            this.PizzaList.FormattingEnabled = true;
            this.PizzaList.Location = new System.Drawing.Point(298, 94);
            this.PizzaList.Name = "PizzaList";
            this.PizzaList.Size = new System.Drawing.Size(192, 199);
            this.PizzaList.TabIndex = 2;
            // 
            // RegularCust
            // 
            this.RegularCust.AutoSize = true;
            this.RegularCust.Location = new System.Drawing.Point(377, 306);
            this.RegularCust.Name = "RegularCust";
            this.RegularCust.Size = new System.Drawing.Size(15, 14);
            this.RegularCust.TabIndex = 3;
            this.RegularCust.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(603, 109);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 4;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(603, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(603, 190);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 6;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(632, 387);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnInvoice.TabIndex = 7;
            this.btnInvoice.Text = "Confirm";
            this.btnInvoice.UseVisualStyleBackColor = true;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSize = true;
            this.SubTotal.Location = new System.Drawing.Point(538, 260);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(50, 13);
            this.SubTotal.TabIndex = 8;
            this.SubTotal.Text = "SubTotal";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Location = new System.Drawing.Point(539, 286);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(49, 13);
            this.Discount.TabIndex = 9;
            this.Discount.Text = "Discount";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(539, 306);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 10;
            this.Total.Text = "Total";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(595, 260);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(60, 13);
            this.lblSubTotal.TabIndex = 11;
            this.lblSubTotal.Text = "lblSubTotal";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(594, 286);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(59, 13);
            this.lblDiscount.TabIndex = 12;
            this.lblDiscount.Text = "lblDiscount";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(598, 306);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 13);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "lblTotal";
            // 
            // RegularCustomer
            // 
            this.RegularCustomer.AutoSize = true;
            this.RegularCustomer.Location = new System.Drawing.Point(301, 306);
            this.RegularCustomer.Name = "RegularCustomer";
            this.RegularCustomer.Size = new System.Drawing.Size(91, 13);
            this.RegularCustomer.TabIndex = 14;
            this.RegularCustomer.Text = "Regular Customer";
            this.RegularCustomer.Click += new System.EventHandler(this.RegularCustomer_Click);
            // 
            // RCCheck
            // 
            this.RCCheck.AutoSize = true;
            this.RCCheck.Location = new System.Drawing.Point(398, 306);
            this.RCCheck.Name = "RCCheck";
            this.RCCheck.Size = new System.Drawing.Size(15, 14);
            this.RCCheck.TabIndex = 15;
            this.RCCheck.UseVisualStyleBackColor = true;
            // 
            // Pizzalbl
            // 
            this.Pizzalbl.Location = new System.Drawing.Point(338, 75);
            this.Pizzalbl.Name = "Pizzalbl";
            this.Pizzalbl.Size = new System.Drawing.Size(100, 20);
            this.Pizzalbl.TabIndex = 16;
            // 
            // FrmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pizzalbl);
            this.Controls.Add(this.RCCheck);
            this.Controls.Add(this.RegularCustomer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.SubTotal);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.RegularCust);
            this.Controls.Add(this.PizzaList);
            this.Controls.Add(this.lblPizza);
            this.Controls.Add(this.PizzaChoice);
            this.Name = "FrmPizza";
            this.Text = "FrmPizza";
            this.PizzaChoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pichawaiian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFourCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMeatFeast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeperoni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMargherita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PizzaChoice;
        private System.Windows.Forms.PictureBox picMargherita;
        private System.Windows.Forms.PictureBox picPeperoni;
        private System.Windows.Forms.PictureBox picMeatFeast;
        private System.Windows.Forms.PictureBox picVeg;
        private System.Windows.Forms.PictureBox picFourCheese;
        private System.Windows.Forms.PictureBox pichawaiian;
        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.ListBox PizzaList;
        private System.Windows.Forms.CheckBox RegularCust;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label RegularCustomer;
        private System.Windows.Forms.CheckBox RCCheck;
        private System.Windows.Forms.TextBox Pizzalbl;
    }
}