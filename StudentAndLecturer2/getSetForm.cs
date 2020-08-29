namespace StudentAndLecturer2
{
    public class getSetForm
    {
        private static string ID;
        private static string Name;
        private static string Date;
        private static string Email;
        private static string Adddress;
        private static string UserName;
        private static string PassWord;
        private static string AccID;
        private static string Type;
        private static string Batch;
        private static string ReId;
        public getSetForm()
        {

        }
        public getSetForm(
            string Id,
            string Name,
            string Date,
            string Email,
            string Address,
            string UserName,
            string Password,
            string AccId,
            string Type,
            string Batch,
            string ReId
            )
        {
            this.ID1 = Id;
            this.Name1 = Name;
            this.Date1 = Date;
            this.Email1 = Email;
            this.Adddress1 = Address;
            this.UserName1 = UserName;
            this.PassWord1 = Password;
            this.AccID1 = AccId;
            this.Type1 = Type;
            this.Batch1 = Batch;
            this.ReId1 = ReId;

        }

        public string ReId1 { get => ReId; set => ReId = value; }
        public string Batch1 { get => Batch; set => Batch = value; }
        public string ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Date1 { get => Date; set => Date = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Adddress1 { get => Adddress; set => Adddress = value; }
        public string UserName1 { get => UserName; set => UserName = value; }
        public string PassWord1 { get => PassWord; set => PassWord = value; }
        public string AccID1 { get => AccID; set => AccID = value; }
        public string Type1 { get => Type; set => Type = value; }
    }
}
