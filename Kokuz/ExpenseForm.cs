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
// you cant spend more than you have

namespace Kokuz
{
    public partial class ExpenseForm : Form
    {
        public ExpenseForm()
        {
            InitializeComponent();
        }

        // USERNAME
        string usernameExpense = Form1.userNameMain;

        //BACK BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            Form main = new MainForm();
            main.Show();
            this.Hide();
        }

        //EURO LBL
        private void button2_Click(object sender, EventArgs e)
        {
            expenseValueCurrencyLbl.Text = "€";
        }
        // BAM LBL
        private void button3_Click(object sender, EventArgs e)
        {
            expenseValueCurrencyLbl.Text = "KM";
        }

        //SUBMIT EXPENSE
        private void submitIncomeButton_Click(object sender, EventArgs e)
        {


            //ASSET OR LIABILITY
            string LorA;
            if (assetRadioButton.Checked == true)
            {
                LorA = "asset";
            }
            else
            {
                LorA = "liability";
            }

            //promjenjive
            string expenseName = expenseNameTextBox.Text;
            string expenseDescription = expenseDesriptionTextBox.Text;
            string expenseMonth = expenseChooseMonthComboBox.Text;
            int expenseYear = 0;
            double expenseValue = 0;

            // IF ANY TEXTBOX EMPTY
            if ((string.IsNullOrEmpty(expenseNameTextBox.Text)) || (string.IsNullOrEmpty(expenseValueTextBox.Text)) || (string.IsNullOrEmpty(expenseDesriptionTextBox.Text)) || (string.IsNullOrEmpty(expenseChooseMonthComboBox.Text)) || (string.IsNullOrEmpty(expenseYearTextBox.Text)))
            {
                MessageBox.Show("Please fill all informations");
            }
            else if ((Int32.TryParse(expenseYearTextBox.Text, out expenseYear)) && (Double.TryParse(expenseValueTextBox.Text, out expenseValue)))
            {
                if (expenseValueCurrencyLbl.Text == "KM")
                {
                    expenseValue /= 1.95;
                }

                using (SQLiteConnection myConnection = new SQLiteConnection("data source=kokuzDB.db"))
                {
                    myConnection.Open();
                    using (SQLiteCommand myCommand = new SQLiteCommand(myConnection))
                    {
                        myCommand.CommandText = "UPDATE users SET balance = balance-'" +expenseValue+ "' WHERE username='" +usernameExpense+ "';" +
                            "INSERT INTO expense(user_id,expenseName,expenseValue,expenseDescription,expenseMonth,expenseYear,LorA)" +
                            "VALUES ((SELECT id FROM users WHERE(username='" +usernameExpense+ "')),'" +expenseName+"','" + expenseValue.ToString() + "','" + expenseDescription + "','" + expenseMonth + "','" + expenseYear.ToString() + "','"+LorA+"');";
                        myCommand.ExecuteNonQuery();
                        myCommand.Dispose();
                    }
                    myConnection.Close();
                }

                expenseNameTextBox.Text = "";
                expenseDesriptionTextBox.Text = "";
                expenseChooseMonthComboBox.Text = "";
                expenseValueTextBox.Text = "";
                expenseChooseMonthComboBox.Text = "";
                MessageBox.Show("Successfully registered Expense");



            }
            else
            {
                MessageBox.Show("Please Enter Right Information");
            }



        }
    }
}
