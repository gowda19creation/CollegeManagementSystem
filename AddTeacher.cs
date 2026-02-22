using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CollegeManagementSystem
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            string gender = "";
            bool isChecked = radioButtonMale.Checked;

            if (isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB;database = college;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into teacher(fname,gender,dob,mobile,email,semester,prog,yer,adr) values ('" + txtfname.Text + "','" + gender + "','" + dateTimePickerDOB.Text + "'," + txtMobile.Text + ",'" + txtEmail.Text + "','" + txtSemester.Text + "','" + txtProg.Text + "','" + txtDuration.Text + "','" + txtAddress.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            MessageBox.Show("Data saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtfname.Text = "";
            radioButtonMale.Checked= false;
            radioButtonFemale.Checked = false;
            dateTimePickerDOB.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtSemester.Text = "";
            txtProg.Text = "";
            txtDuration.Text = "";
            txtAddress.Text = "";




    }
       
    }
}
