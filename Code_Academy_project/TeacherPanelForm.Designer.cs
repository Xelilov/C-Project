namespace Code_Academy_project
{
    partial class TeacherPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherPanelForm));
            this.pc_teacher_panel_foto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_teacher_name = new System.Windows.Forms.Label();
            this.lb_teacher_surname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_teacher_gender = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_teacher_phone = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_add_task_type = new System.Windows.Forms.Button();
            this.btn_add_task = new System.Windows.Forms.Button();
            this.taskGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_teacher_info = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pc_teacher_panel_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_teacher_panel_foto
            // 
            this.pc_teacher_panel_foto.Location = new System.Drawing.Point(13, 22);
            this.pc_teacher_panel_foto.Name = "pc_teacher_panel_foto";
            this.pc_teacher_panel_foto.Size = new System.Drawing.Size(193, 232);
            this.pc_teacher_panel_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_teacher_panel_foto.TabIndex = 0;
            this.pc_teacher_panel_foto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(253, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // lb_teacher_name
            // 
            this.lb_teacher_name.AutoSize = true;
            this.lb_teacher_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_teacher_name.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_teacher_name.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lb_teacher_name.Location = new System.Drawing.Point(371, 22);
            this.lb_teacher_name.Name = "lb_teacher_name";
            this.lb_teacher_name.Size = new System.Drawing.Size(205, 27);
            this.lb_teacher_name.TabIndex = 2;
            this.lb_teacher_name.Text = "lb_teacher_name";
            // 
            // lb_teacher_surname
            // 
            this.lb_teacher_surname.AutoSize = true;
            this.lb_teacher_surname.BackColor = System.Drawing.Color.Transparent;
            this.lb_teacher_surname.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_teacher_surname.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lb_teacher_surname.Location = new System.Drawing.Point(371, 74);
            this.lb_teacher_surname.Name = "lb_teacher_surname";
            this.lb_teacher_surname.Size = new System.Drawing.Size(241, 27);
            this.lb_teacher_surname.TabIndex = 4;
            this.lb_teacher_surname.Text = "lb_teacher_surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(215, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surname :";
            // 
            // lb_teacher_gender
            // 
            this.lb_teacher_gender.AutoSize = true;
            this.lb_teacher_gender.BackColor = System.Drawing.Color.Transparent;
            this.lb_teacher_gender.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_teacher_gender.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lb_teacher_gender.Location = new System.Drawing.Point(371, 167);
            this.lb_teacher_gender.Name = "lb_teacher_gender";
            this.lb_teacher_gender.Size = new System.Drawing.Size(220, 27);
            this.lb_teacher_gender.TabIndex = 5;
            this.lb_teacher_gender.Text = "lb_teacher_gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(272, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Info :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(238, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gender :";
            // 
            // lb_teacher_phone
            // 
            this.lb_teacher_phone.AutoSize = true;
            this.lb_teacher_phone.BackColor = System.Drawing.Color.Transparent;
            this.lb_teacher_phone.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_teacher_phone.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lb_teacher_phone.Location = new System.Drawing.Point(371, 124);
            this.lb_teacher_phone.Name = "lb_teacher_phone";
            this.lb_teacher_phone.Size = new System.Drawing.Size(207, 27);
            this.lb_teacher_phone.TabIndex = 10;
            this.lb_teacher_phone.Text = "lb_teacher_phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label10.Location = new System.Drawing.Point(249, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 27);
            this.label10.TabIndex = 9;
            this.label10.Text = "Phone :";
            // 
            // btn_add_task_type
            // 
            this.btn_add_task_type.Location = new System.Drawing.Point(706, 33);
            this.btn_add_task_type.Name = "btn_add_task_type";
            this.btn_add_task_type.Size = new System.Drawing.Size(126, 23);
            this.btn_add_task_type.TabIndex = 12;
            this.btn_add_task_type.Text = "New Task Type";
            this.btn_add_task_type.UseVisualStyleBackColor = true;
            this.btn_add_task_type.Click += new System.EventHandler(this.btn_add_task_type_Click);
            // 
            // btn_add_task
            // 
            this.btn_add_task.Location = new System.Drawing.Point(706, 86);
            this.btn_add_task.Name = "btn_add_task";
            this.btn_add_task.Size = new System.Drawing.Size(126, 23);
            this.btn_add_task.TabIndex = 13;
            this.btn_add_task.Text = "New Task";
            this.btn_add_task.UseVisualStyleBackColor = true;
            this.btn_add_task.Click += new System.EventHandler(this.btn_add_task_Click);
            // 
            // taskGridView
            // 
            this.taskGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.taskGridView.Location = new System.Drawing.Point(13, 324);
            this.taskGridView.Name = "taskGridView";
            this.taskGridView.Size = new System.Drawing.Size(871, 199);
            this.taskGridView.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Task Type";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Start Date";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "End Date";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Task Point";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Group";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Student";
            this.Column6.Name = "Column6";
            // 
            // txt_teacher_info
            // 
            this.txt_teacher_info.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_teacher_info.ForeColor = System.Drawing.Color.LawnGreen;
            this.txt_teacher_info.Location = new System.Drawing.Point(376, 216);
            this.txt_teacher_info.Multiline = true;
            this.txt_teacher_info.Name = "txt_teacher_info";
            this.txt_teacher_info.Size = new System.Drawing.Size(456, 75);
            this.txt_teacher_info.TabIndex = 15;
            // 
            // TeacherPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(913, 552);
            this.Controls.Add(this.txt_teacher_info);
            this.Controls.Add(this.taskGridView);
            this.Controls.Add(this.btn_add_task);
            this.Controls.Add(this.btn_add_task_type);
            this.Controls.Add(this.lb_teacher_phone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_teacher_gender);
            this.Controls.Add(this.lb_teacher_surname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_teacher_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pc_teacher_panel_foto);
            this.Name = "TeacherPanelForm";
            this.Text = "TeacherPanelForm";
            ((System.ComponentModel.ISupportInitialize)(this.pc_teacher_panel_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.PictureBox pc_teacher_panel_foto;
        public System.Windows.Forms.Label lb_teacher_name;
        public System.Windows.Forms.Label lb_teacher_surname;
        public System.Windows.Forms.Label lb_teacher_gender;
        public System.Windows.Forms.Label lb_teacher_phone;
        private System.Windows.Forms.Button btn_add_task_type;
        private System.Windows.Forms.Button btn_add_task;
        private System.Windows.Forms.DataGridView taskGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        public System.Windows.Forms.TextBox txt_teacher_info;
    }
}