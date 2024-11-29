using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Xml.Linq;
using System.Data;
using MySqlConnector;

namespace CourseScheduler
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult result;
            LoginForm loginForm = new LoginForm();
            result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                string name = "";
                string host = "";
                try
                {
                    using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Scheduler"))
                    {
                        if (key != null)
                        {
                            Scheduling.Settings.host = (string)key.GetValue("db_host");
                            Scheduling.Settings.name = (string)key.GetValue("db_name");
                        }
                    }
                    Scheduling.Settings.user = loginForm.txtUserID.Text;
                    Scheduling.Settings.password = loginForm.txtPassword.Text;
                    MySqlConnection conn = new MySqlConnection(Scheduling.Settings.connString);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT SUBSTRING_INDEX(current_user, '@', 1)";
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                }
                catch (Exception ex)
                {
                    ErrorForm form;
                    string errorMsg = "";
                    if (ex.ToString().Contains("Access"))
                    {
                        errorMsg = "Invalid Username or Password!\nPlease check your credentials and try again.";
                    }
                    form = new ErrorForm(errorMsg);
                    
                    form.ShowDialog();
                    return;
                }

                MainWindow win = new MainWindow();
                // login was successful
                Application.Run(win);
            }
        }
    }
}
