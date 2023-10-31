namespace ExceptionHandlingClient
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
            this.btnDivide = new System.Windows.Forms.Button();
            this.lblNumerator = new System.Windows.Forms.Label();
            this.lblDenominator = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtDenom = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(21, 115);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 0;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // lblNumerator
            // 
            this.lblNumerator.AutoSize = true;
            this.lblNumerator.Location = new System.Drawing.Point(18, 34);
            this.lblNumerator.Name = "lblNumerator";
            this.lblNumerator.Size = new System.Drawing.Size(56, 13);
            this.lblNumerator.TabIndex = 1;
            this.lblNumerator.Text = "Numerator";
            // 
            // lblDenominator
            // 
            this.lblDenominator.AutoSize = true;
            this.lblDenominator.Location = new System.Drawing.Point(18, 71);
            this.lblDenominator.Name = "lblDenominator";
            this.lblDenominator.Size = new System.Drawing.Size(67, 13);
            this.lblDenominator.TabIndex = 2;
            this.lblDenominator.Text = "Denominator";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(88, 31);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 3;
            // 
            // txtDenom
            // 
            this.txtDenom.Location = new System.Drawing.Point(88, 71);
            this.txtDenom.Name = "txtDenom";
            this.txtDenom.Size = new System.Drawing.Size(100, 20);
            this.txtDenom.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(27, 159);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtDenom);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblDenominator);
            this.Controls.Add(this.lblNumerator);
            this.Controls.Add(this.btnDivide);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label lblNumerator;
        private System.Windows.Forms.Label lblDenominator;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtDenom;
        private System.Windows.Forms.Label lblResult;
    }
}

