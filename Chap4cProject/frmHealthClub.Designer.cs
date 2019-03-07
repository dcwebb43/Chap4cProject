namespace Chap4cProject
{
    partial class frmHealthClub
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
            this.grpMembership = new System.Windows.Forms.GroupBox();
            this.radSenior = new System.Windows.Forms.RadioButton();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.radChild = new System.Windows.Forms.RadioButton();
            this.radAdult = new System.Windows.Forms.RadioButton();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkTrainer = new System.Windows.Forms.CheckBox();
            this.chkKarate = new System.Windows.Forms.CheckBox();
            this.chkYoga = new System.Windows.Forms.CheckBox();
            this.grpLength = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.grpFees = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMonthlyFee = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpMembership.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpLength.SuspendLayout();
            this.grpFees.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMembership
            // 
            this.grpMembership.Controls.Add(this.radSenior);
            this.grpMembership.Controls.Add(this.radStudent);
            this.grpMembership.Controls.Add(this.radChild);
            this.grpMembership.Controls.Add(this.radAdult);
            this.grpMembership.Location = new System.Drawing.Point(25, 57);
            this.grpMembership.Name = "grpMembership";
            this.grpMembership.Size = new System.Drawing.Size(133, 159);
            this.grpMembership.TabIndex = 0;
            this.grpMembership.TabStop = false;
            this.grpMembership.Text = "Type of Membership";
            // 
            // radSenior
            // 
            this.radSenior.AutoSize = true;
            this.radSenior.Location = new System.Drawing.Point(6, 125);
            this.radSenior.Name = "radSenior";
            this.radSenior.Size = new System.Drawing.Size(89, 17);
            this.radSenior.TabIndex = 3;
            this.radSenior.Text = "Senior Citizen";
            this.radSenior.UseVisualStyleBackColor = true;
            this.radSenior.CheckedChanged += new System.EventHandler(this.radAdult_CheckedChanged);
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Location = new System.Drawing.Point(6, 92);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(62, 17);
            this.radStudent.TabIndex = 2;
            this.radStudent.Text = "Student";
            this.radStudent.UseVisualStyleBackColor = true;
            this.radStudent.CheckedChanged += new System.EventHandler(this.radAdult_CheckedChanged);
            // 
            // radChild
            // 
            this.radChild.AutoSize = true;
            this.radChild.Location = new System.Drawing.Point(6, 59);
            this.radChild.Name = "radChild";
            this.radChild.Size = new System.Drawing.Size(120, 17);
            this.radChild.TabIndex = 1;
            this.radChild.Text = "Child (12 and under)";
            this.radChild.UseVisualStyleBackColor = true;
            this.radChild.CheckedChanged += new System.EventHandler(this.radAdult_CheckedChanged);
            // 
            // radAdult
            // 
            this.radAdult.AutoSize = true;
            this.radAdult.Checked = true;
            this.radAdult.Location = new System.Drawing.Point(6, 26);
            this.radAdult.Name = "radAdult";
            this.radAdult.Size = new System.Drawing.Size(95, 17);
            this.radAdult.TabIndex = 0;
            this.radAdult.TabStop = true;
            this.radAdult.Text = "Standard Adult";
            this.radAdult.UseVisualStyleBackColor = true;
            this.radAdult.CheckedChanged += new System.EventHandler(this.radAdult_CheckedChanged);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkTrainer);
            this.grpOptions.Controls.Add(this.chkKarate);
            this.grpOptions.Controls.Add(this.chkYoga);
            this.grpOptions.Location = new System.Drawing.Point(212, 57);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(154, 159);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // chkTrainer
            // 
            this.chkTrainer.AutoSize = true;
            this.chkTrainer.Location = new System.Drawing.Point(6, 117);
            this.chkTrainer.Name = "chkTrainer";
            this.chkTrainer.Size = new System.Drawing.Size(103, 17);
            this.chkTrainer.TabIndex = 2;
            this.chkTrainer.Text = "Personal Trainer";
            this.chkTrainer.UseVisualStyleBackColor = true;
            this.chkTrainer.CheckedChanged += new System.EventHandler(this.radAdult_CheckedChanged);
            // 
            // chkKarate
            // 
            this.chkKarate.AutoSize = true;
            this.chkKarate.Location = new System.Drawing.Point(6, 72);
            this.chkKarate.Name = "chkKarate";
            this.chkKarate.Size = new System.Drawing.Size(57, 17);
            this.chkKarate.TabIndex = 1;
            this.chkKarate.Text = "Karate";
            this.chkKarate.UseVisualStyleBackColor = true;
            this.chkKarate.CheckedChanged += new System.EventHandler(this.radAdult_CheckedChanged);
            // 
            // chkYoga
            // 
            this.chkYoga.AutoSize = true;
            this.chkYoga.Location = new System.Drawing.Point(6, 27);
            this.chkYoga.Name = "chkYoga";
            this.chkYoga.Size = new System.Drawing.Size(51, 17);
            this.chkYoga.TabIndex = 0;
            this.chkYoga.Text = "Yoga";
            this.chkYoga.UseVisualStyleBackColor = true;
            this.chkYoga.CheckedChanged += new System.EventHandler(this.radAdult_CheckedChanged);
            // 
            // grpLength
            // 
            this.grpLength.Controls.Add(this.label1);
            this.grpLength.Controls.Add(this.txtMonths);
            this.grpLength.Location = new System.Drawing.Point(25, 250);
            this.grpLength.Name = "grpLength";
            this.grpLength.Size = new System.Drawing.Size(132, 93);
            this.grpLength.TabIndex = 2;
            this.grpLength.TabStop = false;
            this.grpLength.Text = "Membership Length";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter number of months";
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(55, 62);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(29, 20);
            this.txtMonths.TabIndex = 0;
            this.txtMonths.TextChanged += new System.EventHandler(this.radAdult_CheckedChanged);
            // 
            // grpFees
            // 
            this.grpFees.Controls.Add(this.label4);
            this.grpFees.Controls.Add(this.lblTotal);
            this.grpFees.Controls.Add(this.label2);
            this.grpFees.Controls.Add(this.lblMonthlyFee);
            this.grpFees.Location = new System.Drawing.Point(212, 250);
            this.grpFees.Name = "grpFees";
            this.grpFees.Size = new System.Drawing.Size(153, 92);
            this.grpFees.TabIndex = 3;
            this.grpFees.TabStop = false;
            this.grpFees.Text = "Membership Fees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(91, 61);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 21);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monthly Fee";
            // 
            // lblMonthlyFee
            // 
            this.lblMonthlyFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonthlyFee.Location = new System.Drawing.Point(91, 25);
            this.lblMonthlyFee.Name = "lblMonthlyFee";
            this.lblMonthlyFee.Size = new System.Drawing.Size(56, 21);
            this.lblMonthlyFee.TabIndex = 0;
            this.lblMonthlyFee.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(39, 382);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(79, 26);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(158, 382);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 26);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(277, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 26);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Membership Fee Calculator";
            // 
            // frmHealthClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 415);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpFees);
            this.Controls.Add(this.grpLength);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpMembership);
            this.Name = "frmHealthClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DS3850: Chapter 4c Project";
            this.grpMembership.ResumeLayout(false);
            this.grpMembership.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpLength.ResumeLayout(false);
            this.grpLength.PerformLayout();
            this.grpFees.ResumeLayout(false);
            this.grpFees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMembership;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.GroupBox grpLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.GroupBox grpFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMonthlyFee;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radSenior;
        private System.Windows.Forms.RadioButton radStudent;
        private System.Windows.Forms.RadioButton radChild;
        private System.Windows.Forms.RadioButton radAdult;
        private System.Windows.Forms.CheckBox chkTrainer;
        private System.Windows.Forms.CheckBox chkKarate;
        private System.Windows.Forms.CheckBox chkYoga;
    }
}

