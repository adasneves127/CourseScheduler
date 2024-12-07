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
    public partial class Schedule : Form
    {
        private List<Label> lblList = new List<Label>();
        private int divisionPerHour = 10;
        public Schedule()
        {
            InitializeComponent();
            if (Scheduling.Settings.semesterID == -1) this.Close();
            // Get the rooms for the current semester.

        }

        private void paintTab(object sender, PaintEventArgs e)
        {

            // Draw Grid for Days of Week and Times of Day
            // Our day will span from 8am to 8pm.
            // 12 hours with 5 minute increments would be 240 divisions.
            TabPage page = sender as TabPage;
            float divisionWidth = (page.Width - 20) / 240;
            Pen p = new Pen(Color.Black, 1);
            for(int i = 0; i < 20*12; i++)
            {
                int j = i % 20;
                e.Graphics.DrawRectangle(p, (int)(14 + divisionWidth * i), 60, 1, page.Height);
            }
        }

        private void tabControl1_Resize(object sender, EventArgs e)
        {
            
            int i = 0;
            foreach(TabPage page in tabControl1.TabPages)
            {
                float divisionSize = (page.Width - 20) / 60;
                foreach (Control ctrl in page.Controls)
                {

                    Console.WriteLine(ctrl.Text);
                    Label lbl = ctrl as Label;
                    if (lbl == null) continue;
                    lbl.Location = new Point((int)(10 + divisionSize * i), lbl.Location.Y);
                    i += 4;


                }
                page.Invalidate();
            }
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            HScrollBar bar = sender as HScrollBar;
            Console.WriteLine(bar.Value);
        }
    }
}
