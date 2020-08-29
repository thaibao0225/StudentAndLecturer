namespace StudentAndLecturer2
{
    class GetSetBuilder : IBuilder
    {
        public string ReId1 { get; set; }
        public string Batch1 { get; set; }
        public string ID1 { get; set; }
        public string Name1 { get; set; }
        public string Date1 { get; set; }
        public string Email1 { get; set; }
        public string Adddress1 { get; set; }
        public string UserName1 { get; set; }
        public string PassWord1 { get; set; }
        public string AccID1 { get; set; }
        public string Type1 { get; set; }

        public GetSetBuilder AddAccID1(string AccID1)
        {
            this.AccID1 = AccID1;
            return this;
        }

        public GetSetBuilder AddAdddress1(string Adddress1)
        {
            this.Adddress1 = Adddress1;
            return this;
        }

        public GetSetBuilder AddBatch1(string Batch1)
        {
            this.Batch1 = Batch1;
            return this;
        }

        public GetSetBuilder AddDate1(string Date1)
        {
            this.Date1 = Date1;
            return this;
        }

        public GetSetBuilder AddEmail1(string Email1)
        {
            this.Email1 = Email1;
            return this;
        }

        public GetSetBuilder AddID1(string ID1)
        {
            this.ID1 = ID1;
            return this;
        }

        public GetSetBuilder AddName1(string Name1)
        {
            this.Name1 = Name1;
            return this;
        }

        public GetSetBuilder AddPassWord1(string PassWord1)
        {
            this.PassWord1 = PassWord1;
            return this;
        }

        public GetSetBuilder AddReId1(string ReId1)
        {
            this.ReId1 = ReId1;
            return this;
        }

        public GetSetBuilder AddType1(string Type1)
        {
            this.Type1 = Type1;
            return this;
        }

        public GetSetBuilder AddUserName1(string UserName1)
        {
            this.UserName1 = UserName1;
            return this;
        }

        public getSetForm Build()
        {
            return new getSetForm(ID1, Name1, Date1, Email1, Adddress1, UserName1, PassWord1, AccID1, Type1, Batch1, ReId1);
        }
    }
}
