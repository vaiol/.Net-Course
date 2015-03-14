using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetLaba1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            m = new MainForm();
            Application.Run(m);
        }
        private static MainForm m;

        public static MainForm Form
        {
            get { return m; }
        }

        private static Spec s = new Spec();

        public static Spec Spec
        {
            set { s = value; }
            get { return s; }
        }
    }
}
