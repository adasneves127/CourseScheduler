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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseScheduler
{
    public partial class Semesters : Form
    {
        public Semesters()
        {
            InitializeComponent();
            MySqlConnection conn = new MySqlConnection(Scheduling.Settings.connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT semesterName, vernerNum FROM semester";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0]);
                ListViewItem itm = new ListViewItem();
                itm.Text = reader[0].ToString();
                itm.SubItems.Add(reader[1].ToString());
                listView1.Items.Add(itm);
            }
            reader.Close();
            conn.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SelectSem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            MySqlConnection conn = new MySqlConnection(Scheduling.Settings.connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT semesterID FROM semester WHERE semesterName = @name";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", listView1.SelectedItems[0].Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Scheduling.Settings.semesterID = (int)reader[0];
            Scheduling.Settings.semesterName = listView1.SelectedItems[0].Text;
            reader.Close();
            conn.Close();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateTerm term = new CreateTerm();
            term.FormClosing += updateMenu;
            term.MdiParent = this.MdiParent;
            term.Show();
        }
        
        private void updateMenu(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            MySqlConnection conn = new MySqlConnection(Scheduling.Settings.connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT semesterName, vernerNum FROM semester";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0]);
                ListViewItem itm = new ListViewItem();
                itm.Text = reader[0].ToString();
                itm.SubItems.Add(reader[1].ToString());
                listView1.Items.Add(itm);
            }
            reader.Close();
            conn.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CreateTerm term = new CreateTerm();
            term.MdiParent = this.MdiParent;
            term.FormClosing += new FormClosingEventHandler(termOnClose);
            term.Show();
        }

        private void termOnClose(object sender, FormClosingEventArgs e)
        {
            this.updateMenu(null, null);
        }
    }
}
