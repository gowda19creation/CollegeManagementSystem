using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Versioning;
using System.Diagnostics.Eventing.Reader;

namespace CollegeManagementSystem
{
    public partial class Fess : Form
    {
        public Fess()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Fess_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=(localdb)\\MSSQLLocalDB;database =college;integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from  fees where NAID  =" + txtRegNumber.Text + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);




            if (DS.Tables[0].Rows.Count == 0)
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source=(localdb)\\MSSQLLocalDB;database =college;integrated security =True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;

                cmd1.CommandText = "insert into fees(NAID,fees) values (" + txtRegNumber.Text + "," + txtFees.Text + ")";

                SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);

                if (MessageBox.Show("Fees Submition Successfull.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    txtRegNumber.Text = "";
                    txtFees.Text = "";
                    fnamelabel1.Text = "_____________________";
                    mnamelabel2.Text = "_____________________";
                    durationlabel3.Text = "_____________________";
                }
            }
            else
            {
                MessageBox.Show("Fees is AllReady Submitted.");
                     txtRegNumber.Text = "";
                txtFees.Text = "";
                fnamelabel1.Text = "_____________________";
                mnamelabel2.Text = "_____________________";
                durationlabel3.Text = "_____________________";
            }

        }
    



      private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtRegNumber_TextChanged(object sender, EventArgs e)
        {
            if(txtRegNumber.Text!= "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=(localdb)\\MSSQLLocalDB;database =college;integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select fname,mname,duration from NewAdmission where NAID =" + txtRegNumber.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);//kiran xyz 2024-2027

                if (DS.Tables[0].Rows.Count != 0)
                {
                    fnamelabel1.Text = DS.Tables[0].Rows[0][0].ToString();
                    mnamelabel2.Text = DS.Tables[0].Rows[0][1].ToString();
                    durationlabel3.Text = DS.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    fnamelabel1.Text = "_____________________";
                    mnamelabel2.Text = "_____________________";
                    durationlabel3.Text = "_____________________";
                }
            }
            else
            {
                txtRegNumber.Text = "";
                txtFees.Text = "";
                fnamelabel1.Text = "_____________________";
                mnamelabel2.Text = "_____________________";
                durationlabel3.Text = "_____________________";
            } 
        }
            
    }
}

