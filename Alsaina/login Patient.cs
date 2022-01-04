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
    public partial class login_Patient : Form
    {
        public login_Patient()
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
            try
            {
                Connection connection = new Connection();
                string connetionString = connection.database(); SqlConnection conn = new SqlConnection(connetionString);
                conn.Open();
                string showFromMajor = string.Format("select PatientID, PatientName, PatientPhone, PatientGender from Patient where PatientPhone = '{0}'", txtUserName.Text);
                SqlCommand command = new SqlCommand(showFromMajor, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable row = new DataTable();
                adapter.Fill(row);
                string patientID = row.Rows[0]["PatientID"].ToString();
                string phone = row.Rows[0]["PatientPhone"].ToString();
                string paientName = row.Rows[0]["PatientName"].ToString();
                string patientGender = row.Rows[0]["PatientGender"].ToString();
                if (txtUserName.Text == phone && txtPassword.Text == phone)
                {
                    MainPatientForm MainPatientForm = new MainPatientForm(patientID);
                    this.Hide();
                    MainPatientForm.ShowDialog();
                    this.Close();
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Phone Not Found!!");
            }
        }
    }// public class loginPatient
}// Namespace
