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
    public partial class IncomeForm : Form
    {
        public IncomeForm()
        {
            InitializeComponent();
        }
        string usernameIncome = Form1.userNameMain;
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form main = new MainForm();
            main.Show();
            this.Hide();
        }

        // EURO promjena texta u currency labelu
        private void button2_Click(object sender, EventArgs e)
        {
            incomeValueCurrencyLbl.Text = "€";
        }

        //BAM promjena texta u currency labela
        private void button3_Click(object sender, EventArgs e)
        {
            incomeValueCurrencyLbl.Text = "KM";
        }

        private void submitIncomeButton_Click(object sender, EventArgs e)
        {
            //spremanje stringova za unos
            string incomeName = incomeNameTextBox.Text;
            string incomeDescription = incomeDesriptionTextBox.Text;
            string incomeMonth = incomeChooseMonthComboBox.Text;
            int incomeYear = 0;
            double incomeValue = 0;
            
            // zamjenit zarez sa tackom
            incomeValueTextBox.Text = incomeValueTextBox.Text.Replace(",", ".");

            // provjerit dal su sva polja popunjena
            if ((String.IsNullOrEmpty(incomeNameTextBox.Text)) || (String.IsNullOrEmpty(incomeValueTextBox.Text)) || (String.IsNullOrEmpty(incomeChooseMonthComboBox.Text)) || (String.IsNullOrEmpty(incomeYearTextBox.Text)) || (String.IsNullOrEmpty(incomeDesriptionTextBox.Text)))
            {
                MessageBox.Show("Please fill all information");
            }
            // UBACIVANJE INCOME U BAZU
            else if ((Int32.TryParse(incomeYearTextBox.Text,out incomeYear)) && (Double.TryParse(incomeValueTextBox.Text ,out incomeValue)))
            {   
                //KM TO EURO
                if (incomeValueCurrencyLbl.Text == "KM")
                {
                    incomeValue /= 1.95;
                }

                using (SQLiteConnection myConnection = new SQLiteConnection("data source=kokuzDB.db"))
                {
                    myConnection.Open();
                    using(SQLiteCommand myCommand = new SQLiteCommand(myConnection))
                    {
                        myCommand.CommandText = "UPDATE users SET balance = balance+'"+incomeValue+"' WHERE username='"+usernameIncome+"';" +
                            "INSERT INTO income(user_id,incomeName,incomeValue,incomeDescription,incomeMonth,incomeYear)" +
                            "VALUES ((SELECT id FROM users WHERE(username='"+usernameIncome+"')),'"+incomeName+"','"+incomeValue.ToString()+"','"+incomeDescription+"','"+incomeMonth+"','"+incomeYear.ToString()+"');";
                        myCommand.ExecuteNonQuery();
                        myCommand.Dispose();
                    }
                    myConnection.Close();
                }

                incomeNameTextBox.Text = "";
                incomeDesriptionTextBox.Text = "";
                incomeChooseMonthComboBox.Text = "";
                incomeValueTextBox.Text = "";
                incomeChooseMonthComboBox.Text = "";
                MessageBox.Show("Successfully Registered Income");


            }
            else
            {
                MessageBox.Show("Please enter right information");
            }
            
          



        }
    }
}
