using System;
using System.Windows.Forms;

namespace StudentAndLecturer2
{
    public partial class Student : Form
    {
        Person AStu = new StudentDB();

        getSetForm getSet = new getSetForm();
        public Student()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Management_Load(object sender, EventArgs e)
        {
            GetInfStuForm();
            txtStuId.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            txtStuName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            label12.Text = txtStuName.Text;
            txtStuDate.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            txtStuMail.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            txtStuAddress.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            txtStuUser.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            txtStuPass.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
            txtStuAccid.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
            getSet.ID1 = txtStuId.Text;
            ShowBatchRegis();
        }
        private void GetInfStuForm()
        {
            dataGridView1.DataSource = AStu.GetInf1Person(getSet);
        }
        private void ShowBatchRegis()
        {
            dataGridViewBatch.DataSource = AStu.GetBatch(getSet);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                getSet.UserName1 = txtStuUser.Text;
                getSet.PassWord1 = txtStuPass.Text;
                getSet.AccID1 = txtStuAccid.Text;
                getSet.ID1 = txtStuId.Text;
                getSet.Name1 = txtStuName.Text;
                getSet.Date1 = txtStuDate.Text;
                getSet.Email1 = txtStuMail.Text;
                getSet.Adddress1 = txtStuAddress.Text;
                MessageBox.Show(getSet.AccID1);
                AStu.EditAcc(getSet);
                AStu.Edit(getSet);
                GetInfStuForm();
                MessageBox.Show("completed to upload", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Pls try another ID");
            }
        }

        private void Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentSingleton student = StudentSingleton.GetLoadBalancer();
            student.CloseForm();

            student.deleteForm();

            Menu menu = new Menu();
            menu.ShowDialog();
        }
    }
}
