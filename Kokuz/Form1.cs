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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        public static string userNameMain;

        // REGISTER
        private void button2_Click(object sender, EventArgs e)
        {

            double balance;
            string check = "";
            int checkUser;
            string valuta = "";


            // Izvuc iz baze da li username vec postoji u bazi
            using (SQLiteConnection myConnection
                = new SQLiteConnection("data source=kokuzDB.db"))
            {
                myConnection.Open();

                using (SQLiteCommand myCommand = new SQLiteCommand(myConnection))
                {
                    myCommand.CommandText = "SELECT COUNT(*) FROM users WHERE username= '"+usernameInput.Text+"';";

                    SQLiteDataReader myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        check = myReader[0].ToString();
                    }

                    myCommand.Dispose();
                }
                myConnection.Close();
            }

            checkUser = Convert.ToInt32(check);
             
            //zamjenjivanje zareza sa tackom
            balanceInput.Text = balanceInput.Text.Replace(",", ".");
            // provjeravanje da li su svi textboxi popunjeni
            if ((String.IsNullOrEmpty(firstNameInput.Text)) || (string.IsNullOrEmpty(lastNameInput.Text)) || (String.IsNullOrEmpty(usernameInput.Text)) || (string.IsNullOrEmpty(passwordInput.Text)) || (string.IsNullOrEmpty(balanceInput.Text)))
            {
                MessageBox.Show("Please fill all the information");
            }

            else if (checkUser != 0)
            {
                MessageBox.Show("username already exist");
            }
            //provjerit da li user vec postoji TO DO 

            //DA LI JE CASH BALANCE PRAVILAN UNOS
            else if (double.TryParse(balanceInput.Text, out balance))
            {
                // preuzimanje unosa iz textboxa
                string ime = firstNameInput.Text,
                priimek = lastNameInput.Text,
                uporabniskoIme = usernameInput.Text,
                geslo = passwordInput.Text,
                stanje = balanceInput.Text;

                //pretvaranje stringa u double
                balance = Convert.ToDouble(stanje);
                if (bamChoose.Checked == true)
                {
                    balance = balance / 1.95;
                    valuta = "BAM";
                }
                else if (eurChoose.Checked == true)
                {
                    valuta = "EUR";
                }
                             
                //stvaranje konekcije
                using (SQLiteConnection myConnection = new SQLiteConnection("data source=kokuzDB.db"))
                {
                    myConnection.Open();

                    using (SQLiteCommand myCommand = new SQLiteCommand(myConnection))
                    {
                        myCommand.CommandText = "INSERT INTO users (firstName,lastName,balance,username,password,currency) VALUES ('" + ime + "' , '" + priimek + "' , '" + balance + "', '" + uporabniskoIme + "' , '" + geslo + "','"+valuta+"'); ";
                        myCommand.ExecuteNonQuery();

                        myCommand.Dispose();
                    }
                    myConnection.Close();
                }


            // ispražnjavanje textboxova
            firstNameInput.Text = "";
            lastNameInput.Text = "";
            usernameInput.Text = "";
            passwordInput.Text = "";
            balanceInput.Text = "";

            //notification about registration
            MessageBox.Show("Successfully Registered. Now just Login");
            }
            // bilo koji drugi error
            else
            {
                MessageBox.Show("Please enter right values");
            }           
        }




        //LOGIN
        private void button1_Click(object sender, EventArgs e)
        {
            Form main = new MainForm();
            string passwordCheck = "", usernameCheckString = "";
            int usernameCheck;


            // CHECK IF USERNAME EXIST
            using (SQLiteConnection myConnection = new SQLiteConnection("data source=kokuzDB.db"))
            {
                myConnection.Open();

                using (SQLiteCommand myCommand = new SQLiteCommand(myConnection))
                {
                    myCommand.CommandText = "SELECT COUNT(*) FROM users WHERE username='"+loginUsernameInput.Text+"';";

                    SQLiteDataReader myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        usernameCheckString = myReader[0].ToString();
                    }

                    myCommand.Dispose();
                }
                myConnection.Close();
            }

            //pretvaranje count string u INT 
            usernameCheck = Convert.ToInt32(usernameCheckString);


            // uslovi da li postoji username
            if (usernameCheck == 0)
            {
                MessageBox.Show("Username don't exist");
            }
            else if (String.IsNullOrEmpty(loginUsernameInput.Text) || string.IsNullOrEmpty(loginPasswordInput.Text))
            {
                MessageBox.Show("Please insert all the informations");
            }
            else
            {
                using (SQLiteConnection myConnection = new SQLiteConnection("data source=kokuzDB.db"))
                {
                    myConnection.Open();

                    using (SQLiteCommand myCommand = new SQLiteCommand(myConnection))
                    {
                        myCommand.CommandText = "SELECT * FROM users WHERE username='"+loginUsernameInput.Text+"';";

                        SQLiteDataReader myReader = myCommand.ExecuteReader();

                        while (myReader.Read())
                        {
                            passwordCheck = myReader.GetString(1);
                        }
                        myCommand.Dispose();
                    }
                    myConnection.Close();
                }

                if (loginPasswordInput.Text == passwordCheck)
                {
                    userNameMain = loginUsernameInput.Text;
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Password Incorrect");
                }

                
            }

        }
        
        
        
        // ne dirat ni pod razno 
        private void loginUsernameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
