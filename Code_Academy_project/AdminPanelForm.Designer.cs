namespace Code_Academy_project
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.teacherGridView = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add_teacher = new System.Windows.Forms.Button();
            this.btn_add_menthor = new System.Windows.Forms.Button();
            this.menthorGridView = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add_group = new System.Windows.Forms.Button();
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            this.btn_add_student = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.teacherGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menthorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherGridView
            // 
            this.teacherGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teacherGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.teacherGridView.Location = new System.Drawing.Point(46, 178);
            this.teacherGridView.Name = "teacherGridView";
            this.teacherGridView.Size = new System.Drawing.Size(1264, 150);
            this.teacherGridView.TabIndex = 0;
            this.teacherGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Update_Teacher);
            // 
            // Column10
            // 
            this.Column10.HeaderText = "id";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Teacher Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Teacher Surname";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Teacher Email";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Teacher Gender";
            this.Column4.Name = "Column4";
            // 
            // btn_add_teacher
            // 
            this.btn_add_teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add_teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_teacher.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_teacher.Location = new System.Drawing.Point(1149, 124);
            this.btn_add_teacher.Name = "btn_add_teacher";
            this.btn_add_teacher.Size = new System.Drawing.Size(161, 35);
            this.btn_add_teacher.TabIndex = 1;
            this.btn_add_teacher.Text = "New Teacher";
            this.btn_add_teacher.UseVisualStyleBackColor = false;
            this.btn_add_teacher.Click += new System.EventHandler(this.btn_add_teacher_Click);
            // 
            // btn_add_menthor
            // 
            this.btn_add_menthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add_menthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_menthor.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_menthor.Location = new System.Drawing.Point(1149, 419);
            this.btn_add_menthor.Name = "btn_add_menthor";
            this.btn_add_menthor.Size = new System.Drawing.Size(161, 35);
            this.btn_add_menthor.TabIndex = 2;
            this.btn_add_menthor.Text = "New Menthor";
            this.btn_add_menthor.UseVisualStyleBackColor = false;
            this.btn_add_menthor.Click += new System.EventHandler(this.btn_add_menthor_Click);
            // 
            // menthorGridView
            // 
            this.menthorGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menthorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menthorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.menthorGridView.Location = new System.Drawing.Point(46, 470);
            this.menthorGridView.Name = "menthorGridView";
            this.menthorGridView.Size = new System.Drawing.Size(1264, 150);
            this.menthorGridView.TabIndex = 3;
            this.menthorGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Update_Menthor);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Menthor Name";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Menthor Surname";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Menthor Email";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Menthor Gender";
            this.Column8.Name = "Column8";
            // 
            // groupGridView
            // 
            this.groupGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column9});
            this.groupGridView.Location = new System.Drawing.Point(46, 750);
            this.groupGridView.Name = "groupGridView";
            this.groupGridView.Size = new System.Drawing.Size(1264, 150);
            this.groupGridView.TabIndex = 4;
            this.groupGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Update_Groups);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Group Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Group Teacher";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Group Menthor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Group Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Group Start Time";
            this.Column9.Name = "Column9";
            // 
            // btn_add_group
            // 
            this.btn_add_group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add_group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_group.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_group.Location = new System.Drawing.Point(1149, 700);
            this.btn_add_group.Name = "btn_add_group";
            this.btn_add_group.Size = new System.Drawing.Size(161, 35);
            this.btn_add_group.TabIndex = 5;
            this.btn_add_group.Text = "New Group";
            this.btn_add_group.UseVisualStyleBackColor = false;
            this.btn_add_group.Click += new System.EventHandler(this.btn_add_group_Click);
            // 
            // StudentGridView
            // 
            this.StudentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Location = new System.Drawing.Point(46, 1039);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.Size = new System.Drawing.Size(1264, 150);
            this.StudentGridView.TabIndex = 6;
            this.StudentGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Update_student);
            // 
            // btn_add_student
            // 
            this.btn_add_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_student.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_student.Location = new System.Drawing.Point(1149, 989);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(161, 35);
            this.btn_add_student.TabIndex = 7;
            this.btn_add_student.Text = "New Student";
            this.btn_add_student.UseVisualStyleBackColor = false;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_student_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_add_student);
            this.Controls.Add(this.StudentGridView);
            this.Controls.Add(this.btn_add_group);
            this.Controls.Add(this.groupGridView);
            this.Controls.Add(this.menthorGridView);
            this.Controls.Add(this.btn_add_menthor);
            this.Controls.Add(this.btn_add_teacher);
            this.Controls.Add(this.teacherGridView);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            ((System.ComponentModel.ISupportInitialize)(this.teacherGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menthorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView teacherGridView;
        private System.Windows.Forms.Button btn_add_teacher;
        private System.Windows.Forms.Button btn_add_menthor;
        private System.Windows.Forms.DataGridView menthorGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridView groupGridView;
        private System.Windows.Forms.Button btn_add_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.Button btn_add_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}