using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Microsoft.Win32;

namespace CourseScheduler
{
    public partial class MainWindow : Form
    {
        NewCourse newCourse;
        public MySqlConnection conn;
        string user = "mila";
        string host = "";
        string name = "";
        string password = "Minha123";
        //public static string connStr = "server=db.adasneves.info;uid=;pwd=;database=schedule";
        public MainWindow()
        {
            
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Scheduler"))
                {
                    if(key != null)
                    {
                        host = (string)key.GetValue("db_host");
                        name = (string)key.GetValue("db_name");
                    }
                }
            } catch (Exception ex)
            {
                throw ex;
            }
            conn = new MySqlConnection("server="+host+";uid="+user+";pwd="+password+";database="+name+";");
            conn.Open();
            InitializeComponent();
        }

        private void createClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newCourse = new NewCourse();
            newCourse.MdiParent = this;
            newCourse.Show();
        }

    }
}
