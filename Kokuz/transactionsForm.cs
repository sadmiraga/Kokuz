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
    public partial class transactionsForm : Form
    {
        public transactionsForm()
        {
            InitializeComponent();
        }

        //promjenjive sa drugih FORMI
        string LorA = MainForm.LorA,
            transactionMonth = MainForm.transactionMonth,
            transactionYear = MainForm.transactionYear,
            transactionUsername = Form1.userNameMain;

        private void incomePage_Click(object sender, EventArgs e)
        {

        }

        //BACK BUTTON expense
        private void button2_Click(object sender, EventArgs e)
        {
            Form main = new MainForm();
            main.Show();
            this.Hide();
        }

        //BACK BUTTON income
        private void button1_Click(object sender, EventArgs e)
        {
            Form main = new MainForm();
            main.Show();
            this.Hide();
        }



        //UCITAVANJE STRANICE
        private void transactionsForm_Load(object sender, EventArgs e)
        {
            string imeTransakcije = "", vrijednostTransackije = "", opisTransakcijeIncome = "",opisTransakcijeExpense="", valutaTransakcije = "";
            double transactionValueTest = 0;
            string valutaPomocna = "";
            int opisHelp = 0;
            
            // ispisivanje na INCOME PAGE
            using (SQLiteConnection myConnection = new SQLiteConnection("data source=kokuzDB.db"))
            {
                myConnection.Open();

                using (SQLiteCommand myCommand = new SQLiteCommand(myConnection))
                {
                    // ALL (every) MONTH INCOME
                    if (transactionMonth == "All")
                    {
                        myCommand.CommandText = "SELECT i.incomeName,i.incomeValue,i.incomeDescription,u.currency FROM income i INNER JOIN users u ON i.user_id=u.id WHERE (u.username='" + transactionUsername + "') AND" +
                            " (incomeYear='" + transactionYear + "');";
                    }
                    //specified month income
                    else if (transactionMonth != "All")
                    {
                        myCommand.CommandText = "SELECT i.incomeName,i.incomeValue,i.incomeDescription,u.currency FROM income i INNER JOIN users u ON i.user_id=u.id WHERE (u.username='" + transactionUsername + "') AND" +
                            "(incomeMonth='" + transactionMonth + "') AND (incomeYear='" + transactionYear + "');";
                    }

                    SQLiteDataReader myReader = myCommand.ExecuteReader();
                    int adding = 0;
                    
                    //kreiranje labela i buttona
                    while (myReader.Read())
                    {
                        imeTransakcije = myReader.GetString(0);
                        transactionValueTest = myReader.GetDouble(1);
                        opisTransakcijeIncome = myReader.GetString(2);
                        valutaTransakcije = myReader.GetString(3);

                        if (valutaTransakcije == "BAM")
                        {
                            transactionValueTest *= 1.95;
                            valutaPomocna = "KM";
                        } else if (valutaTransakcije == "EUR")
                        {
                            valutaPomocna = "€";
                        }

                        //karina
                        //balanceDisplay = balanceDisplayDouble.ToString("F");
                        //balanceLbl.Text = balanceDisplay;


                        Button opis = new Button();
                        opis.Size = new Size(100, 30);
                        opis.Location = new Point(20, 40 + adding);
                        incomePage.Controls.Add(opis);
                        opis.Text = opisHelp.ToString();
                        opis.Name = opisHelp.ToString();


                        opis.Click += delegate
                        {
                            MessageBox.Show(opisTransakcijeIncome);
                        };
                        opisHelp++;

                        Label cijena = new Label();
                        cijena.Size = new Size(100, 30);
                        cijena.Location =  new Point(20 + opis.Width + 20, 45 + adding);
                        incomePage.Controls.Add(cijena);
                        vrijednostTransackije = transactionValueTest.ToString("F");
                        cijena.Text = vrijednostTransackije + valutaPomocna;


                        Label ime = new Label();
                        ime.Size = new Size(100, 20);
                        ime.Location = new Point (20+opis.Width+20+cijena.Width+20, 45 + adding);
                        incomePage.Controls.Add(ime);
                        ime.Text = imeTransakcije;

                        adding += 80;
                    }
                    myCommand.Dispose();
                }
                myConnection.Close();
            }

            //ispisivanje na EXPENSE PAGE
            using (SQLiteConnection myConnection = new SQLiteConnection("data source=kokuzDB.db"))
            {
                myConnection.Open();

                using (SQLiteCommand myCommand = new SQLiteCommand(myConnection))
                {
                    //ALL MONTH ALL LorA
                    if (transactionMonth == "All" && LorA=="all")
                    {
                        myCommand.CommandText = "SELECT e.expenseName,e.expenseValue,e.expenseDescription,u.currency,e.LorA FROM expense e INNER JOIN users u ON e.user_id=u.id WHERE (u.username='" + transactionUsername + "') AND" +
                            "(expenseYear='" + transactionYear + "');";
                    }
                    // ALL MONTH, LorA specified
                    else if(transactionMonth=="All" && LorA != "all")
                    {
                        myCommand.CommandText = "SELECT e.expenseName,e.expenseValue,e.expenseDescription,u.currency,e.LorA FROM expense e INNER JOIN users u ON e.user_id=u.id WHERE (u.username='" + transactionUsername + "') AND" +
                            "(expenseYear='" + transactionYear + "') AND (LorA='" + LorA + "');";
                    }
                    // specified monthh, ALL LorA
                    else if(transactionMonth!="All" && LorA == "all")
                    {
                        myCommand.CommandText = "SELECT e.expenseName,e.expenseValue,e.expenseDescription,u.currency,e.LorA FROM expense e INNER JOIN users u ON e.user_id=u.id WHERE (u.username='" + transactionUsername + "') AND" +
                            "(expenseMonth='" + transactionMonth + "') AND (expenseYear='" + transactionYear + "');";
                    }
                    //specified MONTH, specified LorA
                    else if(transactionMonth!="All" && LorA!="all")
                    {
                        myCommand.CommandText = "SELECT e.expenseName,e.expenseValue,e.expenseDescription,u.currency,e.LorA FROM expense e INNER JOIN users u ON e.user_id=u.id WHERE (u.username='" + transactionUsername + "') AND" +
                            "(expenseMonth='" + transactionMonth + "') AND (expenseYear='" + transactionYear + "') AND (LorA='" + LorA + "');";
                    }
                    SQLiteDataReader myReader  = myCommand.ExecuteReader();
                    int adding = 0;
                    while (myReader.Read())
                    {
                        imeTransakcije = myReader.GetString(0);
                        transactionValueTest = myReader.GetDouble(1);
                        opisTransakcijeExpense = myReader.GetString(2);
                        valutaTransakcije = myReader.GetString(3);

                        if (valutaTransakcije == "BAM")
                        {
                            transactionValueTest *= 1.95;
                            valutaPomocna = "KM";
                        }
                        else if (valutaTransakcije == "EUR")
                        {
                            valutaPomocna = "€";
                        }
                        vrijednostTransackije = transactionValueTest.ToString("F");

                        Button opis = new Button();
                        opis.Size = new Size(100, 30);
                        opis.Location = new Point(20, 40 + adding);
                        expensePage.Controls.Add(opis);
                        opis.Text = "Desription";

                        opis.Click += delegate
                        {
                            MessageBox.Show(opisTransakcijeExpense);
                        };


                        Label cijena = new Label();
                        cijena.Size = new Size(100, 30);
                        cijena.Location = new Point(20 + opis.Width + 20, 45 + adding);
                        expensePage.Controls.Add(cijena);
                        cijena.Text = vrijednostTransackije + valutaPomocna;


                        Label ime = new Label();
                        ime.Size = new Size(100, 20);
                        ime.Location = new Point(20 + opis.Width + 20 + cijena.Width + 20, 45 + adding);
                        expensePage.Controls.Add(ime);
                        ime.Text = imeTransakcije;

                        adding += 80;
                    }
                    myCommand.Dispose();
                }
                myConnection.Close();
            }


        }
    }
}
