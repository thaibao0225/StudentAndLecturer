namespace StudentAndLecturer2
{
    class LecturerSingleton
    {
        private static LecturerSingleton _instance;

        private static object syncLock = new object();

        private Lecturer Lecturer;

        protected LecturerSingleton()
        {
            Lecturer = new Lecturer();
        }

        public static LecturerSingleton GetLoadBalancer()
        {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LecturerSingleton();
                    }
                }
            }
            return _instance;
        }

        public void OpenForm()
        {
            Lecturer.ShowDialog();
        }

        public void deleteForm()
        {
            _instance = null;
        }

        public void CloseForm()
        {
            Lecturer.Hide();
            Lecturer.Close();
        }
    }
}
