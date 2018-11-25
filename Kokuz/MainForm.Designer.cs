namespace Kokuz
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.balanceLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.assetRadioButton = new System.Windows.Forms.RadioButton();
            this.liabilityRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.transactionsComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.transactionYearTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.seeTransactionsButton = new System.Windows.Forms.Button();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.currencyLbl = new System.Windows.Forms.Label();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLbl.Location = new System.Drawing.Point(818, 36);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(29, 20);
            this.balanceLbl.TabIndex = 1;
            this.balanceLbl.Text = "50";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(447, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Register Income";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(480, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(447, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Register Expense";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "My profile";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Transactions";
            // 
            // assetRadioButton
            // 
            this.assetRadioButton.AutoSize = true;
            this.assetRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetRadioButton.Location = new System.Drawing.Point(46, 355);
            this.assetRadioButton.Name = "assetRadioButton";
            this.assetRadioButton.Size = new System.Drawing.Size(68, 24);
            this.assetRadioButton.TabIndex = 7;
            this.assetRadioButton.Text = "Asset";
            this.assetRadioButton.UseVisualStyleBackColor = true;
            // 
            // liabilityRadioButton
            // 
            this.liabilityRadioButton.AutoSize = true;
            this.liabilityRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liabilityRadioButton.Location = new System.Drawing.Point(46, 325);
            this.liabilityRadioButton.Name = "liabilityRadioButton";
            this.liabilityRadioButton.Size = new System.Drawing.Size(78, 24);
            this.liabilityRadioButton.TabIndex = 8;
            this.liabilityRadioButton.Text = "Liability";
            this.liabilityRadioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Liability or Asset";
            // 
            // transactionsComboBox
            // 
            this.transactionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transactionsComboBox.FormattingEnabled = true;
            this.transactionsComboBox.Items.AddRange(new object[] {
            "All",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.transactionsComboBox.Location = new System.Drawing.Point(401, 321);
            this.transactionsComboBox.Name = "transactionsComboBox";
            this.transactionsComboBox.Size = new System.Drawing.Size(147, 21);
            this.transactionsComboBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Choose Month";
            // 
            // transactionYearTextBox
            // 
            this.transactionYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionYearTextBox.Location = new System.Drawing.Point(768, 310);
            this.transactionYearTextBox.Name = "transactionYearTextBox";
            this.transactionYearTextBox.Size = new System.Drawing.Size(58, 31);
            this.transactionYearTextBox.TabIndex = 12;
            this.transactionYearTextBox.Text = "2018";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(727, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Choose Year";
            // 
            // seeTransactionsButton
            // 
            this.seeTransactionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeTransactionsButton.Location = new System.Drawing.Point(12, 411);
            this.seeTransactionsButton.Name = "seeTransactionsButton";
            this.seeTransactionsButton.Size = new System.Drawing.Size(915, 47);
            this.seeTransactionsButton.TabIndex = 14;
            this.seeTransactionsButton.Text = "See Transactions";
            this.seeTransactionsButton.UseVisualStyleBackColor = true;
            this.seeTransactionsButton.Click += new System.EventHandler(this.seeTransactionsButton_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(793, 3);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(103, 24);
            this.usernameLbl.TabIndex = 15;
            this.usernameLbl.Text = "username";
            // 
            // currencyLbl
            // 
            this.currencyLbl.AutoSize = true;
            this.currencyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyLbl.Location = new System.Drawing.Point(764, 36);
            this.currencyLbl.Name = "currencyLbl";
            this.currencyLbl.Size = new System.Drawing.Size(19, 20);
            this.currencyLbl.TabIndex = 16;
            this.currencyLbl.Text = "€";
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Checked = true;
            this.allRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRadioButton.Location = new System.Drawing.Point(46, 295);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(44, 24);
            this.allRadioButton.TabIndex = 17;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "All";
            this.allRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(946, 499);
            this.Controls.Add(this.allRadioButton);
            this.Controls.Add(this.currencyLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.seeTransactionsButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.transactionYearTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.transactionsComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.liabilityRadioButton);
            this.Controls.Add(this.assetRadioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.balanceLbl);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Kokuz";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton assetRadioButton;
        private System.Windows.Forms.RadioButton liabilityRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox transactionsComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox transactionYearTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button seeTransactionsButton;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label currencyLbl;
        private System.Windows.Forms.RadioButton allRadioButton;
    }
}