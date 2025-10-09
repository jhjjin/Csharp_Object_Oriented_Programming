namespace EmployeePayWindow
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
            this.Employee = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFederal = new System.Windows.Forms.TextBox();
            this.txtRetirement = new System.Windows.Forms.TextBox();
            this.txtSocial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalNet = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.Location = new System.Drawing.Point(118, 60);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(216, 31);
            this.Employee.TabIndex = 0;
            this.Employee.Text = "Employee name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Location = new System.Drawing.Point(545, 60);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(363, 48);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee\'s total weekly sales:";
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Location = new System.Drawing.Point(545, 126);
            this.txtTotalSales.Multiline = true;
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new System.Drawing.Size(363, 43);
            this.txtTotalSales.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(525, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee commission is 7% of total sales.";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPay.Location = new System.Drawing.Point(299, 275);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(310, 91);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Calculate Take-Home Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Deductions:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Federal tax (18%):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 590);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Retirement contribution (15%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 668);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Social Security (9%):";
            // 
            // txtFederal
            // 
            this.txtFederal.BackColor = System.Drawing.SystemColors.Window;
            this.txtFederal.Location = new System.Drawing.Point(533, 486);
            this.txtFederal.Multiline = true;
            this.txtFederal.Name = "txtFederal";
            this.txtFederal.Size = new System.Drawing.Size(363, 48);
            this.txtFederal.TabIndex = 10;
            // 
            // txtRetirement
            // 
            this.txtRetirement.BackColor = System.Drawing.SystemColors.Window;
            this.txtRetirement.Location = new System.Drawing.Point(533, 573);
            this.txtRetirement.Multiline = true;
            this.txtRetirement.Name = "txtRetirement";
            this.txtRetirement.Size = new System.Drawing.Size(363, 48);
            this.txtRetirement.TabIndex = 11;
            // 
            // txtSocial
            // 
            this.txtSocial.BackColor = System.Drawing.SystemColors.Window;
            this.txtSocial.Location = new System.Drawing.Point(533, 651);
            this.txtSocial.Multiline = true;
            this.txtSocial.Name = "txtSocial";
            this.txtSocial.Size = new System.Drawing.Size(363, 48);
            this.txtSocial.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 753);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Net Pay:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(140, 845);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Net Pay :";
            // 
            // txtTotalNet
            // 
            this.txtTotalNet.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalNet.Location = new System.Drawing.Point(545, 828);
            this.txtTotalNet.Multiline = true;
            this.txtTotalNet.Name = "txtTotalNet";
            this.txtTotalNet.Size = new System.Drawing.Size(363, 48);
            this.txtTotalNet.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.Location = new System.Drawing.Point(267, 915);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(159, 48);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.Location = new System.Drawing.Point(522, 915);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 48);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 1008);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTotalNet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSocial);
            this.Controls.Add(this.txtRetirement);
            this.Controls.Add(this.txtFederal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Employee);
            this.Name = "Form1";
            this.Text = "Net Pay Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFederal;
        private System.Windows.Forms.TextBox txtRetirement;
        private System.Windows.Forms.TextBox txtSocial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalNet;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

