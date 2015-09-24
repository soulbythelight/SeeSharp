using System;
using System.Windows.Forms;

namespace Lou
{
    class Program
    {
        public int userID = 0;
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Admin());
        }
    }
} 
