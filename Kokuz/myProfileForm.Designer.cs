namespace Kokuz
{
    partial class myProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myProfileForm));
            this.myProfileUsername = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.myProfileBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.newCurrencyLbl = new System.Windows.Forms.Label();
            this.bamButton = new System.Windows.Forms.Button();
            this.eurButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.newPasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myProfileUsername
            // 
            this.myProfileUsername.AutoSize = true;
            this.myProfileUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myProfileUsername.Location = new System.Drawing.Point(791, 9);
            this.myProfileUsername.Name = "myProfileUsername";
            this.myProfileUsername.Size = new System.Drawing.Size(66, 24);
            this.myProfileUsername.TabIndex = 0;
            this.myProfileUsername.Text = "label1";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(219, 145);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.Size = new System.Drawing.Size(190, 20);
            this.newPasswordTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Change Password";
            // 
            // myProfileBack
            // 
            this.myProfileBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myProfileBack.Location = new System.Drawing.Point(13, 9);
            this.myProfileBack.Name = "myProfileBack";
            this.myProfileBack.Size = new System.Drawing.Size(64, 34);
            this.myProfileBack.TabIndex = 3;
            this.myProfileBack.Text = "Back";
            this.myProfileBack.UseVisualStyleBackColor = true;
            this.myProfileBack.Click += new System.EventHandler(this.myProfileBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Change Currency";
            // 
            // newCurrencyLbl
            // 
            this.newCurrencyLbl.AutoSize = true;
            this.newCurrencyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCurrencyLbl.Location = new System.Drawing.Point(274, 336);
            this.newCurrencyLbl.Name = "newCurrencyLbl";
            this.newCurrencyLbl.Size = new System.Drawing.Size(66, 24);
            this.newCurrencyLbl.TabIndex = 5;
            this.newCurrencyLbl.Text = "label4";
            // 
            // bamButton
            // 
            this.bamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bamButton.Location = new System.Drawing.Point(219, 363);
            this.bamButton.Name = "bamButton";
            this.bamButton.Size = new System.Drawing.Size(99, 23);
            this.bamButton.TabIndex = 6;
            this.bamButton.Text = "BAM";
            this.bamButton.UseVisualStyleBackColor = true;
            this.bamButton.Click += new System.EventHandler(this.bamButton_Click);
            // 
            // eurButton
            // 
            this.eurButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eurButton.Location = new System.Drawing.Point(310, 363);
            this.eurButton.Name = "eurButton";
            this.eurButton.Size = new System.Drawing.Size(99, 23);
            this.eurButton.TabIndex = 7;
            this.eurButton.Text = "EUR";
            this.eurButton.UseVisualStyleBackColor = true;
            this.eurButton.Click += new System.EventHandler(this.eurButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(479, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Apply Currency Settings";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // newPasswordButton
            // 
            this.newPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordButton.Location = new System.Drawing.Point(479, 129);
            this.newPasswordButton.Name = "newPasswordButton";
            this.newPasswordButton.Size = new System.Drawing.Size(223, 36);
            this.newPasswordButton.TabIndex = 9;
            this.newPasswordButton.Text = "Apply Password Settings";
            this.newPasswordButton.UseVisualStyleBackColor = true;
            this.newPasswordButton.Click += new System.EventHandler(this.newPasswordButton_Click);
            // 
            // myProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 499);
            this.Controls.Add(this.newPasswordButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.eurButton);
            this.Controls.Add(this.bamButton);
            this.Controls.Add(this.newCurrencyLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.myProfileBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.myProfileUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "myProfileForm";
            this.Text = "Kokuz";
            this.Load += new System.EventHandler(this.myProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label myProfileUsername;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button myProfileBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label newCurrencyLbl;
        private System.Windows.Forms.Button bamButton;
        private System.Windows.Forms.Button eurButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button newPasswordButton;
    }
}