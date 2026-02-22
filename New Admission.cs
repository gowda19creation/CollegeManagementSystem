using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CollegeManagementSystem
{
    public partial class New_Admission : Form
    {
        public New_Admission()
        {
            InitializeComponent();
        }

        private void New_Admission_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(localdb)\\MSSQLLocalDB;database=college;integrated security =true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT MAX(NAID) FROM NewAdmission";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            label13.Text = (abc+1).ToString();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text;
            string mname = txtMotherName.Text;
            string gender = "";
            bool isChecked = radioButtonMale.Checked;
            if(isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }

            string dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            string email = txtEmail.Text;
            string semester = txtsemister.Text;
            string program = txtprogramming.Text;
            string sname = txtSchoolName.Text;
            string duration = txtDuration.Text;
            string address = txtAddress.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =(localdb)\\MSSQLLocalDB;database=college;integrated security =true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = " insert into NewAdmission (fname,mname,gender,dob,mobile,email,semester,prog,sname,duration,address) values ('" + name + "', '" + mname + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + semester + "','" + program + "','" + sname + "','" + duration + "','" + address + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            MessageBox.Show("Data saved.Remeber the Registration ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtAddress.Clear();
            txtMotherName.Clear();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            txtMobileNo.Clear();
            txtprogramming.ResetText();
            txtsemister.ResetText();
            txtSchoolName.Clear();
            txtDuration.ResetText();
            txtEmail.Clear();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
