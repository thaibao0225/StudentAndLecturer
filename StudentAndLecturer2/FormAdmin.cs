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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trash.BackToMenu();
        }
    }
}
