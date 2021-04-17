namespace Exam2Part3
{
    partial class Form1
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
            this.stateLbl = new System.Windows.Forms.Label();
            this.purchasePriceLbl = new System.Windows.Forms.Label();
            this.salesTaxLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.stateTxt = new System.Windows.Forms.TextBox();
            this.purchasePriceTxt = new System.Windows.Forms.TextBox();
            this.calcTaxBtn = new System.Windows.Forms.Button();
            this.salesTaxPctOutputLbl = new System.Windows.Forms.Label();
            this.totalOutputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stateLbl
            // 
            this.stateLbl.Location = new System.Drawing.Point(29, 13);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(68, 13);
            this.stateLbl.TabIndex = 0;
            this.stateLbl.Text = "State:";
            this.stateLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // purchasePriceLbl
            // 
            this.purchasePriceLbl.Location = new System.Drawing.Point(13, 36);
            this.purchasePriceLbl.Name = "purchasePriceLbl";
            this.purchasePriceLbl.Size = new System.Drawing.Size(84, 13);
            this.purchasePriceLbl.TabIndex = 1;
            this.purchasePriceLbl.Text = "Purchase Price:";
            this.purchasePriceLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // salesTaxLbl
            // 
            this.salesTaxLbl.Location = new System.Drawing.Point(29, 59);
            this.salesTaxLbl.Name = "salesTaxLbl";
            this.salesTaxLbl.Size = new System.Drawing.Size(68, 13);
            this.salesTaxLbl.TabIndex = 2;
            this.salesTaxLbl.Text = "Sales Tax %:";
            this.salesTaxLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalLbl
            // 
            this.totalLbl.Location = new System.Drawing.Point(29, 82);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(68, 13);
            this.totalLbl.TabIndex = 3;
            this.totalLbl.Text = "Total:";
            this.totalLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stateTxt
            // 
            this.stateTxt.Location = new System.Drawing.Point(103, 10);
            this.stateTxt.Name = "stateTxt";
            this.stateTxt.Size = new System.Drawing.Size(100, 20);
            this.stateTxt.TabIndex = 4;
            // 
            // purchasePriceTxt
            // 
            this.purchasePriceTxt.Location = new System.Drawing.Point(103, 33);
            this.purchasePriceTxt.Name = "purchasePriceTxt";
            this.purchasePriceTxt.Size = new System.Drawing.Size(100, 20);
            this.purchasePriceTxt.TabIndex = 5;
            // 
            // calcTaxBtn
            // 
            this.calcTaxBtn.Location = new System.Drawing.Point(48, 105);
            this.calcTaxBtn.Name = "calcTaxBtn";
            this.calcTaxBtn.Size = new System.Drawing.Size(127, 23);
            this.calcTaxBtn.TabIndex = 8;
            this.calcTaxBtn.Text = "Calculate Tax";
            this.calcTaxBtn.UseVisualStyleBackColor = true;
            this.calcTaxBtn.Click += new System.EventHandler(this.calcTaxBtn_Click);
            // 
            // salesTaxPctOutputLbl
            // 
            this.salesTaxPctOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salesTaxPctOutputLbl.Location = new System.Drawing.Point(103, 58);
            this.salesTaxPctOutputLbl.Name = "salesTaxPctOutputLbl";
            this.salesTaxPctOutputLbl.Size = new System.Drawing.Size(100, 20);
            this.salesTaxPctOutputLbl.TabIndex = 9;
            this.salesTaxPctOutputLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalOutputLbl
            // 
            this.totalOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutputLbl.Location = new System.Drawing.Point(103, 81);
            this.totalOutputLbl.Name = "totalOutputLbl";
            this.totalOutputLbl.Size = new System.Drawing.Size(100, 20);
            this.totalOutputLbl.TabIndex = 10;
            this.totalOutputLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcTaxBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 141);
            this.Controls.Add(this.totalOutputLbl);
            this.Controls.Add(this.salesTaxPctOutputLbl);
            this.Controls.Add(this.calcTaxBtn);
            this.Controls.Add(this.purchasePriceTxt);
            this.Controls.Add(this.stateTxt);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.salesTaxLbl);
            this.Controls.Add(this.purchasePriceLbl);
            this.Controls.Add(this.stateLbl);
            this.Name = "Form1";
            this.Text = "Exam 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.Label purchasePriceLbl;
        private System.Windows.Forms.Label salesTaxLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.TextBox stateTxt;
        private System.Windows.Forms.TextBox purchasePriceTxt;
        private System.Windows.Forms.Button calcTaxBtn;
        private System.Windows.Forms.Label salesTaxPctOutputLbl;
        private System.Windows.Forms.Label totalOutputLbl;
    }
}

