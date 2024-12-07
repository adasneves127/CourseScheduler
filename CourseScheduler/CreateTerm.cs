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
        public CreateTerm()
        {
            
            InitializeComponent();
            populateProfList();
            populateRoomList();
        }

        private void populateProfList()
        {
            MySqlConnection conn = new MySqlConnection(Scheduling.Settings.connString);
            conn.Open();
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
            conn.Close();
        }

        private void populateRoomList()
        {
            MySqlConnection conn = new MySqlConnection(Scheduling.Settings.connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT roomName, roomCode FROM rooms WHERE deptOwned = 1";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem itm = new ListViewItem();
                itm.Text = reader[0].ToString();
                itm.SubItems.Add(reader[1].ToString());
                lstAllRooms.Items.Add(itm);

            }
            reader.Close();
            conn.Close();
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
            for (int i = 0; i < lst_AllProf.SelectedItems.Count; )
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
            for (int i = 0; i < lst_TermProf.SelectedItems.Count; )
            {
                lst_TermProf.Items.Remove(lst_TermProf.SelectedItems[i]);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Scheduling.Settings.connString);
            conn.Open();
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
            // Add rooms to room_semester;
            MySqlCommand roomCmd = new MySqlCommand();
            roomCmd.CommandType = CommandType.Text;
            roomCmd.Connection = conn;
            roomCmd.CommandText = "INSERT INTO room_semester (roomID, semesterID) VALUES ((SELECT roomID FROM rooms WHERE roomName = @roomName and roomCode = @roomCode), @semID)";
            roomCmd.Parameters.AddWithValue("@semID", semesterID);
            roomCmd.Parameters.AddWithValue("@roomName", "");
            roomCmd.Parameters.AddWithValue("@roomCode", "");
            for (int i = 0; i < lst_SemRooms.Items.Count; i++)
            {
                roomCmd.Parameters["@roomName"].Value = lst_SemRooms.Items[i].SubItems[0].Text;
                roomCmd.Parameters["@roomCode"].Value = lst_SemRooms.Items[i].SubItems[1].Text;
                roomCmd.ExecuteNonQuery();
            }
            MySqlConnection conn2 = new MySqlConnection(Scheduling.Settings.connString);
            conn2.Open();
            MySqlCommand vernerSearchCmd = new MySqlCommand("SELECT roomName, roomCode FROM rooms WHERE deptOwned = 0 AND roomCode like 'VERNER_%';", conn2);
            MySqlDataReader reader = vernerSearchCmd.ExecuteReader();
            bool roomExists = reader.Read();
            for(int i = 0; i < nud_Verner.Value; i++)
            {
                
                if (roomExists)
                {
                    roomCmd.Parameters["@roomName"].Value = reader[0];
                    roomCmd.Parameters["@roomCode"].Value = reader[1];
                    roomCmd.ExecuteNonQuery();
                    roomExists &= reader.Read();
                } else
                {
                    MySqlCommand roomAdd = new MySqlCommand("INSERT INTO rooms (roomName, roomCode, deptOwned, addedDt, addedUser, updateDt, updateUser) values (@roomName, @roomCode, @deptOwned, current_timestamp, SUBSTRING_INDEX(current_user, '@', 1), current_timestamp, SUBSTRING_INDEX(current_user, '@', 1))", conn);
                    roomAdd.Parameters.AddWithValue("@roomName", "University Owned Room " + (i+1).ToString());
                    roomAdd.Parameters.AddWithValue("@roomCode", "VERNER_" + (i + 1).ToString());
                    roomAdd.Parameters.AddWithValue("@deptOwned", false);
                    roomAdd.ExecuteNonQuery();
                }

            }
            reader.Close();

            this.Close();
            
        }

        private void btnAddAllRoom_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstAllRooms.Items.Count; i++)
            {
                ListViewItem itm = lstAllRooms.Items[i];
                lst_SemRooms.Items.Add((ListViewItem)itm.Clone());
            }
            lstAllRooms.Items.Clear();
        }

        private void btnAddOneRoom_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstAllRooms.SelectedItems.Count; i++)
            {
                ListViewItem itm = lstAllRooms.SelectedItems[i];
                lst_SemRooms.Items.Add((ListViewItem)itm.Clone());
            }
            for (int i = 0; i < lstAllRooms.SelectedItems.Count; )
            {
                lstAllRooms.Items.Remove(lstAllRooms.SelectedItems[i]);
            }
        }

        private void btnRemOneRoom_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst_SemRooms.SelectedItems.Count; i++)
            {
                ListViewItem itm = lst_SemRooms.SelectedItems[i];
                lstAllRooms.Items.Add((ListViewItem)itm.Clone());
            }
            for (int i = 0; i < lst_SemRooms.SelectedItems.Count; )
            {
                lst_SemRooms.Items.Remove(lst_SemRooms.SelectedItems[i]);
            }
        }

        private void btnRemAllRoom_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst_SemRooms.Items.Count; i++)
            {
                ListViewItem itm = lst_SemRooms.Items[i];
                lstAllRooms.Items.Add((ListViewItem)itm.Clone());
            }
            lst_SemRooms.Items.Clear();
        }
    }
}
