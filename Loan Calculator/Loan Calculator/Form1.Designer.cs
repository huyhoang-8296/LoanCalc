
namespace Loan_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_loanAmount = new System.Windows.Forms.TextBox();
            this.txt_interestRate = new System.Windows.Forms.TextBox();
            this.txt_numberOfMonths = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_endingValue = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loan
            // 
            this.loan.AutoSize = true;
            this.loan.Location = new System.Drawing.Point(90, 33);
            this.loan.Name = "loan";
            this.loan.Size = new System.Drawing.Size(80, 15);
            this.loan.TabIndex = 0;
            this.loan.Text = "Loan Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Months:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interest Rate: ";
            // 
            // txt_loanAmount
            // 
            this.txt_loanAmount.Location = new System.Drawing.Point(291, 25);
            this.txt_loanAmount.Name = "txt_loanAmount";
            this.txt_loanAmount.Size = new System.Drawing.Size(126, 23);
            this.txt_loanAmount.TabIndex = 3;
            // 
            // txt_interestRate
            // 
            this.txt_interestRate.Location = new System.Drawing.Point(291, 128);
            this.txt_interestRate.Name = "txt_interestRate";
            this.txt_interestRate.Size = new System.Drawing.Size(126, 23);
            this.txt_interestRate.TabIndex = 4;
            // 
            // txt_numberOfMonths
            // 
            this.txt_numberOfMonths.Location = new System.Drawing.Point(291, 77);
            this.txt_numberOfMonths.Name = "txt_numberOfMonths";
            this.txt_numberOfMonths.Size = new System.Drawing.Size(126, 23);
            this.txt_numberOfMonths.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(90, 189);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(421, 154);
            this.listBox1.TabIndex = 6;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(372, 418);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(96, 27);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(225, 418);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(96, 27);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ending Balance:";
            // 
            // txt_endingValue
            // 
            this.txt_endingValue.Location = new System.Drawing.Point(291, 367);
            this.txt_endingValue.Name = "txt_endingValue";
            this.txt_endingValue.ReadOnly = true;
            this.txt_endingValue.Size = new System.Drawing.Size(126, 23);
            this.txt_endingValue.TabIndex = 11;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(90, 418);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(96, 27);
            this.btn_calc.TabIndex = 15;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 488);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.txt_endingValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_numberOfMonths);
            this.Controls.Add(this.txt_interestRate);
            this.Controls.Add(this.txt_loanAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_loanAmount;
        private System.Windows.Forms.TextBox txt_interestRate;
        private System.Windows.Forms.TextBox txt_numberOfMonths;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_endingValue;
        private System.Windows.Forms.Button btn_calc;
    }
}

