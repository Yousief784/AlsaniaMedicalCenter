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
    public partial class printPatientReport : Form
    {
        public static string patinetID; // patientID int
        public static int patientID;//patientID Int

        public printPatientReport(string patinetID)
        {
            InitializeComponent();
            patientID = Int32.Parse(patinetID);
        }

        private void printPatientReport_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string connetionString = connection.database();
            SqlConnection conn = new SqlConnection(connetionString);
            conn.Open();
            string patientInformation = string.Format("select * from Patient where PatientID = {0}", patientID);
            SqlCommand command = new SqlCommand(patientInformation, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable row = new DataTable();
            adapter.Fill(row);
            string showName = row.Rows[0]["PatientName"].ToString();
            string showAge = row.Rows[0]["PatientAge"].ToString();
            string showGender = row.Rows[0]["PatientGender"].ToString();
            string showAddress = row.Rows[0]["PatientAddress"].ToString();
            string showPhone = row.Rows[0]["PatientPhone"].ToString();
            string showDay = row.Rows[0]["PatientNextDateDay"].ToString();
            string showHour = row.Rows[0]["PatientNextDateHour"].ToString();
            string showReport = row.Rows[0]["PatientReport"].ToString();
            string getDoctorID = row.Rows[0]["Doctor"].ToString();
            int intGetDoctorID = Int32.Parse(getDoctorID);

            string DoctorName = string.Format("select DoctorName from Doctor where DoctorID = {0}", intGetDoctorID);
            SqlCommand command2 = new SqlCommand(DoctorName, conn);
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            DataTable row2 = new DataTable();
            adapter2.Fill(row2);
            string showDoctor = row2.Rows[0]["DoctorName"].ToString();

            lblDoctor.Text = showDoctor;
            lblName.Text = showName;
            lblAge.Text = showAge;
            lblGender.Text = showGender;
            lblAddress.Text = showAddress;
            lblPhone.Text = showPhone;
            lblDay.Text = showDay;
            lblHour.Text = showHour;
            lblReport.Text = showReport;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done!!");
            this.Close();
            //login_Patient login_Patient = new login_Patient();
            //this.Hide();
            //login_Patient.ShowDialog();
            //this.Close();
            //printPatientReport printReport = new printPatientReport();
            //printReport.Close();
        }
    }
}
