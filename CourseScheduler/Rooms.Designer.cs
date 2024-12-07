namespace CourseScheduler
{
    partial class Rooms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptOwned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saveBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomID,
            this.roomName,
            this.roomCode,
            this.deptOwned,
            this.saveBtn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // RoomID
            // 
            this.RoomID.HeaderText = "Room ID";
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            this.RoomID.Visible = false;
            // 
            // roomName
            // 
            this.roomName.HeaderText = "RoomName";
            this.roomName.Name = "roomName";
            // 
            // roomCode
            // 
            this.roomCode.HeaderText = "Room Code";
            this.roomCode.Name = "roomCode";
            // 
            // deptOwned
            // 
            this.deptOwned.HeaderText = "Department Owned";
            this.deptOwned.Name = "deptOwned";
            // 
            // saveBtn
            // 
            this.saveBtn.HeaderText = "Save";
            this.saveBtn.Name = "saveBtn";
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomCode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deptOwned;
        private System.Windows.Forms.DataGridViewButtonColumn saveBtn;
    }
}