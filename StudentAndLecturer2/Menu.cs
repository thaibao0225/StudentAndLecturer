using StudentAndLecturer2.Properties;
using System;
using System.Windows.Forms;

namespace StudentAndLecturer2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e) // admin
        {
            // chon 1
            Process.choose = 1;
            nextLogin();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            // chon 2
            Process.choose = 2;
            nextLogin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // chon 3
            Process.choose = 3;
            nextLogin();
        }

        private void nextLogin()
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
