namespace automobile_cost_calculator
{
    partial class frmAutomobileCost
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inTxtCarNote = new System.Windows.Forms.TextBox();
            this.inTxtCarInsurance = new System.Windows.Forms.TextBox();
            this.inTxtCarGas = new System.Windows.Forms.TextBox();
            this.inTxtCarOil = new System.Windows.Forms.TextBox();
            this.inTxtCarRepairs = new System.Windows.Forms.TextBox();
            this.inTxtCarRegistration = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.outTxtResults = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Note:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car Insurance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Oil Change:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Basic Repairs:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Registration Fees:";
            // 
            // inTxtCarNote
            // 
            this.inTxtCarNote.Location = new System.Drawing.Point(124, 74);
            this.inTxtCarNote.Name = "inTxtCarNote";
            this.inTxtCarNote.Size = new System.Drawing.Size(223, 20);
            this.inTxtCarNote.TabIndex = 6;
            // 
            // inTxtCarInsurance
            // 
            this.inTxtCarInsurance.Location = new System.Drawing.Point(124, 119);
            this.inTxtCarInsurance.Name = "inTxtCarInsurance";
            this.inTxtCarInsurance.Size = new System.Drawing.Size(223, 20);
            this.inTxtCarInsurance.TabIndex = 7;
            // 
            // inTxtCarGas
            // 
            this.inTxtCarGas.Location = new System.Drawing.Point(124, 168);
            this.inTxtCarGas.Name = "inTxtCarGas";
            this.inTxtCarGas.Size = new System.Drawing.Size(223, 20);
            this.inTxtCarGas.TabIndex = 8;
            // 
            // inTxtCarOil
            // 
            this.inTxtCarOil.Location = new System.Drawing.Point(124, 213);
            this.inTxtCarOil.Name = "inTxtCarOil";
            this.inTxtCarOil.Size = new System.Drawing.Size(223, 20);
            this.inTxtCarOil.TabIndex = 9;
            // 
            // inTxtCarRepairs
            // 
            this.inTxtCarRepairs.Location = new System.Drawing.Point(124, 261);
            this.inTxtCarRepairs.Name = "inTxtCarRepairs";
            this.inTxtCarRepairs.Size = new System.Drawing.Size(223, 20);
            this.inTxtCarRepairs.TabIndex = 10;
            // 
            // inTxtCarRegistration
            // 
            this.inTxtCarRegistration.Location = new System.Drawing.Point(124, 305);
            this.inTxtCarRegistration.Name = "inTxtCarRegistration";
            this.inTxtCarRegistration.Size = new System.Drawing.Size(223, 20);
            this.inTxtCarRegistration.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(272, 367);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calcualate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.submitExpenses);
            // 
            // outTxtResults
            // 
            this.outTxtResults.Location = new System.Drawing.Point(17, 431);
            this.outTxtResults.Multiline = true;
            this.outTxtResults.Name = "outTxtResults";
            this.outTxtResults.Size = new System.Drawing.Size(330, 100);
            this.outTxtResults.TabIndex = 13;
            this.outTxtResults.Text = "***Final Results:***\r\nTotal Monthly Cost: $\r\nTotal Annual Cost: $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 14;
            // 
            // frmAutomobileCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 561);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.outTxtResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.inTxtCarRegistration);
            this.Controls.Add(this.inTxtCarRepairs);
            this.Controls.Add(this.inTxtCarOil);
            this.Controls.Add(this.inTxtCarGas);
            this.Controls.Add(this.inTxtCarInsurance);
            this.Controls.Add(this.inTxtCarNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAutomobileCost";
            this.Text = "Automobile Cost Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inTxtCarNote;
        private System.Windows.Forms.TextBox inTxtCarInsurance;
        private System.Windows.Forms.TextBox inTxtCarGas;
        private System.Windows.Forms.TextBox inTxtCarOil;
        private System.Windows.Forms.TextBox inTxtCarRepairs;
        private System.Windows.Forms.TextBox inTxtCarRegistration;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox outTxtResults;
        private System.Windows.Forms.Label label7;
    }
}

