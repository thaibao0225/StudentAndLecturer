using System.Data;
using System.Data.SqlClient;

namespace StudentAndLecturer2
{
    class StudentDB : Person
    {
        public override DataTable GetInf(getSetForm getSet)
        {
            DataTable table = new DataTable();
            sqlcon.Open();
            cmd = new SqlCommand("select St.stdId[ID],St.stdName[Name], St.stdDoB[Day of bird], St.stdEmail[Email]," +
                " St.stdAddress[Address], A.AccUser[User name] , A.AccPassWord[Password], St.AccId[AccId]" +
                " from Student St left join Accounts A on St.AccID = A.AccId", sqlcon);
            rdt = cmd.ExecuteReader();
            table.Load(rdt);
            sqlcon.Close();
            return table;
        }

        public override DataTable GetInf1Person(getSetForm getSet)
        {
            DataTable table = new DataTable();
            sqlcon.Open();
            cmd = new SqlCommand("select St.stdId[ID],St.stdName[Name], St.stdDoB[Day of bird], St.stdEmail[Email]," +
                " St.stdAddress[Address], A.AccUser[User name] , A.AccPassWord[Password], St.AccId[AccId]" +
                " from Student St left join Accounts A on St.AccID = A.AccId where A.AccUser = @AccUser and A.AccPassWord =@AccPassWord ", sqlcon);
            cmd.Parameters.AddWithValue("@AccUser", getSet.UserName1);
            cmd.Parameters.AddWithValue("@AccPassWord", getSet.PassWord1);
            rdt = cmd.ExecuteReader();
            table.Load(rdt);
            sqlcon.Close();
            return table;
        }
        public override DataTable GetBatch(getSetForm getSet)
        {
            DataTable table = new DataTable();
            sqlcon.Open();
            cmd = new SqlCommand("select R.sbjId[Batch ID], S.sbjName[Batch Name] " +
                "from Register R right join Subjects S on S.sbjId = R.sbjId where R.stdId = @ID  ", sqlcon);
            cmd.Parameters.AddWithValue("@ID", getSet.ID1);
            rdt = cmd.ExecuteReader();
            table.Load(rdt);
            sqlcon.Close();
            return table;
        }

        public override DataTable LoadBatch()
        {
            DataTable table = new DataTable();
            sqlcon.Open();
            cmd = new SqlCommand("SELECT sbjId, sbjName FROM Subjects ", sqlcon);
            rdt = cmd.ExecuteReader();
            table.Load(rdt);
            sqlcon.Close();
            return table;
        }

        //
        public override void RegisterBatch(getSetForm getSet)
        {
            cmd = new SqlCommand("insert into Register(reId, stdId, sbjId) values (@reId, @ID, @Sub)", sqlcon);
            cmd.CommandType = CommandType.Text;
            sqlcon.Open();
            cmd.Parameters.AddWithValue("@reId", getSet.ReId1);
            cmd.Parameters.AddWithValue("@ID", getSet.ID1);
            cmd.Parameters.AddWithValue("@Sub", getSet.Batch1);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }


        public override void DeleteAcc(getSetForm getSet)//xoa ben data account
        {
            cmd = new SqlCommand("DELETE  FROM Accounts where AccId =@AccID", sqlcon);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@AccID", getSet.AccID1);
            sqlcon.Open();
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        public override void RegisterAcc(getSetForm getSet)
        {
            cmd = new SqlCommand(// tạo đối tượng chứa dòng lệnh tương tác với đatabase
                   "insert into Accounts (AccId,AccType,AccUser,AccPassWord) " +
                   "values ( @AccID  ,@Type, @UserName,@Password)", sqlcon);
            cmd.CommandType = CommandType.Text;
            sqlcon.Open();
            cmd.Parameters.AddWithValue("@AccId", getSet.AccID1);
            cmd.Parameters.AddWithValue("@Type", getSet.Type1);
            cmd.Parameters.AddWithValue("@UserName", getSet.UserName1);
            cmd.Parameters.AddWithValue("@Password", getSet.PassWord1);
            cmd.ExecuteNonQuery(); //kết quả trả về là số dòng bị ảnh hưởng
            sqlcon.Close();
        }

        public override DataTable Search(string search)
        {
            DataTable table = new DataTable();
            sqlcon.Open();
            cmd = new SqlCommand("SELECT * FROM Student where stdName like '%" + search + "%'", sqlcon);
            rdt = cmd.ExecuteReader();
            table.Load(rdt);
            sqlcon.Close();
            return table;
        }
        public override void Add(getSetForm getSet)
        {
            cmd = new SqlCommand(
                   "insert into Student (stdId,stdName,stdDoB,stdEmail, stdAddress, AccId) " +
                   "values ( @ID, @Name,@Dayofbird,@Email,  @Address, @AccID)", sqlcon);
            cmd.CommandType = CommandType.Text;
            sqlcon.Open();
            cmd.Parameters.AddWithValue("@ID", getSet.ID1);
            cmd.Parameters.AddWithValue("@Name", getSet.Name1);
            cmd.Parameters.AddWithValue("@Dayofbird", getSet.Date1);
            cmd.Parameters.AddWithValue("@Email", getSet.Email1);
            cmd.Parameters.AddWithValue("@Address", getSet.Adddress1);
            cmd.Parameters.AddWithValue("@AccID", getSet.AccID1);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }
        public override void EditAcc(getSetForm getSet)
        {
            sqlcon.Open();
            cmd = new SqlCommand(
               "UPDATE Accounts SET AccUser = @UserName, AccPassWord = @Password WHERE AccId =  @AccID", sqlcon);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@UserName", getSet.UserName1);
            cmd.Parameters.AddWithValue("@Password", getSet.PassWord1);
            cmd.Parameters.AddWithValue("@AccID", getSet.AccID1);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }
        public override void Edit(getSetForm getSet)
        {
            sqlcon.Open();
            cmd = new SqlCommand(
               "UPDATE Student SET stdName = @Name,stdDoB = @Dayofbird,stdEmail = @Email, " +
               "stdAddress = @Address WHERE stdId =@ID", sqlcon);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@Name", getSet.Name1);
            cmd.Parameters.AddWithValue("@Dayofbird", getSet.Date1);
            cmd.Parameters.AddWithValue("@Email", getSet.Email1);
            cmd.Parameters.AddWithValue("@Address", getSet.Adddress1);
            cmd.Parameters.AddWithValue("@AccID", getSet.AccID1);
            cmd.Parameters.AddWithValue("@ID", getSet.ID1);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }
        public override void Delete(getSetForm getSet)//xoa ben inf
        {
            cmd = new SqlCommand("Delete from Student where stdId = @stdId", sqlcon);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@AccId", getSet.AccID1);
            cmd.Parameters.AddWithValue("@stdId", getSet.ID1);
            sqlcon.Open();
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        public override void DeleteBatch(getSetForm getSet)//xoa ben data account
        {
            cmd = new SqlCommand("DELETE FROM Register where stdId =@stdId", sqlcon);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@stdId", getSet.ID1);
            sqlcon.Open();
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

    }
}
