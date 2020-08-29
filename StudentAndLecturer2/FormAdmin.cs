using System;
using System.Threading;
using System.Windows.Forms;

namespace StudentAndLecturer2
{
    public partial class FormAdmin : Form
    {
        Person AStu = new StudentDB();
        Person ALec = new LecturerDB();


        getSetForm getSet = new getSetForm();
        private int index;


        private void GetLectureInf()
        {
            dataGridLec.DataSource = ALec.GetInf(getSet);
        }
        private void GetStudentInf()
        {
            dataGridStu.DataSource = AStu.GetInf(getSet);
        }

        /// /////////////////////////////////////////////////////////////////
        public void ShowBatchDTLec()
        {
            getSet.ID1 = txtLecID.Text;
            dataGridBatchShow.DataSource = ALec.GetBatch(getSet);
        }
        private void ShowBatchDTStu()
        {
            getSet.ID1 = txtIDStu.Text;
            dataGridBatchShowstu.DataSource = AStu.GetBatch(getSet);
        }
        /// /////////////////////////////////////////////////////////////////

        private void ResetLecInf()
        {
            txtLecID.Clear();
            txtLecName.Clear();
            txtLecDate.Clear();
            txtLecMail.Clear();
            txtLecDateAdd.Clear();
            txtPassWordLec.Clear();
            txtUserNameLec.Clear();
            txtLecAccID.Clear();

        }
        private void ResetStuInf()
        {
            txtIDStu.Clear();
            txtNameStu.Clear();
            txtDateStu.Clear();
            txtMailStu.Clear();
            txtAddStu.Clear();
            txtPassStu.Clear();
            txtUserNameStu.Clear();
            txtAccIdStu.Clear();
        }

        /// /////////////////////////////////////////////////////////////////
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminSingleton admin = AdminSingleton.GetLoadBalancer();
            admin.CloseForm();
            admin.deleteForm();
            Menu menu = new Menu();
            menu.ShowDialog();
        }
        /// /////////////////////////////////////////////////////////////////

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            GetLectureInf();
            GetStudentInf();
            ShowCbbBatchLec();
            ShowCbbBatchStu();
        }
        /// /////////////////////////////////////////////////////////////////

        private void ShowCbbBatchLec()
        {
            cbbBatch.DataSource = ALec.LoadBatch();
            cbbBatch.DisplayMember = "sbjId";
            cbbBatch.ValueMember = "sbjId";
        }
        private void ShowCbbBatchStu()
        {
            cbbBatchIdStu.DataSource = AStu.LoadBatch();
            cbbBatchIdStu.DisplayMember = "sbjId";
            cbbBatchIdStu.ValueMember = "sbjId";
        }
        /////////////////////////////////////////////////////////////////////

        /// /////////////////////////////////////////////////////////////////


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void Button9_Click(object sender, EventArgs e)//add lecture vào db
        {
            try
            {
                getSet.ID1 = txtLecID.Text;
                getSet.Name1 = txtLecName.Text;
                getSet.Date1 = txtLecDate.Text;
                getSet.Email1 = txtLecMail.Text;
                getSet.Adddress1 = txtLecDateAdd.Text;
                getSet.AccID1 = txtLecAccID.Text;
                getSet.UserName1 = txtUserNameLec.Text;
                getSet.PassWord1 = txtPassWordLec.Text;
                getSet.Type1 = "Lecturer";
                ALec.RegisterAcc(getSet);
                Thread.Sleep(1000);
                ALec.Add(getSet);
                GetLectureInf();
                ResetLecInf();

                MessageBox.Show("completed to insert", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Need to fill account inf");
            }
            ///
        }
        private void button5_Click(object sender, EventArgs e)//add student
        {
            try
            {
                getSet.ID1 = txtIDStu.Text;
                getSet.Name1 = txtNameStu.Text;
                getSet.Date1 = txtDateStu.Text;
                getSet.Email1 = txtMailStu.Text;
                getSet.Adddress1 = txtAddStu.Text;
                getSet.AccID1 = txtAccIdStu.Text;
                getSet.UserName1 = txtUserNameStu.Text;
                getSet.PassWord1 = txtPassStu.Text;
                getSet.Type1 = "Student";
                AStu.RegisterAcc(getSet);
                Thread.Sleep(1000);
                AStu.Add(getSet);
                GetStudentInf();
                ResetStuInf();
                MessageBox.Show("completed to insert", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Need to fill account inf");
            }
        }
        /// /////////////////////////////////////////////////////////////////


        private void button8_Click(object sender, EventArgs e)// edit inf of Lecturer
        {
            try
            {
                getSet.UserName1 = txtUserNameLec.Text;
                getSet.PassWord1 = txtPassWordLec.Text;
                getSet.AccID1 = txtLecAccID.Text;
                getSet.ID1 = txtLecID.Text;
                getSet.Name1 = txtLecName.Text;
                getSet.Date1 = txtLecDate.Text;
                getSet.Email1 = txtLecMail.Text;
                getSet.Adddress1 = txtLecDateAdd.Text;
                ALec.EditAcc(getSet);
                ALec.Edit(getSet);
                GetLectureInf();
                MessageBox.Show("completed to upload", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Pls try another ID");
            }

        }

        private void btnEditStu_Click_1(object sender, EventArgs e)
        {
            try
            {
                getSet.UserName1 = txtUserNameStu.Text;
                getSet.PassWord1 = txtPassStu.Text;
                getSet.AccID1 = txtAccIdStu.Text;
                getSet.ID1 = txtIDStu.Text;
                getSet.Name1 = txtNameStu.Text;
                getSet.Date1 = txtDateStu.Text;
                getSet.Email1 = txtMailStu.Text;
                getSet.Adddress1 = txtAddStu.Text;
                MessageBox.Show(getSet.AccID1);
                AStu.EditAcc(getSet);
                AStu.Edit(getSet);
                Thread.Sleep(1000);
                GetStudentInf();
                MessageBox.Show("completed to upload", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Pls try another ID");
            }
        }
        /// /////////////////////////////////////////////////////////////////

        private void Button11_Click(object sender, EventArgs e)//delete lecturer
        {
            ResetBatchDTLec();
            try
            {

                getSet.ID1 = txtLecID.Text;
                getSet.AccID1 = txtLecAccID.Text;
                ALec.DeleteBatch(getSet);
                ALec.Delete(getSet);
                ALec.DeleteAcc(getSet);
                GetLectureInf();
                ResetLecInf();
                MessageBox.Show("completed to delete", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("you need ");
            }
        }
        private void btnDeleteStu_Click_1(object sender, EventArgs e)
        {
            ResetBatchDTStu();
            try
            {
                getSet.ID1 = txtIDStu.Text;
                getSet.AccID1 = txtAccIdStu.Text;
                AStu.DeleteBatch(getSet);
                AStu.Delete(getSet);
                AStu.DeleteAcc(getSet);
                GetStudentInf();
                ResetStuInf();
                MessageBox.Show("completed to delete", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("you need ");
            }
        }
        /// /////////////////////////////////////////////////////////////////


        private void Button10_Click(object sender, EventArgs e)//serarch lecturer
        {
            string searchLec = txtsearchLec.Text;
            dataGridLec.DataSource = ALec.Search(searchLec);
        }

        private void btnSearchStu_Click(object sender, EventArgs e)//serarch student
        {
            string searchStu = txtSearchStu.Text;
            dataGridStu.DataSource = AStu.Search(searchStu);
        }

        /// /////////////////////////////////////////////////////////////////

        private void dataGridStu_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                txtIDStu.Text = dataGridStu.Rows[index].Cells[0].Value.ToString();
                txtNameStu.Text = dataGridStu.Rows[index].Cells[1].Value.ToString();
                txtDateStu.Text = dataGridStu.Rows[index].Cells[2].Value.ToString();
                txtMailStu.Text = dataGridStu.Rows[index].Cells[3].Value.ToString();
                txtAddStu.Text = dataGridStu.Rows[index].Cells[4].Value.ToString();
                txtUserNameStu.Text = dataGridStu.Rows[index].Cells[5].Value.ToString();
                txtPassStu.Text = dataGridStu.Rows[index].Cells[6].Value.ToString();
                txtAccIdStu.Text = dataGridStu.Rows[index].Cells[7].Value.ToString();
                label12.Text = dataGridStu.Rows[index].Cells[1].Value.ToString();
                ShowBatchDTStu();
                RandomId();
            }
        }
        private void dataGridLec_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                txtLecID.Text = dataGridLec.Rows[index].Cells[0].Value.ToString();
                txtLecName.Text = dataGridLec.Rows[index].Cells[1].Value.ToString();
                txtLecDate.Text = dataGridLec.Rows[index].Cells[2].Value.ToString();
                txtLecMail.Text = dataGridLec.Rows[index].Cells[3].Value.ToString();
                txtLecDateAdd.Text = dataGridLec.Rows[index].Cells[4].Value.ToString();
                txtUserNameLec.Text = dataGridLec.Rows[index].Cells[5].Value.ToString();
                txtPassWordLec.Text = dataGridLec.Rows[index].Cells[6].Value.ToString();
                txtLecAccID.Text = dataGridLec.Rows[index].Cells[7].Value.ToString();
                label9.Text = dataGridLec.Rows[index].Cells[1].Value.ToString();
                ShowBatchDTLec();
                RandomId();
            }
        }

        /// ///////////////////////////////////////////////////////////////

        private void ResetBatchDTLec()
        {
            dataGridBatchShow.DataSource = "";
        }

        private void ResetBatchDTStu()
        {
            dataGridBatchShowstu.DataSource = "";
        }
        /// /////////////////////////////////////////////////////////////////


        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label24_Click(object sender, EventArgs e)
        {
        }

        private void label25_Click(object sender, EventArgs e)
        {
        }

        private bool IsValidLecInf()//check emty input
        {
            if (txtLecID.Text == string.Empty || txtLecName.Text == string.Empty || txtLecDate.Text == string.Empty
                || txtLecMail.Text == string.Empty || txtLecDateAdd.Text == string.Empty)
            {
                MessageBox.Show("Some information was not filled");
                return false;
            }
            return true;
        }
        private bool IsValidStuInf()//check emty input
        {
            if (txtAddStu.Text == string.Empty || txtDateStu.Text == string.Empty
                || txtIDStu.Text == string.Empty || txtNameStu.Text == string.Empty)
            {
                MessageBox.Show("Some information was not filled");
                return false;
            }
            return true;
        }

        private void bntRegisterAccount_Click(object sender, EventArgs e)
        {
        }
        /// /////////////////////////////////////////////////////////////////
        private void RandomId()
        {
            Random rand = new Random();
            int number2 = rand.Next(1, 1000);
            txtReID.Text = number2.ToString();
            txtReiDStu.Text = number2.ToString();
        }

        private void button2_Click(object sender, EventArgs e) //LecregisBatch
        {
            bool a = false;

            if (a == false)
            {
                try
                {
                    getSet.ReId1 = txtReID.Text;
                    getSet.Batch1 = cbbBatch.Text;
                    getSet.ID1 = txtLecID.Text;
                    ALec.RegisterBatch(getSet);
                    ShowBatchDTLec();
                    a = true;
                }
                catch
                {
                    a = false;
                }
            }
        }
        private void btnRe_Click(object sender, EventArgs e)
        {
            bool a = false;

            if (a == false)
            {
                try
                {
                    getSet.ReId1 = txtReiDStu.Text;
                    getSet.Batch1 = cbbBatchIdStu.Text;
                    getSet.ID1 = txtIDStu.Text;
                    AStu.RegisterBatch(getSet);
                    ShowBatchDTStu();
                    a = true;
                }
                catch
                {
                    a = false;
                }
            }
        }
        /// /////////////////////////////////////////////////////////////////

        private void DeleteAcc_Click(object sender, EventArgs e)
        {

        }

        private void dataGridBatchShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridLec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cbbBatchIdStu_Click(object sender, EventArgs e)
        {
            RandomId();
        }

        private void cbbBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            RandomId();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e) //Closing
        {
            //Application.Exit();
        }
    }
}
