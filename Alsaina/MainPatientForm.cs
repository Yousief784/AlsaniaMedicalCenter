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
    public partial class MainPatientForm : Form
    {
        public static string patinetID;

        public MainPatientForm(string patientID)
        {
            InitializeComponent();
            patinetID = patientID;
        }

        private void MainPatientForm_Load(object sender, EventArgs e)
        {
            //try
            //{
                Connection connection = new Connection();
                string connetionString = connection.database(); SqlConnection conn = new SqlConnection(connetionString);
                conn.Open();
                // get information from Appointment Table
                string getTime = string.Format("select SelectedDay, SelectedHour from Appointment where PatientAppointmentID = {0}", Int32.Parse(patinetID));
                SqlCommand command = new SqlCommand(getTime, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable row = new DataTable();
                adapter.Fill(row);
                // get information from Patient Table
                string Report = string.Format("select PatientName, PatientGender, PatientReport from Patient where PatientID = {0}", Int32.Parse(patinetID));
                SqlCommand command2 = new SqlCommand(Report, conn);
                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                DataTable row2 = new DataTable();
                adapter2.Fill(row2);
                string showPatientName = row2.Rows[0]["PatientName"].ToString();
                string patientGender = row2.Rows[0]["PatientGender"].ToString();
                string getPatientReport = row2.Rows[0]["PatientReport"].ToString();
                string getPatientDay = row.Rows[0]["SelectedDay"].ToString();
            string getPatientHour = row.Rows[0]["SelectedHour"].ToString();
                if (getPatientReport == "NULL")
                {
                    lblText.Visible = true;
                    lblYourAppointment.Visible = true;
                    lblAppointmentHour.Text = getPatientHour;
                    lblAppointmentDay.Text = getPatientDay;
                }
                else
                {
                    btnPrint.Visible = true;
                }

                if (patientGender == "Male")
                {
                    lblName.Text = "mr " + showPatientName;
                }
                else
                {
                    lblName.Text = "mrs " + showPatientName;
                }
            //}
            //catch(Exception error)
            //{
            //    MessageBox.Show(""+error);
            //}
            
        }// Form Load

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPatientReport printReport = new printPatientReport(patinetID);
            printReport.ShowDialog();
        }// btn Print

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            login_Patient logout = new login_Patient();
            this.Hide();
            logout.ShowDialog();
            this.Close();
        }// LogOut
    }
}