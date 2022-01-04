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
    public partial class addPatient : Form
    {
        //Global Virables
        public static int intDoctorStartTime;
        public static int intDoctorEndTime;
        public static string DoctorHour;
        public static string DoctorDay;
        public static int ReceptionID;

        public addPatient(int GlopalReceptionID)
        {
            InitializeComponent();
            ReceptionID = GlopalReceptionID;
        }

        private void addPatient_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string connetionString = connection.database();
            SqlConnection conn = new SqlConnection(connetionString);
            conn.Open();
            string showFromMajor = "select DoctorName from Doctor";
            SqlCommand command = new SqlCommand(showFromMajor, conn);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboChooseDoctor.Items.Add(reader["DoctorName"].ToString());
            }
            reader.Close();
            string showDaysOfWeek = "select dayName from DaysOfWeek";
            SqlCommand command2 = new SqlCommand(showDaysOfWeek, conn);
            SqlDataReader reader2;
            reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                comboDay.Items.Add(reader2["dayName"].ToString());
            }
            conn.Close();
        }// Form load

        private void btnHour_Click(object sender, EventArgs e)
        {
            comboHour.Items.Clear();
            int selectedItem = comboChooseDoctor.SelectedIndex;
            Connection connection = new Connection();
            string connetionString = connection.database();
            SqlConnection conn = new SqlConnection(connetionString);
            conn.Open();
            string showHours = string.Format("select DoctorStartTime, DoctorEndTime from Doctor where DoctorID = {0}", ++selectedItem);
            SqlCommand command3 = new SqlCommand(showHours, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command3);
            DataTable row = new DataTable();
            adapter.Fill(row);
            string day = comboDay.GetItemText(comboDay.SelectedItem);
            if (day=="")
            {
                MessageBox.Show("Choose Day");
            }
            else
            {
                try
            {
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

                    for (int i = intDoctorStartTime, x = -50; i <= 24 || x < intDoctorEndTime; i++, x++)
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
                }// end else
                string getTime = string.Format("select SelectedDay, SelectedHour from Appointment where DoctorAppointmentID = {0}", selectedItem);
                SqlCommand command = new SqlCommand(getTime, conn);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DoctorHour = reader["SelectedHour"].ToString();
                    DoctorDay = reader["SelectedDay"].ToString();
                    string patientAppointmentHour = comboHour.GetItemText(comboDay.SelectedItem);
                    bool boolDoctorHour = comboHour.Items.Contains(DoctorHour);
                    if (boolDoctorHour && patientAppointmentHour== DoctorDay)
                    {
                        comboHour.Items.Remove(DoctorHour);
                    }
                }
                reader.Close();
                
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Please choose Doctor and Day");
            }
            }
        }// btnHour

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //insert into Patient(PatientName, PatientPhone, PatientAddress, PatientAge, PatientGender, Doctor) values('Khaled', '01004575', 'Mans', 26, 'Male', 1)
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string ageString = txtAge.Text;
            string gender;
            if (radioMale.Checked)
            {
                gender = "Male";
            }
            else if(radioFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "";
            }
            int doctorID = comboChooseDoctor.SelectedIndex;
            string doctorIDString = comboChooseDoctor.GetItemText(comboChooseDoctor.SelectedItem);
            string patientAppointmentDay = comboDay.GetItemText(comboDay.SelectedItem);
            string patientAppointmentHour = comboHour.GetItemText(comboHour.SelectedItem);
            if (name == "" || phone == "" || address == "" || ageString == "" || gender == "" || patientAppointmentHour == "" || patientAppointmentDay == "" || doctorIDString == "")
            {
                MessageBox.Show("Check Information");
            }else
            {
                int age = Int32.Parse(ageString);
                try
                {
                    Connection connection = new Connection();
                    string connetionString = connection.database();
                    SqlConnection conn = new SqlConnection(connetionString);
                    conn.Open();
                    //insert into Patient Table
                    string addToPatientTable = string.Format("insert into Patient(PatientName, PatientPhone, PatientAge, PatientAddress, PatientGender, Doctor, PatientReport) values('{0}', '{1}', {2}, '{3}', '{4}', {5}, 'NULL')", name, phone, age, address, gender, ++doctorID);
                    SqlCommand command = new SqlCommand(addToPatientTable, conn);
                    command.ExecuteNonQuery();
                    // get Patient id
                    string getPatientIDQuery = string.Format("select PatientID from Patient where PatientPhone = '{0}'", phone);
                    SqlCommand command2 = new SqlCommand(getPatientIDQuery, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(command2);
                    DataTable row = new DataTable();
                    adapter.Fill(row);
                    string getPatientID = row.Rows[0]["PatientID"].ToString();
                    //insert into Appointment Table
                    string addToAppointmentTable = string.Format("insert into Appointment(DoctorAppointmentID, PatientAppointmentID, SelectedDay, SelectedHour) values({0}, {1}, '{2}', '{3}')", doctorID, Int32.Parse(getPatientID), patientAppointmentDay, patientAppointmentHour);
                    SqlCommand command3 = new SqlCommand(addToAppointmentTable, conn);
                    command3.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Patient Added");
                    txtName.Text = "";
                    txtAge.Text = "";
                    txtPhone.Text = "";
                    txtAddress.Text = "";
                    radioMale.Checked = false;
                    radioFemale.Checked = false;
                    //Appointment
                    string getAppointment = string.Format("select SelectedHour from Appointment where PatientAppointmentID = {0}", getPatientID);
                    SqlCommand command4 = new SqlCommand(getAppointment, conn);
                    SqlDataAdapter adapter2 = new SqlDataAdapter(command4);
                    DataTable row2 = new DataTable();
                    adapter2.Fill(row2);
                    string getTime = row2.Rows[0]["SelectedHour"].ToString();
                    comboHour.Items.Remove(getTime);
                }
                catch
                {
                    MessageBox.Show("Check Phone Number!!!");
                }
            }
}// btn Confirm

        private void btnBack_Click(object sender, EventArgs e)
        {
            Add add = new Add(ReceptionID);
            this.Hide();
            add.ShowDialog();
            this.Close();
        }// btnBack

    }// public class Patient
}//Namespace