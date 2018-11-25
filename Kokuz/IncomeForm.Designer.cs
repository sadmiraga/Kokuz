namespace Kokuz
{
    partial class IncomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.incomeNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.incomeValueTextBox = new System.Windows.Forms.TextBox();
            this.incomeChooseMonthComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.incomeYearTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.incomeDesriptionTextBox = new System.Windows.Forms.TextBox();
            this.submitIncomeButton = new System.Windows.Forms.Button();
            this.incomeValueCurrencyLbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Register Income";
            // 
            // incomeNameTextBox
            // 
            this.incomeNameTextBox.Location = new System.Drawing.Point(292, 100);
            this.incomeNameTextBox.Name = "incomeNameTextBox";
            this.incomeNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.incomeNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name of Income";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter Income Value";
            // 
            // incomeValueTextBox
            // 
            this.incomeValueTextBox.Location = new System.Drawing.Point(292, 151);
            this.incomeValueTextBox.Name = "incomeValueTextBox";
            this.incomeValueTextBox.Size = new System.Drawing.Size(175, 20);
            this.incomeValueTextBox.TabIndex = 7;
            // 
            // incomeChooseMonthComboBox
            // 
            this.incomeChooseMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.incomeChooseMonthComboBox.FormattingEnabled = true;
            this.incomeChooseMonthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "Juny",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.incomeChooseMonthComboBox.Location = new System.Drawing.Point(730, 99);
            this.incomeChooseMonthComboBox.Name = "incomeChooseMonthComboBox";
            this.incomeChooseMonthComboBox.Size = new System.Drawing.Size(121, 21);
            this.incomeChooseMonthComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(590, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Choose Month";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(625, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Enter Year";
            // 
            // incomeYearTextBox
            // 
            this.incomeYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeYearTextBox.Location = new System.Drawing.Point(730, 151);
            this.incomeYearTextBox.Name = "incomeYearTextBox";
            this.incomeYearTextBox.Size = new System.Drawing.Size(77, 29);
            this.incomeYearTextBox.TabIndex = 11;
            this.incomeYearTextBox.Text = "2018";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Enter Income Description";
            // 
            // incomeDesriptionTextBox
            // 
            this.incomeDesriptionTextBox.Location = new System.Drawing.Point(115, 331);
            this.incomeDesriptionTextBox.Multiline = true;
            this.incomeDesriptionTextBox.Name = "incomeDesriptionTextBox";
            this.incomeDesriptionTextBox.Size = new System.Drawing.Size(271, 69);
            this.incomeDesriptionTextBox.TabIndex = 14;
            // 
            // submitIncomeButton
            // 
            this.submitIncomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitIncomeButton.Location = new System.Drawing.Point(580, 331);
            this.submitIncomeButton.Name = "submitIncomeButton";
            this.submitIncomeButton.Size = new System.Drawing.Size(271, 69);
            this.submitIncomeButton.TabIndex = 15;
            this.submitIncomeButton.Text = "Submit Income";
            this.submitIncomeButton.UseVisualStyleBackColor = true;
            this.submitIncomeButton.Click += new System.EventHandler(this.submitIncomeButton_Click);
            // 
            // incomeValueCurrencyLbl
            // 
            this.incomeValueCurrencyLbl.AutoSize = true;
            this.incomeValueCurrencyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeValueCurrencyLbl.Location = new System.Drawing.Point(473, 154);
            this.incomeValueCurrencyLbl.Name = "incomeValueCurrencyLbl";
            this.incomeValueCurrencyLbl.Size = new System.Drawing.Size(16, 16);
            this.incomeValueCurrencyLbl.TabIndex = 16;
            this.incomeValueCurrencyLbl.Text = "€";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(292, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "EURO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(379, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "BAM";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 499);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.incomeValueCurrencyLbl);
            this.Controls.Add(this.submitIncomeButton);
            this.Controls.Add(this.incomeDesriptionTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.incomeYearTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.incomeChooseMonthComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.incomeValueTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.incomeNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IncomeForm";
            this.Text = "Kokuz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox incomeNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox incomeValueTextBox;
        private System.Windows.Forms.ComboBox incomeChooseMonthComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox incomeYearTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox incomeDesriptionTextBox;
        private System.Windows.Forms.Button submitIncomeButton;
        private System.Windows.Forms.Label incomeValueCurrencyLbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}