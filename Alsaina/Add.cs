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
    public partial class Add : Form
    {
        public static int GlopalReceptionID;

        public Add(int ReceptionID)
        {
            InitializeComponent();
            GlopalReceptionID = ReceptionID;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string connetionString = connection.database();
            SqlConnection conn = new SqlConnection(connetionString);
            conn.Open();
            string getReceptiondata = string.Format("select Access from Reception where ReceptionID = {0}", GlopalReceptionID);
            SqlCommand command = new SqlCommand(getReceptiondata, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable row = new DataTable();
            adapter.Fill(row);
            string Access = row.Rows[0]["Access"].ToString();
            if (Int32.Parse(Access) == 1)
            {
                btnAddDoctor.Visible = true;
                btnAddMajor.Visible = true;
                btnAddReception.Visible = true;
            }else if (Int32.Parse(Access) == 2)
            {
                btnAddDoctor.Visible = true;
            }

        }// Form Load

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            addPatient addPatient = new addPatient(GlopalReceptionID);
            this.Hide();
            addPatient.ShowDialog();
            this.Close();
        }// btnAddPatient

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            addDoctor addDoctor = new addDoctor(GlopalReceptionID);
            this.Hide();
            addDoctor.ShowDialog();
            this.Close();
        }// btnAddDoctor

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            loginReception reception = new loginReception();
            this.Hide();
            reception.ShowDialog();
            this.Close();
        }// btnLogOut

        private void btnAddMajor_Click(object sender, EventArgs e)
        {
            Add_Major majorForm = new Add_Major(GlopalReceptionID);
            this.Hide();
            majorForm.ShowDialog();
            this.Close();
        }

        private void btnAddReception_Click(object sender, EventArgs e)
        {
            Add_Reception addReception = new Add_Reception(GlopalReceptionID);
            this.Hide();
            addReception.ShowDialog();
            this.Close();
        }
    }// public class Add
}// Namespace
