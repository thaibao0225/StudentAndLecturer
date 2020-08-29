namespace StudentAndLecturer2
{
    class AdminSingleton
    {
        private static AdminSingleton _instance;

        private static object syncLock = new object();

        private FormAdmin FormAdmin;

        protected AdminSingleton()
        {
            FormAdmin = new FormAdmin();
        }

        public void OpenForm()
        {
            FormAdmin.ShowDialog();
        }

        public void deleteForm()
        {
            _instance = null;
        }

        public static AdminSingleton GetLoadBalancer()
        {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new AdminSingleton();
                    }
                }
            }
            return _instance;
        }

        public void CloseForm()
        {
            FormAdmin.Hide();
            FormAdmin.Close();
        }

    }
}
