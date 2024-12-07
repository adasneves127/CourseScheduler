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
        
        private ToolStripMenuItem checkedItem = null;
        //public static string connStr = "server=db.adasneves.info;uid=;pwd=;database=schedule";
        public MainWindow()
        {
            try
            {
                conn = new MySqlConnection(Scheduling.Settings.connString);
                conn.Open();
            } catch (Exception ex)
            {
                Application.Exit();
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
            cmd.Parameters.AddWithValue("@name", Scheduling.Settings.user);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            stripLbl1.Text = reader[0].ToString();
            reader.Close();
        }

        private void populateMenu() {
        }

        private void viewClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (Scheduling.Settings.semesterName == null)
            {
                this.currentTermName.Text = "No term Selected!";
                this.currentTermName.BackColor = Color.Red;
                this.currentTermName.ForeColor = Color.White;
            } else
            {
                this.currentTermName.Text = Scheduling.Settings.semesterName;
                this.currentTermName.BackColor = Color.FromName("Control");
                this.currentTermName.ForeColor = Color.Black;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.MdiParent = this;
            about.Show();
        }

        private void manageProfessorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfessorList lst = new ProfessorList();
            lst.MdiParent = this;
            lst.Show();
        }

        private void viewScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schedule sched = new Schedule();
            sched.MdiParent = this;
            if(!sched.IsDisposed)
                sched.Show();
            else
            {
                ErrorForm error = new ErrorForm("Please select a semester before continuing!");
                error.ShowDialog();
            }
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            rooms.MdiParent = this;
            rooms.Show();
        }
    }
}
