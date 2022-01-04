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
    public partial class Add_Reception : Form
    {
        public static int ReceptionID;
        public static int[] arrayAccessID = new int[2];

        public Add_Reception(int GlopalReceptionID)
        {
            InitializeComponent();
            ReceptionID = GlopalReceptionID;
        }

        private void Add_Reception_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string connetionString = connection.database();
            SqlConnection conn = new SqlConnection(connetionString);
            conn.Open();
            string showFromMajor = "select * from Access";
            SqlCommand command = new SqlCommand(showFromMajor, conn);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            int i = 1;
            int b = 0;
            while (reader.Read())
            {
                if (i == 1)
                {
                    //int AccessID = Int32.Parse(reader["AccessID"].ToString());
                    //MessageBox.Show("From if Access ID = " + AccessID);
                }
                else
                {
                    int AccessID = Int32.Parse(reader["AccessID"].ToString());
                    //MessageBox.Show("From else Access ID = "+AccessID);
                    //MessageBox.Show("b = " + b);
                    comboAccess.Items.Add(reader["AccessName"].ToString());
                    arrayAccessID[b] = AccessID;
                    b++;
                    //MessageBox.Show("b = " + b);
                    //MessageBox.Show("Array AccessID[b] = " + arrayAccessID[b]);
                }
                i++;
            }
            conn.Close();
        }


        private void btnAddReception_Click_1(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string connetionString = connection.database();
            SqlConnection conn = new SqlConnection(connetionString);
            conn.Open();
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string getAccessIndexString = comboAccess.GetItemText(comboAccess.SelectedItem);
            if (username == "" || password == "" || getAccessIndexString == "")
            {
                MessageBox.Show("Check Information");
            }
            else
            {
                try
                {
                    int getAccessindex = comboAccess.SelectedIndex;
                    string addToReceptionTable = string.Format("insert into Reception(ReceptionUserName, ReceptionPassword, Access) values ('{0}', '{1}', {2});", username, password, arrayAccessID[getAccessindex]);
                    SqlCommand command2 = new SqlCommand(addToReceptionTable, conn);
                    command2.ExecuteNonQuery();
                    command2.Dispose();
                    conn.Close();
                    MessageBox.Show("Added!");
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                }
                catch
                {
                    MessageBox.Show("Check Username");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Add add = new Add(ReceptionID);
            this.Hide();
            add.ShowDialog();
            this.Close();
        }
    }
}