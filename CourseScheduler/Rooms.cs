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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Scheduling.Settings.connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "SELECT roomID, roomName, roomCode, deptOwned FROM rooms";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell roomID = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell roomName = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell roomCode = new DataGridViewTextBoxCell();
                DataGridViewCheckBoxCell deptOwned = new DataGridViewCheckBoxCell();
                roomID.Value = reader[0].ToString();
                roomName.Value = reader[1].ToString();
                roomCode.Value = reader[2].ToString();
                Console.WriteLine(reader[3]);
                deptOwned.Value = reader[3];
                row.Cells.Add(roomID);
                row.Cells.Add(roomName);
                row.Cells.Add(roomCode);
                row.Cells.Add(deptOwned);
                dataGridView1.Rows.Add(row);
            }
            reader.Close();
            conn.Close();

            
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["saveBtn"].Index)
            {

                MySqlConnection conn = new MySqlConnection(Scheduling.Settings.connString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                // Up-Sert the data.
                // Check if data exists. If rowID is null, not set then row does not exist.
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    cmd.CommandText = "INSERT INTO rooms (roomName, roomCode, deptOwned, addedDt, addedUser, updateDt, updateUser) values (@roomName, @roomCode, @deptOwned, current_timestamp, SUBSTRING_INDEX(current_user, '@', 1), current_timestamp, SUBSTRING_INDEX(current_user, '@', 1))";
                    cmd.Parameters.AddWithValue("@roomName", dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                    cmd.Parameters.AddWithValue("@roomCode", dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@deptOwned", dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                    cmd.ExecuteNonQuery();
                    long id = cmd.LastInsertedId;
                    dataGridView1.Rows[e.RowIndex].Cells[0].Value = id.ToString();
                }
                else
                {
                    cmd.CommandText = "UPDATE rooms SET roomName = @roomName, roomCode = @roomCode, deptOwned = @deptOwned, updateDt = current_timestamp, updateUser = SUBSTRING_INDEX(current_user, '@', 1) WHERE roomID = @roomID";
                    cmd.Parameters.AddWithValue("@roomName", dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                    cmd.Parameters.AddWithValue("@roomCode", dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@deptOwned", dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                    cmd.Parameters.AddWithValue("@roomID", dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    cmd.ExecuteNonQuery();
                }


                conn.Close();
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Scheduling.Settings.connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            // Check if data is in use.
            cmd.CommandText = "SELECT COUNT(*) FROM room_semester WHERE roomID = @roomID";
            cmd.Parameters.AddWithValue("@roomID", e.Row.Cells[0].Value);
            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            long useCount = (long)reader[0];
            reader.Close();
            if (useCount > 0)
            {
                ErrorForm error = new ErrorForm("Room is in use by semesters. Please remove all usages of room before deleting.");
                error.ShowDialog();
                e.Cancel = true;
                return;
            }

            cmd.CommandText = "DELETE FROM rooms WHERE roomID = @roomID";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
