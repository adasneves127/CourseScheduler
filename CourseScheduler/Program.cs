using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Xml.Linq;
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
                            host = (string)key.GetValue("db_host");
                            name = (string)key.GetValue("db_name");
                        }
                    }
                    MySqlConnection conn = new MySqlConnection("server=" + host + ";uid=" + loginForm.txtUserID.Text + ";pwd=" + loginForm.txtPassword.Text + ";database=" + name + ";");
                    conn.Open();
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

                MainWindow win = new MainWindow(loginForm.txtUserID.Text, loginForm.txtPassword.Text);
                // login was successful
                Application.Run(win);
            }
        }
    }
}
