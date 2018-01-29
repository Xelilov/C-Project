namespace Code_Academy_project
{
    partial class NewTaskForm
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
            this.cb_task_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_start_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_edb_date = new System.Windows.Forms.DateTimePicker();
            this.txt_task_source = new System.Windows.Forms.TextBox();
            this.txt_task_point = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_task_group = new System.Windows.Forms.ComboBox();
            this.cb_task_student = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_task_note = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_task_type
            // 
            this.cb_task_type.FormattingEnabled = true;
            this.cb_task_type.Location = new System.Drawing.Point(154, 45);
            this.cb_task_type.Name = "cb_task_type";
            this.cb_task_type.Size = new System.Drawing.Size(121, 21);
            this.cb_task_type.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task Type";
            // 
            // dtp_start_date
            // 
            this.dtp_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start_date.Location = new System.Drawing.Point(738, 48);
            this.dtp_start_date.Name = "dtp_start_date";
            this.dtp_start_date.Size = new System.Drawing.Size(93, 20);
            this.dtp_start_date.TabIndex = 2;
            // 
            // dtp_edb_date
            // 
            this.dtp_edb_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_edb_date.Location = new System.Drawing.Point(738, 112);
            this.dtp_edb_date.Name = "dtp_edb_date";
            this.dtp_edb_date.Size = new System.Drawing.Size(93, 20);
            this.dtp_edb_date.TabIndex = 3;
            // 
            // txt_task_source
            // 
            this.txt_task_source.Location = new System.Drawing.Point(436, 108);
            this.txt_task_source.Name = "txt_task_source";
            this.txt_task_source.Size = new System.Drawing.Size(130, 20);
            this.txt_task_source.TabIndex = 4;
            // 
            // txt_task_point
            // 
            this.txt_task_point.Location = new System.Drawing.Point(436, 45);
            this.txt_task_point.Name = "txt_task_point";
            this.txt_task_point.Size = new System.Drawing.Size(130, 20);
            this.txt_task_point.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "End :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Source";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Point";
            // 
            // cb_task_group
            // 
            this.cb_task_group.FormattingEnabled = true;
            this.cb_task_group.Location = new System.Drawing.Point(154, 111);
            this.cb_task_group.Name = "cb_task_group";
            this.cb_task_group.Size = new System.Drawing.Size(121, 21);
            this.cb_task_group.TabIndex = 11;
            // 
            // cb_task_student
            // 
            this.cb_task_student.FormattingEnabled = true;
            this.cb_task_student.Location = new System.Drawing.Point(154, 174);
            this.cb_task_student.Name = "cb_task_student";
            this.cb_task_student.Size = new System.Drawing.Size(121, 21);
            this.cb_task_student.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Student";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Note";
            // 
            // txt_task_note
            // 
            this.txt_task_note.Location = new System.Drawing.Point(436, 161);
            this.txt_task_note.Name = "txt_task_note";
            this.txt_task_note.Size = new System.Drawing.Size(130, 20);
            this.txt_task_note.TabIndex = 15;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(348, 244);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(178, 23);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 427);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_task_note);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_task_student);
            this.Controls.Add(this.cb_task_group);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_task_point);
            this.Controls.Add(this.txt_task_source);
            this.Controls.Add(this.dtp_edb_date);
            this.Controls.Add(this.dtp_start_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_task_type);
            this.Name = "NewTaskForm";
            this.Text = "NewTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_task_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_start_date;
        private System.Windows.Forms.DateTimePicker dtp_edb_date;
        private System.Windows.Forms.TextBox txt_task_source;
        private System.Windows.Forms.TextBox txt_task_point;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_task_group;
        private System.Windows.Forms.ComboBox cb_task_student;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_task_note;
        private System.Windows.Forms.Button btn_save;
    }
}