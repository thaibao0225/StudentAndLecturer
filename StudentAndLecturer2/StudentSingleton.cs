namespace StudentAndLecturer2
{
    class StudentSingleton
    {
        private static StudentSingleton _instance; // 

        private static object syncLock = new object();

        private Student student;

        protected StudentSingleton()
        {
            student = new Student();
        }

        public void OpenForm()
        {
            student.ShowDialog();
        }

        public void deleteForm()
        {
            _instance = null;
        }

        public static StudentSingleton GetLoadBalancer()
        {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new StudentSingleton();
                    }
                }
            }
            return _instance;
        }

        public void CloseForm()
        {
            student.Hide();
            student.Close();
        }
    }
}
