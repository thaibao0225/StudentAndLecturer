namespace StudentAndLecturer2
{
    interface IBuilder
    {
        public GetSetBuilder AddReId1(string ReId1);
        public GetSetBuilder AddBatch1(string Batch1);
        public GetSetBuilder AddID1(string ID1);
        public GetSetBuilder AddName1(string Name1);
        public GetSetBuilder AddDate1(string Date1);
        public GetSetBuilder AddEmail1(string Email1);
        public GetSetBuilder AddAdddress1(string Adddress1);
        public GetSetBuilder AddUserName1(string UserName1);
        public GetSetBuilder AddPassWord1(string PassWord1);
        public GetSetBuilder AddAccID1(string AccID1);
        public GetSetBuilder AddType1(string Type1);

        public getSetForm Build();


    }
}
