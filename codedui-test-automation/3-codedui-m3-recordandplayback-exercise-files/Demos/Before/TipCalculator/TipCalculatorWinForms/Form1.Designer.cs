namespace TipCalculatorWinForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbBad = new System.Windows.Forms.RadioButton();
            this.rdbAverage = new System.Windows.Forms.RadioButton();
            this.rdbGood = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.txtTipAmount = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb4NumCourses = new System.Windows.Forms.RadioButton();
            this.rdb3NumCourses = new System.Windows.Forms.RadioButton();
            this.rdb2NumCourses = new System.Windows.Forms.RadioButton();
            this.rdb1NumCourses = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdb2Duration = new System.Windows.Forms.RadioButton();
            this.rdb1Duration = new System.Windows.Forms.RadioButton();
            this.rdb0Duration = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate Tip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(149, 57);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBillAmount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bill Amount";
            // 
            // rdbBad
            // 
            this.rdbBad.AutoSize = true;
            this.rdbBad.Location = new System.Drawing.Point(23, 35);
            this.rdbBad.Name = "rdbBad";
            this.rdbBad.Size = new System.Drawing.Size(44, 17);
            this.rdbBad.TabIndex = 3;
            this.rdbBad.TabStop = true;
            this.rdbBad.Text = "Bad";
            this.rdbBad.UseVisualStyleBackColor = true;
            // 
            // rdbAverage
            // 
            this.rdbAverage.AutoSize = true;
            this.rdbAverage.Checked = true;
            this.rdbAverage.Location = new System.Drawing.Point(111, 35);
            this.rdbAverage.Name = "rdbAverage";
            this.rdbAverage.Size = new System.Drawing.Size(65, 17);
            this.rdbAverage.TabIndex = 3;
            this.rdbAverage.TabStop = true;
            this.rdbAverage.Text = "Average";
            this.rdbAverage.UseVisualStyleBackColor = true;
            // 
            // rdbGood
            // 
            this.rdbGood.AutoSize = true;
            this.rdbGood.Location = new System.Drawing.Point(192, 35);
            this.rdbGood.Name = "rdbGood";
            this.rdbGood.Size = new System.Drawing.Size(51, 17);
            this.rdbGood.TabIndex = 3;
            this.rdbGood.TabStop = true;
            this.rdbGood.Text = "Good";
            this.rdbGood.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Country";
            // 
            // cmbCountries
            // 
            this.cmbCountries.AccessibleName = "cmbCountries";
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(149, 30);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(121, 21);
            this.cmbCountries.TabIndex = 5;
            // 
            // txtTipAmount
            // 
            this.txtTipAmount.Location = new System.Drawing.Point(160, 298);
            this.txtTipAmount.Name = "txtTipAmount";
            this.txtTipAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTipAmount.TabIndex = 6;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(160, 324);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tip Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbGood);
            this.groupBox1.Controls.Add(this.rdbAverage);
            this.groupBox1.Controls.Add(this.rdbBad);
            this.groupBox1.Location = new System.Drawing.Point(38, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 60);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quality of Service";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb4NumCourses);
            this.groupBox2.Controls.Add(this.rdb3NumCourses);
            this.groupBox2.Controls.Add(this.rdb2NumCourses);
            this.groupBox2.Controls.Add(this.rdb1NumCourses);
            this.groupBox2.Location = new System.Drawing.Point(38, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 63);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Number of Courses";
            // 
            // rdb4NumCourses
            // 
            this.rdb4NumCourses.AutoSize = true;
            this.rdb4NumCourses.Location = new System.Drawing.Point(286, 30);
            this.rdb4NumCourses.Name = "rdb4NumCourses";
            this.rdb4NumCourses.Size = new System.Drawing.Size(31, 17);
            this.rdb4NumCourses.TabIndex = 8;
            this.rdb4NumCourses.TabStop = true;
            this.rdb4NumCourses.Text = "4";
            this.rdb4NumCourses.UseVisualStyleBackColor = true;
            // 
            // rdb3NumCourses
            // 
            this.rdb3NumCourses.AutoSize = true;
            this.rdb3NumCourses.Location = new System.Drawing.Point(218, 30);
            this.rdb3NumCourses.Name = "rdb3NumCourses";
            this.rdb3NumCourses.Size = new System.Drawing.Size(31, 17);
            this.rdb3NumCourses.TabIndex = 5;
            this.rdb3NumCourses.TabStop = true;
            this.rdb3NumCourses.Text = "3";
            this.rdb3NumCourses.UseVisualStyleBackColor = true;
            // 
            // rdb2NumCourses
            // 
            this.rdb2NumCourses.AutoSize = true;
            this.rdb2NumCourses.Checked = true;
            this.rdb2NumCourses.Location = new System.Drawing.Point(127, 30);
            this.rdb2NumCourses.Name = "rdb2NumCourses";
            this.rdb2NumCourses.Size = new System.Drawing.Size(31, 17);
            this.rdb2NumCourses.TabIndex = 6;
            this.rdb2NumCourses.TabStop = true;
            this.rdb2NumCourses.Text = "2";
            this.rdb2NumCourses.UseVisualStyleBackColor = true;
            // 
            // rdb1NumCourses
            // 
            this.rdb1NumCourses.AutoSize = true;
            this.rdb1NumCourses.Location = new System.Drawing.Point(23, 30);
            this.rdb1NumCourses.Name = "rdb1NumCourses";
            this.rdb1NumCourses.Size = new System.Drawing.Size(31, 17);
            this.rdb1NumCourses.TabIndex = 7;
            this.rdb1NumCourses.TabStop = true;
            this.rdb1NumCourses.Text = "1";
            this.rdb1NumCourses.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdb2Duration);
            this.groupBox3.Controls.Add(this.rdb1Duration);
            this.groupBox3.Controls.Add(this.rdb0Duration);
            this.groupBox3.Location = new System.Drawing.Point(38, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 40);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Number of Flies in Soup";
            // 
            // rdb2Duration
            // 
            this.rdb2Duration.AutoSize = true;
            this.rdb2Duration.Location = new System.Drawing.Point(223, 17);
            this.rdb2Duration.Name = "rdb2Duration";
            this.rdb2Duration.Size = new System.Drawing.Size(31, 17);
            this.rdb2Duration.TabIndex = 4;
            this.rdb2Duration.TabStop = true;
            this.rdb2Duration.Text = "2";
            this.rdb2Duration.UseVisualStyleBackColor = true;
            // 
            // rdb1Duration
            // 
            this.rdb1Duration.AutoSize = true;
            this.rdb1Duration.Location = new System.Drawing.Point(132, 17);
            this.rdb1Duration.Name = "rdb1Duration";
            this.rdb1Duration.Size = new System.Drawing.Size(31, 17);
            this.rdb1Duration.TabIndex = 5;
            this.rdb1Duration.TabStop = true;
            this.rdb1Duration.Text = "1";
            this.rdb1Duration.UseVisualStyleBackColor = true;
            // 
            // rdb0Duration
            // 
            this.rdb0Duration.AutoSize = true;
            this.rdb0Duration.Checked = true;
            this.rdb0Duration.Location = new System.Drawing.Point(28, 17);
            this.rdb0Duration.Name = "rdb0Duration";
            this.rdb0Duration.Size = new System.Drawing.Size(31, 17);
            this.rdb0Duration.TabIndex = 6;
            this.rdb0Duration.TabStop = true;
            this.rdb0Duration.Text = "0";
            this.rdb0Duration.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 399);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtTipAmount);
            this.Controls.Add(this.cmbCountries);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbBad;
        private System.Windows.Forms.RadioButton rdbAverage;
        private System.Windows.Forms.RadioButton rdbGood;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.TextBox txtTipAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb4NumCourses;
        private System.Windows.Forms.RadioButton rdb3NumCourses;
        private System.Windows.Forms.RadioButton rdb2NumCourses;
        private System.Windows.Forms.RadioButton rdb1NumCourses;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdb2Duration;
        private System.Windows.Forms.RadioButton rdb1Duration;
        private System.Windows.Forms.RadioButton rdb0Duration;
    }
}

