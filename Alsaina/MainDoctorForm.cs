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

    public partial class MainDoctorForm : Form
    {
        public static string x;
        public static int intDoctorStartTime;
        public static int intDoctorEndTime;
        public static int[] arrayID; // array to put patient


        public MainDoctorForm(string DoctorID)
        {
            InitializeComponent();
            x = DoctorID;
        
        }

        private void MainDoctorForm_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string connetionString = connection.database();
            SqlConnection conn = new SqlConnection(connetionString);
            conn.Open();
            string getPatientCount = string.Format("select Count(PatientID) as Count from Patient where Doctor = {0}", Int32.Parse(x));
            SqlCommand command4 = new SqlCommand(getPatientCount, conn);
            SqlDataAdapter adapter2 = new SqlDataAdapter(command4);
            DataTable row2 = new DataTable();
            adapter2.Fill(row2);
            string patientCount = row2.Rows[0]["Count"].ToString();
            // 
            string getPatientData = string.Format("select PatientName, PatientID  from Patient where Doctor = {0}", Int32.Parse(x));
            SqlCommand command = new SqlCommand(getPatientData, conn);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            arrayID = new int[Int32.Parse(patientCount)];
            int b = 0;
            while (reader.Read())
            {
                comboPatientNames.Items.Add(reader["PatientName"].ToString());
                string patientID = reader["PatientID"].ToString(); 
                arrayID[b] = Int32.Parse(patientID);
                b++;
            }
            conn.Close();

            conn.Open();
            string showDaysOfWeek = "select dayName from DaysOfWeek";
            SqlCommand command2 = new SqlCommand(showDaysOfWeek, conn);
            SqlDataReader reader2;
            reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                daysOfWeek.Items.Add(reader2["dayName"].ToString());
            }
            conn.Close();

            conn.Open();
            string showHours = string.Format("select DoctorStartTime, DoctorEndTime from Doctor where DoctorID = {0}", Int32.Parse(x));
            SqlCommand command3 = new SqlCommand(showHours, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command3);
            DataTable row = new DataTable();
            adapter.Fill(row);
            string doctorStartTime = row.Rows[0]["DoctorStartTime"].ToString();
            string[] splitStartTime = doctorStartTime.Split(':');
            intDoctorStartTime = Int32.Parse(splitStartTime[0]);
            string doctorEndTime = row.Rows[0]["DoctorEndTime"].ToString();
            string[] splitEndTime = doctorEndTime.Split(':');
            intDoctorEndTime = Int32.Parse(splitEndTime[0]);
            if (intDoctorEndTime > intDoctorStartTime)
            {
                for (int i = intDoctorStartTime; i < intDoctorEndTime; i++)
                {
                    if (i < 10)
                    {
                        comboHour.Items.Add(string.Format("0{0}:00", i));
                    }
                    else
                    {
                        comboHour.Items.Add(string.Format("{0}:00", i));
                    }
                }
            }
            else if (intDoctorEndTime < intDoctorStartTime)
            {

                for (int i = intDoctorStartTime, x = -25; i <= 24 || x < intDoctorEndTime; i++, x++)
                {
                    if (x == 1)
                    {
                        if (x == intDoctorEndTime)
                        {
                            break;
                        }
                        else
                        {
                            comboHour.Items.Add(string.Format("0{0}:00", x));
                        }
                    }
                    if (i == 24)
                    {
                        x = 0;
                        if (doctorEndTime == "00:00")
                        {

                        }
                        else
                        {
                            comboHour.Items.Add(string.Format("00:00", i));
                        }
                    }
                    if (i < 24)
                    {
                        if (i < 10)
                        {
                            comboHour.Items.Add(string.Format("0{0}:00", i));
                        }
                        else
                        {
                            comboHour.Items.Add(string.Format("{0}:00", i));
                        }
                    }
                    if (x > 1) comboHour.Items.Add(string.Format("0{0}:00", x));
                }
            }
            conn.Close();

        }//Form load
        private void showPatientInformation_Click(object sender, EventArgs e)
        {
            try
            {
                Connection connection = new Connection();
                string connetionString = connection.database();
                SqlConnection conn = new SqlConnection(connetionString);
                conn.Open();
                int getpatientindex = comboPatientNames.SelectedIndex;
                string getPatient = string.Format("select PatientName, PatientAge, PatientGender from Patient where PatientID = {0}", arrayID[getpatientindex]);
                SqlCommand command2 = new SqlCommand(getPatient, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command2);
                DataTable row = new DataTable();
                adapter.Fill(row);
                string patientName = row.Rows[0]["PatientName"].ToString();
                string patientAge = row.Rows[0]["PatientAge"].ToString();
                string patientGender = row.Rows[0]["PatientGender"].ToString();
                    
                headName.Visible = true;
                headAge.Visible = true;
                headGender.Visible = true;
                showName.Text = patientName;
                showAge.Text = patientAge;
                showGender.Text = patientGender;
            }
            catch(Exception error)
            {
                MessageBox.Show(""+error);
            }

        }//showPatientInformation

        private void submit_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string connetionString = connection.database();
            SqlConnection conn = new SqlConnection(connetionString);
            conn.Open();
            string stringDay = daysOfWeek.GetItemText(daysOfWeek.SelectedItem);
            string stringHour = comboHour.GetItemText(comboHour.SelectedItem);
            string patientNameIsNull = comboPatientNames.GetItemText(comboPatientNames.SelectedItem);
            string report = txtReport.Text;
            if (stringDay == "" || stringHour == "" || patientNameIsNull == "" || report == "")
            {
                MessageBox.Show("Check Information");
            }
            else
            {
                int getpatientindex = comboPatientNames.SelectedIndex;
                string getPatient = string.Format("select PatientName, PatientAge, PatientGender, PatientID from Patient where PatientID = {0}", arrayID[getpatientindex]);
                SqlCommand command = new SqlCommand(getPatient, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable row = new DataTable();
                adapter.Fill(row);
                string patientName = row.Rows[0]["PatientName"].ToString();
                //patientID = reader["PatientID"].ToString();
                string addToDoctorTable = string.Format("update Patient set PatientReport = '{0}', PatientNextDateDay = '{1}', PatientNextDateHour = '{2}'  where PatientID = {3}", report, stringDay, stringHour, arrayID[getpatientindex]);
                SqlCommand command2 = new SqlCommand(addToDoctorTable, conn);
                command2.ExecuteNonQuery();
                command2.Dispose();
                conn.Close();
                MessageBox.Show("submited!");
            }
        }// submit button

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loginDoctor doctor = new loginDoctor();
            this.Hide();
            doctor.ShowDialog();
            this.Close();
        }// btnLogOut

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}