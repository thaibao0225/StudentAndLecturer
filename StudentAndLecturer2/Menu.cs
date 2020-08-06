using StudentAndLecturer2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            trash.choose = 1;
            nextLogin();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            // chon 2
            trash.choose = 2;
            nextLogin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // chon 3
            trash.choose = 3;
            nextLogin();
        }

        private void nextLogin()
        {
            this.Hide();
            trash.createAdmin();

            trash.fff.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
