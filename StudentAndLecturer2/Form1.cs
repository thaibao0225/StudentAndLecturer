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
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Menu menu = new Menu();
            //int choose = Men
            this.Hide();

            if (trash.choose == 1)
            {
                FormAdmin adMin = new FormAdmin();
                adMin.ShowDialog();
            }
            else if(trash.choose == 2)
            {
                Lecturer lecturer = new Lecturer();
                lecturer.ShowDialog();
            }
            else if (trash.choose == 3)
            {
                Student student = new Student();
                student.ShowDialog();
            }
            
        }
    }
}
