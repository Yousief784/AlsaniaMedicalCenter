using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// sql
using System.Data.SqlClient;

namespace Alsaina
{
    public partial class loginDoctor : Form
    {
        

        public loginDoctor()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            toLogin toLogin = new toLogin();
            this.Hide();
            toLogin.ShowDialog();
            this.Close();
        }// btnBack

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string connetionString = connection.database();
            SqlConnection conn = new SqlConnection(connetionString);
            conn.Open();
            string showFromMajor = string.Format("select DoctorID, DoctorName, DoctorPhone from Doctor where DoctorPhone = '{0}'", txtUserName.Text);
            SqlCommand command = new SqlCommand(showFromMajor, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable row = new DataTable();
            try
            {
                adapter.Fill(row);
                string phone = row.Rows[0]["DoctorPhone"].ToString();
                string doctorName = row.Rows[0]["DoctorName"].ToString();
                string doctorID = row.Rows[0]["DoctorID"].ToString();
                if (txtUserName.Text == phone && txtPassword.Text == phone)
                {
                    MessageBox.Show("Welcome Doctor " + doctorName);
                    MainDoctorForm MainDoctorForm = new MainDoctorForm(doctorID);
                    this.Hide();
                    MainDoctorForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your username or password is invalid!");
                }
            }
            catch
            {
                MessageBox.Show("Phone Not Found!!");
            }
            conn.Close();
            //while (reader.Read())
            //{
            //    string phone = reader["DoctorPhone"].ToString();
            //    string doctorName = reader["DoctorName"].ToString();
            //    if (txtUserName.Text == phone && txtPassword.Text == phone)
            //    {
            //        MessageBox.Show("Hello Doctor " + doctorName);
            //    }
            //}
        }
    }// public class loginDoctor
}// Namespace