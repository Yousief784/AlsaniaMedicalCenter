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
    public partial class Add_Major : Form
    {
        public static int ReceptionID;

        public Add_Major(int GlopalReceptionID)
        {
            InitializeComponent();
            ReceptionID = GlopalReceptionID;
        }

        private void btnAddMajor_Click(object sender, EventArgs e)
        {
            string MajorName = txtMajorName.Text;
            if (MajorName == "")
            {
                MessageBox.Show("Fill Major Input Field");
            }
            else
            {
                    Connection connection = new Connection();
                    string connetionString = connection.database();
                    SqlConnection conn = new SqlConnection(connetionString);
                    conn.Open();
                    string addToDoctorTable = string.Format("insert into Major(MajorName) values('{0}')", MajorName);
                    SqlCommand command = new SqlCommand(addToDoctorTable, conn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    conn.Close();
                    MessageBox.Show("Added");
                    txtMajorName.Text = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Add add = new Add(ReceptionID);
            this.Hide();
            add.ShowDialog();
            this.Close();
        }

        private void Add_Major_Load(object sender, EventArgs e)
        {

        }
    }
}
