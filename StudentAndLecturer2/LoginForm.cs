using StudentAndLecturer2.Properties;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAndLecturer2
{
    public partial class LoginForm : Form
    {
        SqlConnection sqlcon = new SqlConnection(SqlConnectionn.Connection());
        getSetForm getSet = new getSetForm();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getSet.UserName1 = txtUser.Text;
            getSet.PassWord1 = txtPass.Text; ;
        }

        private bool AdminLogin()
        {

            sqlcon.Open();
            string query = "select * from Accounts where AccUser= '" + txtUser.Text + "'and AccPassWord='" + txtPass.Text + "' and AccType='" + "Admin" + "'";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader rdt = cmd.ExecuteReader();
            bool readDt = rdt.Read();
            return readDt;
        }
        private bool StudentLogin()
        {
            sqlcon.Open();
            string query = "select * from Accounts where AccUser= '" + txtUser.Text + "'and AccPassWord='" + txtPass.Text + "'and AccType='" + "Student" + "'";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader rdt = cmd.ExecuteReader();
            bool readDt = rdt.Read();
            return readDt;
        }
        private bool LecturerLogin()
        {
            sqlcon.Open();
            string query = "select * from Accounts where AccUser= '" + txtUser.Text + "'and AccPassWord='" + txtPass.Text + "'and AccType='" + "Lecturer" + "'";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader rdt = cmd.ExecuteReader();
            bool readDt = rdt.Read();
            return readDt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Process.choose == 1)
            {
                if (AdminLogin() == true)
                {

                    this.Hide();
                    AdminSingleton adminForm = AdminSingleton.GetLoadBalancer();
                    adminForm.OpenForm();
                }
                else
                {
                    MessageBox.Show("wrong");
                }
            }
            else if (Process.choose == 2)
            {
                if (LecturerLogin() == true)
                {
                    getSet.UserName1 = txtUser.Text;
                    getSet.PassWord1 = txtPass.Text;
                    this.Hide();
                    LecturerSingleton lecturer = LecturerSingleton.GetLoadBalancer();
                    lecturer.OpenForm();
                }
                else
                {
                    MessageBox.Show("wrong");
                }
            }
            else if (Process.choose == 3)
            {
                if (StudentLogin() == true)
                {
                    getSet.UserName1 = txtUser.Text;
                    getSet.PassWord1 = txtPass.Text;
                    this.Hide();
                    StudentSingleton student = StudentSingleton.GetLoadBalancer();
                    student.OpenForm();
                }
                else
                {
                    MessageBox.Show("wrong");
                }
            }
            sqlcon.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
