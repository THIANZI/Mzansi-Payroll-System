namespace Mzansi_Tech_Contractors_Payroll
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtHours = new TextBox();
            txtDependents = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblGross = new TextBox();
            lblUIF = new TextBox();
            lblPAYE = new TextBox();
            lblMembership = new TextBox();
            lblTotal = new TextBox();
            lblNet = new TextBox();
            btnCalculate = new Button();
            btnReset = new Button();
            btnExit = new Button();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(59, 86);
            label1.Name = "label1";
            label1.Size = new Size(143, 23);
            label1.TabIndex = 0;
            label1.Text = "Contractor Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(84, 138);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 1;
            label2.Text = "Hours Worked";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 204);
            label3.Name = "label3";
            label3.Size = new Size(190, 23);
            label3.TabIndex = 2;
            label3.Text = "Number of Dependents";
            // 
            // txtName
            // 
            txtName.Location = new Point(208, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(208, 141);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(125, 27);
            txtHours.TabIndex = 4;
            // 
            // txtDependents
            // 
            txtDependents.Location = new Point(208, 203);
            txtDependents.Name = "txtDependents";
            txtDependents.Size = new Size(125, 27);
            txtDependents.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(555, 88);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 6;
            label4.Text = "Gross Pay:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(523, 130);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 7;
            label5.Text = "UIF Deduction:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(512, 178);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 8;
            label6.Text = "PAYE Deduction:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(512, 225);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 9;
            label7.Text = "Membership Fee:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(505, 272);
            label8.Name = "label8";
            label8.Size = new Size(124, 20);
            label8.TabIndex = 10;
            label8.Text = "Total Deductions:";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(567, 318);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 11;
            label9.Text = "Net Pay:";
            // 
            // lblGross
            // 
            lblGross.Location = new Point(654, 82);
            lblGross.Name = "lblGross";
            lblGross.Size = new Size(125, 27);
            lblGross.TabIndex = 12;
            // 
            // lblUIF
            // 
            lblUIF.Location = new Point(654, 130);
            lblUIF.Name = "lblUIF";
            lblUIF.Size = new Size(125, 27);
            lblUIF.TabIndex = 13;
            // 
            // lblPAYE
            // 
            lblPAYE.Location = new Point(654, 178);
            lblPAYE.Name = "lblPAYE";
            lblPAYE.Size = new Size(125, 27);
            lblPAYE.TabIndex = 14;
            // 
            // lblMembership
            // 
            lblMembership.Location = new Point(654, 225);
            lblMembership.Name = "lblMembership";
            lblMembership.Size = new Size(125, 27);
            lblMembership.TabIndex = 15;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(654, 272);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(125, 27);
            lblTotal.TabIndex = 16;
            // 
            // lblNet
            // 
            lblNet.Location = new Point(654, 318);
            lblNet.Name = "lblNet";
            lblNet.Size = new Size(125, 27);
            lblNet.TabIndex = 17;
            lblNet.TextChanged += lblNet_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(33, 329);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(123, 51);
            btnCalculate.TabIndex = 18;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(174, 329);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(126, 50);
            btnReset.TabIndex = 19;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(320, 328);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(123, 52);
            btnExit.TabIndex = 20;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(142, 9);
            label10.Name = "label10";
            label10.Size = new Size(368, 41);
            label10.TabIndex = 21;
            label10.Text = "Mzansi Tech Contractors ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(lblNet);
            Controls.Add(lblTotal);
            Controls.Add(lblMembership);
            Controls.Add(lblPAYE);
            Controls.Add(lblUIF);
            Controls.Add(lblGross);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDependents);
            Controls.Add(txtHours);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Mzansi Tech Contractors Payroll";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtHours;
        private TextBox txtDependents;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox lblGross;
        private TextBox lblUIF;
        private TextBox lblPAYE;
        private TextBox lblMembership;
        private TextBox lblTotal;
        private TextBox lblNet;
        private Button btnCalculate;
        private Button btnReset;
        private Button btnExit;
        private Label label10;
    }
}
