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
    public partial class toLogin : Form
    {
        loginReception reception = new loginReception();
        loginDoctor doctor = new loginDoctor();
        
        public toLogin()
        {
            InitializeComponent();
        }

        private void btnLoginReception_Click(object sender, EventArgs e)
        {
            this.Hide();
            reception.ShowDialog();
            this.Close();
        }// btnLoginReception

        private void btnLoginDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctor.ShowDialog();
            this.Close();
        }// btnLoginDoctor

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }// btnExit

        private void btnLoginPatient_Click(object sender, EventArgs e)
        {
            login_Patient login_patient = new login_Patient();
            this.Hide();
            login_patient.ShowDialog();
            this.Close();
        }// btnLoginPatient

        private void toLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Connection connection = new Connection();
                string connetionString = connection.database();
                SqlConnection conn = new SqlConnection(connetionString);
                conn.Open();
                conn.Close();
            }
            catch
            {
                Connection connection = new Connection();
                string connetionString = connection.connectToMasterDatabase();
                SqlConnection conn = new SqlConnection(connetionString);
                conn.Open();
                //Create DataBase
                SqlCommand createDataBase = new SqlCommand("create database AlsaniaMedicalCenter", conn);
                createDataBase.ExecuteNonQuery();
                //useDatabase
                SqlCommand useDatabase = new SqlCommand("use AlsaniaMedicalCenter", conn);
                useDatabase.ExecuteNonQuery();
                //Create Access Table
                string createAccessTable = "create table Access(AccessID int primary key identity(1, 1), AccessName varchar(25));";
                SqlCommand CreateAccessQuery = new SqlCommand(createAccessTable, conn);
                CreateAccessQuery.ExecuteNonQuery();
                // Insert into Access Rable
                string insertAccessTable = "insert into Access(AccessName) values('All Access'), ('Add Doctors and Patients'),('Add Patients Only');";
                SqlCommand insertAccessQuery = new SqlCommand(insertAccessTable, conn);
                insertAccessQuery.ExecuteNonQuery();
                //Create Reception Table
                string createReceptionTable = "create table Reception(ReceptionID int primary key identity(1, 1), ReceptionUserName varchar(20) not null unique, ReceptionPassword varchar(10) not null, Access int Foreign key References Access(AccessID) on delete cascade);";
                SqlCommand CreateReceptionQuery = new SqlCommand(createReceptionTable, conn);
                CreateReceptionQuery.ExecuteNonQuery();
                // Insert into Reception //Main Admin
                string insertMainAdmin = "insert into Reception(ReceptionUserName, ReceptionPassword, Access) values ('admin', 'admin', 1);";
                SqlCommand insertMainAdminQuery = new SqlCommand(insertMainAdmin, conn);
                insertMainAdminQuery.ExecuteNonQuery();
                //Create Major Table
                string createMajorTable = "create table Major(MajorID int not null identity(1,1) Primary key, MajorName varchar(50) not null);";
                SqlCommand CreateMajorQuery = new SqlCommand(createMajorTable, conn);
                CreateMajorQuery.ExecuteNonQuery();
                // Create Doctor Table
                string createDoctorTable = "create table Doctor(DoctorID int not null identity(1, 1) primary key,DoctorName varchar(30) not null, DoctorPhone varchar(11) unique not null, DoctorAge int null, DoctorGender varchar(6) null, DoctorStartTime varchar(20), DoctorEndTime varchar(20), DoctorMajor int Foreign key References Major(MajorID));";
                SqlCommand CreateDoctorQuery = new SqlCommand(createDoctorTable, conn);
                CreateDoctorQuery.ExecuteNonQuery();
                // Create Patient Table
                string createPatientTable = "create table Patient(PatientID int identity(1, 1),	PatientName varchar(30) not null, PatientPhone varchar(11) unique not null, PatientAddress varchar(100) null, PatientAge int not null, PatientGender varchar(6) null, PatientReport varchar(2000), PatientNextDateDay varchar(20), PatientNextDateHour varchar(20), Doctor int Foreign key References Doctor(DoctorID), primary key(PatientID)); ";
                SqlCommand CreatePatientQuery = new SqlCommand(createPatientTable, conn);
                CreatePatientQuery.ExecuteNonQuery();
                // Create DaysOfWeek Table
                string createDaysOfWeekTable = "create table DaysOfWeek(dayID int primary key, dayName varchar(20));";
                SqlCommand CreateDaysOfWeekQuery = new SqlCommand(createDaysOfWeekTable, conn);
                CreateDaysOfWeekQuery.ExecuteNonQuery();
                // Insert into DaysOfWeek
                string insertDaysOfWeek = "insert into DaysOfWeek values (1, 'Saturday'), (2, 'Sunday'), (3, 'Monday'), (4, 'Tuesday'), (5, 'Wednesday'), (6, 'Thursday'), (7, 'Friday');";
                SqlCommand insertDaysOfWeekQuery = new SqlCommand(insertDaysOfWeek, conn);
                insertDaysOfWeekQuery.ExecuteNonQuery();
                // Create Appointment Table
                string createAppointmentTable = "create table Appointment(AppointmentID int identity(1, 1) primary key, DoctorAppointmentID int Foreign key References Doctor(DoctorID), PatientAppointmentID int Foreign key References Patient(PatientID), SelectedDay varchar(20), SelectedHour varchar(20)); ";
                SqlCommand createAppointmentQuery = new SqlCommand(createAppointmentTable, conn);
                createAppointmentQuery.ExecuteNonQuery();
                conn.Close();
            }
        }
    }// public class toLogin
}// Namespace
