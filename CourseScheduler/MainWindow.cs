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
        public string user = "";
        string host = "";
        string name = "";
        public string password = "";
        public string connString { get =>"server=" + host + ";uid=" + user + ";pwd=" + password + ";database=" + name + ";";}
        private ToolStripMenuItem checkedItem = null;
        //public static string connStr = "server=db.adasneves.info;uid=;pwd=;database=schedule";
        public MainWindow(string user, string password)
        {
            this.user = user;
            this.password = password;
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
            try
            {
                conn = new MySqlConnection(connString);
                conn.Open();
            } catch (Exception ex)
            {
                
            }
            InitializeComponent();
            populateStrip();
            populateMenu();
        }


        private void populateStrip(){
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT CONCAT(title, ' ', first_name, ' ', last_name) FROM users WHERE username = @name";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", this.user);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            stripLbl1.Text = reader[0].ToString();
            reader.Close();
        }

        private void populateMenu() {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT semesterName FROM semester";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0]);
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Click += selectTerm;
                item.Text = reader[0].ToString();
                manageTermsToolStripMenuItem.DropDownItems.Add(item);
            }
            reader.Close();
        }

        private void viewClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectTerm(object sender, EventArgs e)
        {
            if(checkedItem != null)
            {
                checkedItem.Checked = false;
            }
            ToolStripMenuItem itm = (ToolStripMenuItem)sender;
            if (checkedItem == itm) return;
            itm.Checked = true;
            checkedItem = itm;
        }

        private void createTermToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the "Create Term" page. Should allow for adding professors to a term, entering a verner number,
            // And adding a description to the term for a name.
            // Will modify the following tabs:
            //      semester
            //      semester_prof
            Semesters sem = new Semesters();
            sem.MdiParent = this;
            sem.Show();
        }

        
    }
}
