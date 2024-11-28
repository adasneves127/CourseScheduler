using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseScheduler
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(string message)
        {
            InitializeComponent();
            this.richTextBox1.SelectedText = message;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
