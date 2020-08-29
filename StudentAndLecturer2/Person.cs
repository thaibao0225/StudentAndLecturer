using System.Data;
using System.Data.SqlClient;

namespace StudentAndLecturer2
{
    abstract class Person
    {
        protected SqlConnection sqlcon = new SqlConnection(SqlConnectionn.Connection());
        protected SqlCommand cmd;
        protected SqlDataReader rdt;
        public abstract DataTable GetInf(getSetForm getSet);
        public abstract DataTable Search(string search);
        public abstract void Add(getSetForm getSet);
        public abstract void Edit(getSetForm getSet);
        public abstract void Delete(getSetForm getSet);
        public abstract void RegisterAcc(getSetForm getSet);

        public abstract void DeleteAcc(getSetForm getSet);
        public abstract DataTable LoadBatch();
        //public abstract void RegisterBatch(getSetAdminForm getSet);
        public abstract void EditAcc(getSetForm getSet);
        public abstract DataTable GetBatch(getSetForm getSet);
        public abstract void RegisterBatch(getSetForm getSet);
        public abstract void DeleteBatch(getSetForm getSet);
        public abstract DataTable GetInf1Person(getSetForm getSet);
    }
}
