using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagementSystem
{
    public partial class StudentIdividualDetail : Form
    {
        public StudentIdividualDetail()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentIdividualDetail_Load(object sender, EventArgs e)
        {

        }

        private void labelMotherName_Click(object sender, EventArgs e)
        {

        }

        private void labelFullName_Click(object sender, EventArgs e)
        {

        }

        private void labelGender_Click(object sender, EventArgs e)
        {

        }

        private void labelDOB_Click(object sender, EventArgs e)
        {

        }

        private void labelmobile_Click(object sender, EventArgs e)
        {

        }

        private void labelemail_Click(object sender, EventArgs e)
        {

        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB;database = college;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from  NewAdmission where NAID =" + textBox1.Text + "";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {

                labelFullName.Text = ds.Tables[0].Rows[0][1].ToString();
                labelMotherName.Text = ds.Tables[0].Rows[0][2].ToString();
                labelGender.Text = ds.Tables[0].Rows[0][3].ToString();
                labelDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                labelmobile.Text = ds.Tables[0].Rows[0][5].ToString();
                labelemail.Text = ds.Tables[0].Rows[0][6].ToString();
                labelstandard.Text = ds.Tables[0].Rows[0][7].ToString();
                labelmedium.Text = ds.Tables[0].Rows[0][8].ToString();
                labelschoolName.Text = ds.Tables[0].Rows[0][9].ToString();
                labelyear.Text = ds.Tables[0].Rows[0][10].ToString();
                labeladdress.Text = ds.Tables[0].Rows[0][11].ToString();
            }
            else
            {
                MessageBox.Show("No Record Found ", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelFullName.Text = "___________________";
                labelMotherName.Text = "___________________";
                labelGender.Text = "___________________";
                labelDOB.Text = "___________________";
                labelmobile.Text = "___________________";
                labelemail.Text = "___________________";
                labelstandard.Text = "___________________";
                labelmedium.Text = "___________________";
                labelschoolName.Text = "___________________";
                labelyear.Text = "___________________";
                labeladdress.Text = "___________________";
                labeladdress.Text = "___________________";
                textBox1.Text = "";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            labelFullName.Text = "___________________";
            labelMotherName.Text = "___________________";
            labelGender.Text = "___________________";
            labelDOB.Text = "___________________";
            labelmobile.Text = "___________________";
            labelemail.Text = "___________________";
            labelstandard.Text = "___________________";
            labelmedium.Text = "___________________";
            labelschoolName.Text = "___________________";
            labelyear.Text = "___________________";
            labeladdress.Text = "___________________";
            labeladdress.Text = "___________________";
            textBox1.Text = "";

        }
    }
}