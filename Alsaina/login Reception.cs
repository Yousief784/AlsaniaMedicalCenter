using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sql
using System.Data.SqlClient;

namespace Alsaina
{
    public partial class loginReception : Form
    {
        
        public loginReception()
        {
            InitializeComponent();
        }

        private void reception_Load(object sender, EventArgs e)
        {

        }// reception load(form)

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
                Connection connection = new Connection();
                string connetionString = connection.database();
                SqlConnection conn = new SqlConnection(connetionString);
                conn.Open();
                string getReceptiondata = string.Format("select ReceptionID, ReceptionUserName, ReceptionPassword from Reception where ReceptionUserName = '{0}'", txtUserName.Text);
                SqlCommand command = new SqlCommand(getReceptiondata, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable row = new DataTable();
                
                    adapter.Fill(row);
            try
            {
                string userName = row.Rows[0]["ReceptionUserName"].ToString();
                string password = row.Rows[0]["ReceptionPassword"].ToString();
                string ReceptionID = row.Rows[0]["ReceptionID"].ToString();
                if (txtUserName.Text == userName && txtPassword.Text == password)
                {
                    MessageBox.Show("Welcome " + userName);
                    Add add = new Add(Int32.Parse(ReceptionID));
                    this.Hide();
                    add.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your username or password is invalid!");
                }
            }
            catch
            {
                MessageBox.Show("Return to Manager to SignUp in Application");
            }                
            conn.Close();
            }// btnLogin

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            toLogin toLogin = new toLogin();
            this.Hide();
            toLogin.ShowDialog();
            this.Close(); 
        }
    }// public class loginReception
}// Namespace