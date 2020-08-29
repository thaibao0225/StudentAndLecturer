using System;
using System.Windows.Forms;

namespace StudentAndLecturer2
{

    public partial class Lecturer : Form
    {
        int index;
        Person ALec = new LecturerDB();
        Person AStu = new StudentDB();
        getSetForm getSet = new getSetForm();
        public Lecturer()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void GetInfLecForm()
        {
            dataGridViewInff.DataSource = ALec.GetInf1Person(getSet);
        }
        private void ShowBatchRegis()
        {
            dataGridViewBatch.DataSource = ALec.GetBatch(getSet);
        }
        private void btnaddstu_Click(object sender, EventArgs e)
        {

        }
        private void ShowBatchDTStu()
        {
            getSet.ID1 = txtStuIDStu.Text;
            dataGridView2.DataSource = AStu.GetBatch(getSet);
        }
        private void Lecturer_Load(object sender, EventArgs e)
        {
            GetInfLecForm();
            txtIdLec.Text = dataGridViewInff.Rows[0].Cells[0].Value.ToString();
            txtNameLec.Text = dataGridViewInff.Rows[0].Cells[1].Value.ToString();
            txtDateLec.Text = dataGridViewInff.Rows[0].Cells[2].Value.ToString();
            txtMailLec.Text = dataGridViewInff.Rows[0].Cells[3].Value.ToString();
            txtAddLec.Text = dataGridViewInff.Rows[0].Cells[4].Value.ToString();
            txtUserName.Text = dataGridViewInff.Rows[0].Cells[5].Value.ToString();
            txtPassword.Text = dataGridViewInff.Rows[0].Cells[6].Value.ToString();
            txtAccId.Text = dataGridViewInff.Rows[0].Cells[7].Value.ToString();
            getSet.ID1 = txtIdLec.Text;
            label27.Text = txtNameLec.Text;
            ShowBatchRegis(); ;
            GetStudentInf();

        }
        private void GetStudentInf()
        {
            dataGridView1.DataSource = AStu.GetInf(getSet);
        }
        private void btnEditLec_Click(object sender, EventArgs e)
        {
            try
            {
                getSet.UserName1 = txtUserName.Text;
                getSet.PassWord1 = txtPassword.Text;
                getSet.AccID1 = txtAccId.Text;
                getSet.ID1 = txtIdLec.Text;
                getSet.Name1 = txtNameLec.Text;
                getSet.Date1 = txtDateLec.Text;
                getSet.Email1 = txtMailLec.Text;
                getSet.Adddress1 = txtAddLec.Text;
                MessageBox.Show(getSet.AccID1);
                ALec.EditAcc(getSet);
                ALec.Edit(getSet);
                GetInfLecForm();
                MessageBox.Show("completed to upload", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Pls try another ID");
            }
        }

        private void btnsearchStu_Click(object sender, EventArgs e)
        {
            string searchStu = txtSearchStu.Text;
            dataGridView1.DataSource = AStu.Search(searchStu);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                txtStuIDStu.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txtStuNameStu.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txtStuDateStu.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                txtStuEmailStu.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                txtStuAddStu.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                txtUserNameStu.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                txtPassStu.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
                txtAcIdStu.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
                label11.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                ShowBatchDTStu();
            }
        }

        private void Lecturer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LecturerSingleton lecturer = LecturerSingleton.GetLoadBalancer();
            lecturer.CloseForm();

            lecturer.deleteForm();

            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
