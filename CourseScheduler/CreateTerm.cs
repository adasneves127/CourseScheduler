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

namespace CourseScheduler
{
    public partial class CreateTerm : Form
    {
        private MySqlConnection conn;
        public CreateTerm()
        {
            conn = new MySqlConnection(Scheduling.Settings.connString);
            conn.Open();
            InitializeComponent();
            populateProfList();
        }

        private void populateProfList()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT A.title, A.first_name, A.last_name FROM users A, professors B WHERE A.username = B.username";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem itm = new ListViewItem();
                itm.Text = reader[0].ToString();
                itm.SubItems.Add(reader[1].ToString());
                itm.SubItems.Add(reader[2].ToString());
                lst_AllProf.Items.Add(itm);

            }
            reader.Close();
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst_AllProf.Items.Count; i++)
            {
                ListViewItem itm = lst_AllProf.Items[i];
                lst_TermProf.Items.Add((ListViewItem)itm.Clone());
            }
            lst_AllProf.Items.Clear();
        }

        private void btnRemAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst_TermProf.Items.Count; i++)
            {
                ListViewItem itm = lst_TermProf.Items[i];
                lst_AllProf.Items.Add((ListViewItem)itm.Clone());
            }
            lst_TermProf.Items.Clear();
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst_AllProf.SelectedItems.Count; i++)
            {
                ListViewItem itm = lst_AllProf.SelectedItems[i];
                lst_TermProf.Items.Add((ListViewItem)itm.Clone());
            }
            for (int i = 0; i < lst_AllProf.SelectedItems.Count; i++)
            {
                lst_AllProf.Items.Remove(lst_AllProf.SelectedItems[i]);
            }
        }

        private void btnRemOne_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst_TermProf.SelectedItems.Count; i++)
            {
                ListViewItem itm = lst_TermProf.SelectedItems[i];
                lst_AllProf.Items.Add((ListViewItem)itm.Clone());
            }
            for (int i = 0; i < lst_TermProf.SelectedItems.Count; i++)
            {
                lst_TermProf.Items.Remove(lst_TermProf.SelectedItems[i]);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO semester (semesterName, vernerNum, addedUser, updateUser) VALUES (@sName, @vNum, SUBSTRING_INDEX(current_user, '@', 1), SUBSTRING_INDEX(current_user, '@', 1));";
            cmd.Parameters.AddWithValue("@sName", txtTermDescription.Text);
            cmd.Parameters.AddWithValue("@vNum", nud_Verner.Value);
            cmd.ExecuteNonQuery();
            long semesterID = cmd.LastInsertedId;
            MySqlCommand profCmd = new MySqlCommand();
            profCmd.CommandType = CommandType.Text;
            profCmd.Connection = conn;
            profCmd.CommandText = "INSERT INTO semester_prof (semesterID, profID) VALUES (@semID, (SELECT profID FROM professors WHERE username = (SELECT username FROM users WHERE first_name=@fN AND last_name=@lN)));";
            profCmd.Parameters.AddWithValue("@semID", semesterID);
            profCmd.Parameters.AddWithValue("@fN", "");
            profCmd.Parameters.AddWithValue("@lN", "");
            for (int i = 0; i < lst_TermProf.Items.Count; i++)
            {
                profCmd.Parameters["@fN"].Value =  lst_TermProf.Items[i].SubItems[1].Text;
                profCmd.Parameters["@lN"].Value = lst_TermProf.Items[i].SubItems[2].Text;
                Console.WriteLine(lst_TermProf.Items[i].SubItems[0].Text);
                profCmd.ExecuteNonQuery();
            }
            this.Close();
            
        }
    }
}
