using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kokuz
{
    public partial class myProfileForm : Form
    {
        public myProfileForm()
        {
            InitializeComponent();
        }

        //BACK BUTTON
        private void myProfileBack_Click(object sender, EventArgs e)
        {
            Form main = new MainForm();
            main.Show();
            this.Hide();

        }

        //ucitavanje USERNAME i CURRENCY
        private void myProfileForm_Load(object sender, EventArgs e)
        {
            string username = Form1.userNameMain;
            myProfileUsername.Text = username;

            string currency = MainForm.currencyCheck;
            newCurrencyLbl.Text = currency;
        }

        //EURO CHANGE
        private void eurButton_Click(object sender, EventArgs e)
        {
            newCurrencyLbl.Text = "EUR";
        }

        //BAM CHANGE
        private void bamButton_Click(object sender, EventArgs e)
        {
            newCurrencyLbl.Text = "BAM";
        }


        //APPLY SETTINGS
        private void button3_Click(object sender, EventArgs e)
        {

            using (SQLiteConnection myConnection = new SQLiteConnection("data source=kokuzDB.db"))
            {
                myConnection.Open();

                using (SQLiteCommand myCommand = new SQLiteCommand(myConnection))
                {
                    myCommand.CommandText
                        = "UPDATE users SET currency='"+newCurrencyLbl.Text+"' WHERE username='"+myProfileUsername.Text+"';";

                    myCommand.ExecuteNonQuery();

                    myCommand.Dispose();
                }
                myConnection.Close();
            }

            newPasswordTextBox.Text = "";
            MessageBox.Show("Successfully Updated Currency Information");

        }

        private void newPasswordButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection myConnection = new SQLiteConnection("data source=kokuzDB.db"))
            {
                myConnection.Open();

                using (SQLiteCommand myCommand = new SQLiteCommand(myConnection))
                {
                    myCommand.CommandText
                        = "UPDATE users SET password='" + newPasswordTextBox.Text + "' WHERE username='" + myProfileUsername.Text + "';";

                    myCommand.ExecuteNonQuery();

                    myCommand.Dispose();
                }
                myConnection.Close();
            }

            newPasswordTextBox.Text = "";
            MessageBox.Show("Successfully Updated Password Information");
        }
    }
}
