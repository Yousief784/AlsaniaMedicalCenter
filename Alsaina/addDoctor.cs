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
    public partial class addDoctor : Form
    {
        public static int ReceptionID;

        public addDoctor(int GlopalReceptionID)
        {
            InitializeComponent();
            ReceptionID = GlopalReceptionID;
        }

        private void addDoctor_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string connetionString = connection.database();
            SqlConnection conn = new SqlConnection(connetionString);
            conn.Open();
            string showFromMajor = "select MajorName from Major";
            SqlCommand command = new SqlCommand(showFromMajor, conn);
            SqlDataReader reader;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                doctorMajor.Items.Add(reader["MajorName"].ToString());
            }//end while

            conn.Close();
            for (int i =0; i < 24; i++)
            {
                if (i < 10)
                {
                    comboStartTime.Items.Add(string.Format("0{0}:00", i));
                    comboEndTime.Items.Add(string.Format("0{0}:00", i));
                }
                else
                {
                    comboStartTime.Items.Add(string.Format("{0}:00", i));
                    comboEndTime.Items.Add(string.Format("{0}:00", i));
                }
                
            }
        }// Form load

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string ageString = txtAge.Text;
            string stringStartTime = comboStartTime.GetItemText(comboStartTime.SelectedItem);
            string stringEndTime = comboEndTime.GetItemText(comboEndTime.SelectedItem);
            string gender;

            if (radioMale.Checked)
            {
                gender = "Male";
            }//if
            else if(radioFemale.Checked)
            {
                gender = "Female";
            }//else if
            else
            {
                gender = "";
            }

            string majorString = doctorMajor.GetItemText(doctorMajor.SelectedIndex);

            if (name == "" || phone == "" || ageString == "" || gender == "" || stringStartTime == "" || stringEndTime == "" || majorString == "")
            {
                MessageBox.Show("Check Information");
            }
            else
            {
                int age = Int32.Parse(ageString);
                int major = doctorMajor.SelectedIndex;
                try
                {
                    Connection connection = new Connection();
                    string connetionString = connection.database();
                    SqlConnection conn = new SqlConnection(connetionString);
                    conn.Open();
                    string addToDoctorTable = string.Format("insert into Doctor(DoctorName, DoctorPhone, DoctorAge, DoctorMajor, DoctorGender, DoctorStartTime, DoctorEndTime) values ('{0}', '{1}', {2}, {3}, '{4}', '{5}', '{6}');", name, phone, age, ++major, gender, stringStartTime, stringEndTime);
                    SqlCommand command = new SqlCommand(addToDoctorTable, conn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    conn.Close();
                    MessageBox.Show("Doctor Added");
                    txtName.Text = "";
                    txtAge.Text = "";
                    txtPhone.Text = "";
                    radioMale.Checked = false;
                    radioFemale.Checked = false;
                }// try
                catch
                {
                    MessageBox.Show("Check Phone!");
                }// catch
            }

            }// btn Add

        private void btnBack_Click(object sender, EventArgs e)
        {
            Add add = new Add(ReceptionID);
            this.Hide();
            add.ShowDialog();
            this.Close();

        }// btnBack

    }// public class addDoctor 
}// Namespace
