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
    public partial class Account_Registration : Form
    {
        OleDbConnection connection = new OleDbConnection();
                
        public Account_Registration()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\UNIVERSITY\ALL SEMESTERS\SEMESTER 5\C #\Project for Contact Record\registration.mdb";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into user_Table (f_name, l_name, dob, phone_no, address, social_app, email, u_password) values('"+f_name.Text +"','"+l_name.Text+ "','"+dob.Text+"', '" +phone_no.Text+ "',  '" + u_address.Text + "', '" +social_app.Text + "', '" + u_email.Text + "', '" +u_password.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void Account_Registration_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                db_connect.Text = "Connection Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Successful" + ex);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update user_Table set f_name ='" + f_name.Text + "', l_name='"+l_name.Text+"', dob='"+dob.Text+"', phone_no='"+phone_no.Text+"', address='"+u_address.Text+"', social_app='"+social_app.Text+"', email='"+u_email.Text+"', u_password='"+u_password.Text+"' where id="+user_id.Text+"  ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Data Updated");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from user_Table where id="+user_id.Text+" ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            view_form f2 = new view_form();
            f2.ShowDialog();
        }
    }
}
