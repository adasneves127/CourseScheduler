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
    public partial class CreateProfessor : Form
    {
        public CreateProfessor()
        {
            InitializeComponent();
        }

        private void CreateProfessor_Load(object sender, EventArgs e)
        {
            txtAddedBy.Text = Scheduling.Settings.user;
            txtUpdatedBy.Text = Scheduling.Settings.user;
        }

        private void showPassowrdCbtn_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !((CheckBox)sender).Checked;
        }
    }
}
