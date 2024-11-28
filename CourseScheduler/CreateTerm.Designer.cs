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
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnAddOne = new System.Windows.Forms.Button();
            this.btnRemOne = new System.Windows.Forms.Button();
            this.btnRemAll = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.nud_Verner)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(213, 168);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(34, 23);
            this.btnAddAll.TabIndex = 2;
            this.btnAddAll.Text = ">>|";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnAddOne
            // 
            this.btnAddOne.Location = new System.Drawing.Point(213, 197);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(34, 23);
            this.btnAddOne.TabIndex = 3;
            this.btnAddOne.Text = ">>";
            this.btnAddOne.UseVisualStyleBackColor = true;
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // btnRemOne
            // 
            this.btnRemOne.Location = new System.Drawing.Point(213, 226);
            this.btnRemOne.Name = "btnRemOne";
            this.btnRemOne.Size = new System.Drawing.Size(34, 23);
            this.btnRemOne.TabIndex = 4;
            this.btnRemOne.Text = "<<";
            this.btnRemOne.UseVisualStyleBackColor = true;
            this.btnRemOne.Click += new System.EventHandler(this.btnRemOne_Click);
            // 
            // btnRemAll
            // 
            this.btnRemAll.Location = new System.Drawing.Point(213, 255);
            this.btnRemAll.Name = "btnRemAll";
            this.btnRemAll.Size = new System.Drawing.Size(34, 23);
            this.btnRemAll.TabIndex = 5;
            this.btnRemAll.Text = "|<<";
            this.btnRemAll.UseVisualStyleBackColor = true;
            this.btnRemAll.Click += new System.EventHandler(this.btnRemAll_Click);
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
            this.lst_AllProf.Size = new System.Drawing.Size(189, 425);
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
            this.lst_TermProf.Size = new System.Drawing.Size(189, 425);
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
            // CreateTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.nud_Verner);
            this.Controls.Add(this.txtTermDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_TermProf);
            this.Controls.Add(this.lst_AllProf);
            this.Controls.Add(this.btnRemAll);
            this.Controls.Add(this.btnRemOne);
            this.Controls.Add(this.btnAddOne);
            this.Controls.Add(this.btnAddAll);
            this.Name = "CreateTerm";
            this.Text = "CreateTerm";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Verner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.Button btnRemOne;
        private System.Windows.Forms.Button btnRemAll;
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
    }
}