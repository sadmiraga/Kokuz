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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static string LorA, transactionMonth, transactionYear, currencyCheck = "";



        private void MainForm_Load(object sender, EventArgs e)
        {


            string userNameDisplay = Form1.userNameMain;
            double balanceDisplayDouble = 0;
            string balanceDisplay;
            usernameLbl.Text = userNameDisplay;

            //reading information about user from database
            using (SQLiteConnection myConnection = new SQLiteConnection("data source=kokuzDB.db"))
            {
                myConnection.Open();

                using (SQLiteCommand myCommand
                    = new SQLiteCommand(myConnection))
                {
                    myCommand.CommandText
                        = "SELECT * FROM users WHERE username='"+userNameDisplay+"';";

                    SQLiteDataReader myReader
                        = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        balanceDisplayDouble = myReader.GetDouble(2);
                        currencyCheck = myReader.GetString(6);
                    }

                    myCommand.Dispose();
                }
                myConnection.Close();
            }

            // uslovi za prikaz valute i promjenu vrijednosti u slucaju KM 
            if (currencyCheck == "EUR")
            {
                currencyLbl.Text = "€";
            }
            else if (currencyCheck=="BAM")
            {
                currencyLbl.Text = "KM";
                balanceDisplayDouble *= 1.95;
            }


            //prikaz stanja racuna
            balanceDisplay = balanceDisplayDouble.ToString("F");
            balanceLbl.Text = balanceDisplay;



        }

        //Dugme za transactions
        private void seeTransactionsButton_Click(object sender, EventArgs e)
        {
            // geting LIABILIRY OR ASSET INFO
            int pomocna = 0;
            if (allRadioButton.Checked == true)
            {
                LorA = "all";
            }
            else if (assetRadioButton.Checked == true)
            {
                LorA = "asset";
            }
            else if (liabilityRadioButton.Checked == true)
            {
                LorA = "liability";
            }

           if((string.IsNullOrEmpty(transactionYearTextBox.Text) || (String.IsNullOrEmpty(transactionsComboBox.Text)))){
                MessageBox.Show("Please Enter All Information");
            }
            else if (Int32.TryParse(transactionYearTextBox.Text, out pomocna))
            {
                transactionMonth = transactionsComboBox.Text;
                transactionYear = transactionYearTextBox.Text;
                //Prikaz transation FOrma
                Form transactions = new transactionsForm();
                this.Hide();
                transactions.Show();
            }
            else
            {
                MessageBox.Show("Please Enter Right Information");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form myProfile = new myProfileForm();
            this.Hide();
            myProfile.Show();
        }

        //INCOME BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            Form income = new IncomeForm();
            income.Show();
            this.Hide();
        }

        //EXPENSE BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            Form expense = new ExpenseForm();
            expense.Show();
            this.Hide();
        }
    }
}
