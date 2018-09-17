using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAssignment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WindowForm form = new WindowForm();
            Config config = new Config();
            try
            {
                config.Load("config.xml");
                form.SetConfig(config);
                Application.Run(form);
            }
            catch (Exception e)
            {
                MessageBox.Show("config.xml file is either corrupted or missing. Application will shut down.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
