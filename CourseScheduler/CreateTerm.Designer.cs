namespace CourseScheduler
{
    partial class CreateTerm
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
            this.btnAddAllProf = new System.Windows.Forms.Button();
            this.btnAddOneProf = new System.Windows.Forms.Button();
            this.btnRemOneProf = new System.Windows.Forms.Button();
            this.btnRemAllProf = new System.Windows.Forms.Button();
            this.lst_AllProf = new System.Windows.Forms.ListView();
            this.allProf_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allProf_FN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allProf_LN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_TermProf = new System.Windows.Forms.ListView();
            this.semProf_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.semProf_FN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.semProf_LN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTermDescription = new System.Windows.Forms.TextBox();
            this.nud_Verner = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lstAllRooms = new System.Windows.Forms.ListView();
            this.roomCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemAllRoom = new System.Windows.Forms.Button();
            this.btnRemOneRoom = new System.Windows.Forms.Button();
            this.btnAddOneRoom = new System.Windows.Forms.Button();
            this.btnAddAllRoom = new System.Windows.Forms.Button();
            this.lst_SemRooms = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nud_Verner)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAllProf
            // 
            this.btnAddAllProf.Location = new System.Drawing.Point(213, 33);
            this.btnAddAllProf.Name = "btnAddAllProf";
            this.btnAddAllProf.Size = new System.Drawing.Size(34, 23);
            this.btnAddAllProf.TabIndex = 2;
            this.btnAddAllProf.Text = ">>|";
            this.btnAddAllProf.UseVisualStyleBackColor = true;
            this.btnAddAllProf.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnAddOneProf
            // 
            this.btnAddOneProf.Location = new System.Drawing.Point(213, 62);
            this.btnAddOneProf.Name = "btnAddOneProf";
            this.btnAddOneProf.Size = new System.Drawing.Size(34, 23);
            this.btnAddOneProf.TabIndex = 3;
            this.btnAddOneProf.Text = ">>";
            this.btnAddOneProf.UseVisualStyleBackColor = true;
            this.btnAddOneProf.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // btnRemOneProf
            // 
            this.btnRemOneProf.Location = new System.Drawing.Point(213, 91);
            this.btnRemOneProf.Name = "btnRemOneProf";
            this.btnRemOneProf.Size = new System.Drawing.Size(34, 23);
            this.btnRemOneProf.TabIndex = 4;
            this.btnRemOneProf.Text = "<<";
            this.btnRemOneProf.UseVisualStyleBackColor = true;
            this.btnRemOneProf.Click += new System.EventHandler(this.btnRemOne_Click);
            // 
            // btnRemAllProf
            // 
            this.btnRemAllProf.Location = new System.Drawing.Point(213, 120);
            this.btnRemAllProf.Name = "btnRemAllProf";
            this.btnRemAllProf.Size = new System.Drawing.Size(34, 23);
            this.btnRemAllProf.TabIndex = 5;
            this.btnRemAllProf.Text = "|<<";
            this.btnRemAllProf.UseVisualStyleBackColor = true;
            this.btnRemAllProf.Click += new System.EventHandler(this.btnRemAll_Click);
            // 
            // lst_AllProf
            // 
            this.lst_AllProf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_AllProf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.allProf_title,
            this.allProf_FN,
            this.allProf_LN});
            this.lst_AllProf.FullRowSelect = true;
            this.lst_AllProf.HideSelection = false;
            this.lst_AllProf.Location = new System.Drawing.Point(18, 13);
            this.lst_AllProf.Name = "lst_AllProf";
            this.lst_AllProf.Size = new System.Drawing.Size(189, 258);
            this.lst_AllProf.TabIndex = 6;
            this.lst_AllProf.UseCompatibleStateImageBehavior = false;
            this.lst_AllProf.View = System.Windows.Forms.View.Details;
            // 
            // allProf_title
            // 
            this.allProf_title.Text = "Title";
            this.allProf_title.Width = 36;
            // 
            // allProf_FN
            // 
            this.allProf_FN.Text = "First Name";
            this.allProf_FN.Width = 69;
            // 
            // allProf_LN
            // 
            this.allProf_LN.Text = "LastName";
            // 
            // lst_TermProf
            // 
            this.lst_TermProf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_TermProf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.semProf_Title,
            this.semProf_FN,
            this.semProf_LN});
            this.lst_TermProf.FullRowSelect = true;
            this.lst_TermProf.HideSelection = false;
            this.lst_TermProf.Location = new System.Drawing.Point(253, 12);
            this.lst_TermProf.Name = "lst_TermProf";
            this.lst_TermProf.Size = new System.Drawing.Size(189, 259);
            this.lst_TermProf.TabIndex = 7;
            this.lst_TermProf.UseCompatibleStateImageBehavior = false;
            this.lst_TermProf.View = System.Windows.Forms.View.Details;
            // 
            // semProf_Title
            // 
            this.semProf_Title.Text = "Title";
            this.semProf_Title.Width = 36;
            // 
            // semProf_FN
            // 
            this.semProf_FN.Text = "First Name";
            this.semProf_FN.Width = 69;
            // 
            // semProf_LN
            // 
            this.semProf_LN.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Semester Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Verner Number";
            // 
            // txtTermDescription
            // 
            this.txtTermDescription.Location = new System.Drawing.Point(566, 31);
            this.txtTermDescription.MaxLength = 20;
            this.txtTermDescription.Name = "txtTermDescription";
            this.txtTermDescription.Size = new System.Drawing.Size(100, 20);
            this.txtTermDescription.TabIndex = 10;
            // 
            // nud_Verner
            // 
            this.nud_Verner.Location = new System.Drawing.Point(566, 70);
            this.nud_Verner.Name = "nud_Verner";
            this.nud_Verner.Size = new System.Drawing.Size(100, 20);
            this.nud_Verner.TabIndex = 11;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(713, 415);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lstAllRooms
            // 
            this.lstAllRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lstAllRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.roomCode,
            this.roomName});
            this.lstAllRooms.FullRowSelect = true;
            this.lstAllRooms.HideSelection = false;
            this.lstAllRooms.Location = new System.Drawing.Point(18, 276);
            this.lstAllRooms.Name = "lstAllRooms";
            this.lstAllRooms.Size = new System.Drawing.Size(188, 167);
            this.lstAllRooms.TabIndex = 13;
            this.lstAllRooms.UseCompatibleStateImageBehavior = false;
            this.lstAllRooms.View = System.Windows.Forms.View.Details;
            // 
            // roomCode
            // 
            this.roomCode.Text = "Room Code";
            this.roomCode.Width = 80;
            // 
            // roomName
            // 
            this.roomName.Text = "Room Name";
            this.roomName.Width = 100;
            // 
            // btnRemAllRoom
            // 
            this.btnRemAllRoom.Location = new System.Drawing.Point(213, 380);
            this.btnRemAllRoom.Name = "btnRemAllRoom";
            this.btnRemAllRoom.Size = new System.Drawing.Size(34, 23);
            this.btnRemAllRoom.TabIndex = 18;
            this.btnRemAllRoom.Text = "|<<";
            this.btnRemAllRoom.UseVisualStyleBackColor = true;
            this.btnRemAllRoom.Click += new System.EventHandler(this.btnRemAllRoom_Click);
            // 
            // btnRemOneRoom
            // 
            this.btnRemOneRoom.Location = new System.Drawing.Point(213, 351);
            this.btnRemOneRoom.Name = "btnRemOneRoom";
            this.btnRemOneRoom.Size = new System.Drawing.Size(34, 23);
            this.btnRemOneRoom.TabIndex = 17;
            this.btnRemOneRoom.Text = "<<";
            this.btnRemOneRoom.UseVisualStyleBackColor = true;
            this.btnRemOneRoom.Click += new System.EventHandler(this.btnRemOneRoom_Click);
            // 
            // btnAddOneRoom
            // 
            this.btnAddOneRoom.Location = new System.Drawing.Point(213, 322);
            this.btnAddOneRoom.Name = "btnAddOneRoom";
            this.btnAddOneRoom.Size = new System.Drawing.Size(34, 23);
            this.btnAddOneRoom.TabIndex = 16;
            this.btnAddOneRoom.Text = ">>";
            this.btnAddOneRoom.UseVisualStyleBackColor = true;
            this.btnAddOneRoom.Click += new System.EventHandler(this.btnAddOneRoom_Click);
            // 
            // btnAddAllRoom
            // 
            this.btnAddAllRoom.Location = new System.Drawing.Point(213, 293);
            this.btnAddAllRoom.Name = "btnAddAllRoom";
            this.btnAddAllRoom.Size = new System.Drawing.Size(34, 23);
            this.btnAddAllRoom.TabIndex = 15;
            this.btnAddAllRoom.Text = ">>|";
            this.btnAddAllRoom.UseVisualStyleBackColor = true;
            this.btnAddAllRoom.Click += new System.EventHandler(this.btnAddAllRoom_Click);
            // 
            // lst_SemRooms
            // 
            this.lst_SemRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_SemRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lst_SemRooms.FullRowSelect = true;
            this.lst_SemRooms.HideSelection = false;
            this.lst_SemRooms.Location = new System.Drawing.Point(254, 276);
            this.lst_SemRooms.Name = "lst_SemRooms";
            this.lst_SemRooms.Size = new System.Drawing.Size(188, 167);
            this.lst_SemRooms.TabIndex = 19;
            this.lst_SemRooms.UseCompatibleStateImageBehavior = false;
            this.lst_SemRooms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Room Code";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Room Name";
            this.columnHeader2.Width = 100;
            // 
            // CreateTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 456);
            this.Controls.Add(this.lst_SemRooms);
            this.Controls.Add(this.btnRemAllRoom);
            this.Controls.Add(this.btnRemOneRoom);
            this.Controls.Add(this.btnAddOneRoom);
            this.Controls.Add(this.btnAddAllRoom);
            this.Controls.Add(this.lstAllRooms);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.nud_Verner);
            this.Controls.Add(this.txtTermDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_TermProf);
            this.Controls.Add(this.lst_AllProf);
            this.Controls.Add(this.btnRemAllProf);
            this.Controls.Add(this.btnRemOneProf);
            this.Controls.Add(this.btnAddOneProf);
            this.Controls.Add(this.btnAddAllProf);
            this.Name = "CreateTerm";
            this.Text = "CreateTerm";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Verner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAllProf;
        private System.Windows.Forms.Button btnAddOneProf;
        private System.Windows.Forms.Button btnRemOneProf;
        private System.Windows.Forms.Button btnRemAllProf;
        private System.Windows.Forms.ListView lst_AllProf;
        private System.Windows.Forms.ListView lst_TermProf;
        private System.Windows.Forms.ColumnHeader allProf_title;
        private System.Windows.Forms.ColumnHeader allProf_FN;
        private System.Windows.Forms.ColumnHeader allProf_LN;
        private System.Windows.Forms.ColumnHeader semProf_Title;
        private System.Windows.Forms.ColumnHeader semProf_FN;
        private System.Windows.Forms.ColumnHeader semProf_LN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTermDescription;
        private System.Windows.Forms.NumericUpDown nud_Verner;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ListView lstAllRooms;
        private System.Windows.Forms.ColumnHeader roomCode;
        private System.Windows.Forms.ColumnHeader roomName;
        private System.Windows.Forms.Button btnRemAllRoom;
        private System.Windows.Forms.Button btnRemOneRoom;
        private System.Windows.Forms.Button btnAddOneRoom;
        private System.Windows.Forms.Button btnAddAllRoom;
        private System.Windows.Forms.ListView lst_SemRooms;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}