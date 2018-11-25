namespace Kokuz
{
    partial class transactionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transactionsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.incomePage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.expensePage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.incomePage.SuspendLayout();
            this.expensePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.incomePage);
            this.tabControl1.Controls.Add(this.expensePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(946, 499);
            this.tabControl1.TabIndex = 0;
            // 
            // incomePage
            // 
            this.incomePage.Controls.Add(this.button1);
            this.incomePage.Location = new System.Drawing.Point(4, 29);
            this.incomePage.Name = "incomePage";
            this.incomePage.Padding = new System.Windows.Forms.Padding(3);
            this.incomePage.Size = new System.Drawing.Size(938, 466);
            this.incomePage.TabIndex = 0;
            this.incomePage.Text = "Income";
            this.incomePage.UseVisualStyleBackColor = true;
            this.incomePage.Click += new System.EventHandler(this.incomePage_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // expensePage
            // 
            this.expensePage.Controls.Add(this.button2);
            this.expensePage.Location = new System.Drawing.Point(4, 29);
            this.expensePage.Name = "expensePage";
            this.expensePage.Padding = new System.Windows.Forms.Padding(3);
            this.expensePage.Size = new System.Drawing.Size(938, 466);
            this.expensePage.TabIndex = 1;
            this.expensePage.Text = "expense";
            this.expensePage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(8, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // transactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(946, 499);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "transactionsForm";
            this.Text = "Kokuz";
            this.Load += new System.EventHandler(this.transactionsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.incomePage.ResumeLayout(false);
            this.expensePage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage incomePage;
        private System.Windows.Forms.TabPage expensePage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}