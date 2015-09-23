using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Lou
{
    class Program
    {
        public int userID = 0;
        static Administer.Query SELF = new Administer.Query();
        [STAThread]
        static void Main(string[] args)
        {
            SELF.PREPARE("192.168.1.13", "bulsu_db", "root", "");
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new TapID());
        }
    }
} 
