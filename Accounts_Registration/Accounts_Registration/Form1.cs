using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Accounts_Registration
{
    public partial class account_login : Form
    {
        OleDbConnection connection = new OleDbConnection();


        public account_login()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\UNIVERSITY\ALL SEMESTERS\SEMESTER 5\C #\Project for Contact Record\registration.mdb";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                checkConnection.Text = "Conncetion Successful";
                connection.Close();
            } catch( Exception ex)
            {
                MessageBox.Show("Not Successful" + ex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from admin_table where admin_name='"+user_name.Text+"' and admin_pass = '"+user_password.Text+"' ";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count == 1)
            {
                MessageBox.Show("LogIn Successful");
                connection.Close();
                Account_Registration f2 = new Account_Registration();
                f2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Wrong User or Password...");
            }
           

        }
    }
}
