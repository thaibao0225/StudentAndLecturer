using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndLecturer2.Properties
{
    public static class trash
    {
        public static int choose;

        public static FormAdmin fff;

        public static void BackToMenu()
        {

            closeAdmin();

            Menu menu = new Menu();
            menu.ShowDialog();
        }

        public static void createAdmin()
        {
            fff = new FormAdmin();
        }

        public static void closeAdmin()
        {
            fff.Hide();
        }

    }
}
