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
    public partial class ProfessorList : Form
    {
        public ProfessorList()
        {
            InitializeComponent();
            MySqlConnection conn = new MySqlConnection(Scheduling.Settings.connString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT A.title, A.first_name, A.last_name, B.officeNum FROM users A, professors B WHERE A.username = B.username;";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem itm = new ListViewItem();
                itm.Text = reader[0].ToString();
                itm.SubItems.Add(reader[1].ToString());
                itm.SubItems.Add(reader[2].ToString());
                itm.SubItems.Add(reader[3].ToString());
                listView1.Items.Add(itm);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateProfessor newProf = new CreateProfessor();
            newProf.MdiParent = this.MdiParent;
            newProf.Show();
        }
    }
}
